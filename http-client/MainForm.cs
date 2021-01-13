using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace http_client
{
    public partial class MainForm : Form
    {
        string URL, method;
        HttpWebResponse response;

        public MainForm()
        {
            InitializeComponent();
            updateURLMethodLabels();
            methodsComboBox.SelectedIndex = 0;
            methodTextBox.KeyDown += new KeyEventHandler(enter_KeyDown);
            resource.KeyDown += new KeyEventHandler(enter_KeyDown);

            responseStatusCodeLabel.Text = "      ";
            responseStatusMessageLabel.Text = "";
            responseHeadersBox.Text = "";
            responseBodyBox.Text = "";

            Label.CheckForIllegalCrossThreadCalls = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            CheckBox.CheckForIllegalCrossThreadCalls = false;
            ComboBox.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            send();
        }

        private void enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = false;
                e.SuppressKeyPress = false;
                send();
            }
        }

        private void updateURLMethodLabels()
        {
            URL = $"http://{serverTextBox.Text}:{portTextBox.Text}/{resource.Text}";
            method = useCustomMethodCheckBox.Checked ? methodTextBox.Text.ToUpper() : methodsComboBox.Text;

            URLLabel.Text = URL;
            methodLabel.Text = method;
        }

        private void updateResponseArea()
        {
            if (response != null)
            {
                string rawHeaders = response.Headers.ToString().TrimEnd();

                int statusCode = (int)response.StatusCode;
                Color newColor = default;

                if (statusCode >= 200)
                {
                    newColor = Color.LightGreen;
                }
                if (statusCode >= 300)
                {
                    newColor = Color.MediumPurple;
                }
                if (statusCode >= 400)
                {
                    newColor = Color.Orange;
                }
                if (statusCode >= 500)
                {
                    newColor = Color.Red;
                }

                responseStatusCodeLabel.BackColor = newColor;
                responseStatusCodeLabel.Text = $"{statusCode}";

                responseStatusMessageLabel.Text = response.StatusDescription;

                responseHeadersBox.Text = $"HTTP/{response.ProtocolVersion} {statusCode} {response.StatusDescription}\r\n{rawHeaders}";
                responseBodyBox.Text = new StreamReader(response.GetResponseStream()).ReadToEnd();
            }
            else
            {
                responseStatusMessageLabel.Text = "Server Unreachable";
                responseStatusMessageLabel.ForeColor = Color.Red;
            }
        }


        private void send()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);

                responseStatusCodeLabel.Text = "      ";
                responseStatusCodeLabel.BackColor = SystemColors.ControlLight;

                responseStatusMessageLabel.Text = "Connecting...";
                responseStatusMessageLabel.ForeColor = default;

                responseHeadersBox.Text = "";
                responseBodyBox.Text = "";

                if (method == "")
                {
                    request.Method = "GET";
                    methodLabel.Text = "GET";
                    methodsComboBox.SelectedIndex = 4;
                }
                else
                {
                    request.Method = method;
                }

                if (includeBodyCheckBox.Checked)
                {
                    if (new Regex("GET|HEAD").IsMatch(method))
                    {
                        includeBodyCheckBox.Checked = false;
                    }
                    else
                    {
                        byte[] bytes = Encoding.ASCII.GetBytes(requestBodyBox.Text);
                        request.GetRequestStream().Write(bytes, 0, bytes.Length);
                    }
                }

                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (WebException we)
                {
                    response = (HttpWebResponse)we.Response;
                }

                updateResponseArea();

            }).Start();

        }

        private void server_TextChanged(object sender, EventArgs e)
        {
            updateURLMethodLabels();
        }

        private void port_TextChanged(object sender, EventArgs e)
        {
            updateURLMethodLabels();
        }

        private void methodTextBox_TextChanged(object sender, EventArgs e)
        {
            updateURLMethodLabels();
        }

        private void resource_TextChanged(object sender, EventArgs e)
        {
            updateURLMethodLabels();
        }

        private void includeBodyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            requestBodyBox.Visible = includeBodyCheckBox.Checked;
        }

        private void useCustomMethodCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (useCustomMethodCheckBox.Checked)
            {
                methodTextBox.Visible = true;
                methodsComboBox.SelectedIndex = 4;
            }
            else
            {
                methodTextBox.Visible = false;
                methodsComboBox.SelectedIndex = 0;
            }
            updateURLMethodLabels();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (methodsComboBox.SelectedIndex == 4)
            {
                useCustomMethodCheckBox.Checked = true;
            }
            else
            {
                useCustomMethodCheckBox.Checked = false;
            }
            updateURLMethodLabels();
        }
    }
}
