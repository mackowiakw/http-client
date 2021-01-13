
namespace http_client
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSend = new System.Windows.Forms.Button();
            this.requestBodyBox = new System.Windows.Forms.TextBox();
            this.requestGroupBox = new System.Windows.Forms.GroupBox();
            this.portLabel = new System.Windows.Forms.Label();
            this.serverLabel = new System.Windows.Forms.Label();
            this.includeBodyCheckBox = new System.Windows.Forms.CheckBox();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.serverTextBox = new System.Windows.Forms.TextBox();
            this.useCustomMethodCheckBox = new System.Windows.Forms.CheckBox();
            this.resource = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.methodsComboBox = new System.Windows.Forms.ComboBox();
            this.URLLabel = new System.Windows.Forms.Label();
            this.sendGroupBox = new System.Windows.Forms.GroupBox();
            this.methodLabel = new System.Windows.Forms.Label();
            this.responseBodyBox = new System.Windows.Forms.TextBox();
            this.responseHeadersBox = new System.Windows.Forms.TextBox();
            this.responseStatusMessageLabel = new System.Windows.Forms.Label();
            this.responseGroupBox = new System.Windows.Forms.GroupBox();
            this.responseStatusCodeLabel = new System.Windows.Forms.Label();
            this.requestGroupBox.SuspendLayout();
            this.sendGroupBox.SuspendLayout();
            this.responseGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(285, 86);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(63, 25);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // requestBodyBox
            // 
            this.requestBodyBox.Location = new System.Drawing.Point(6, 146);
            this.requestBodyBox.Multiline = true;
            this.requestBodyBox.Name = "requestBodyBox";
            this.requestBodyBox.Size = new System.Drawing.Size(364, 105);
            this.requestBodyBox.TabIndex = 4;
            this.requestBodyBox.Text = "Enter your message here";
            this.requestBodyBox.Visible = false;
            // 
            // requestGroupBox
            // 
            this.requestGroupBox.Controls.Add(this.portLabel);
            this.requestGroupBox.Controls.Add(this.serverLabel);
            this.requestGroupBox.Controls.Add(this.requestBodyBox);
            this.requestGroupBox.Controls.Add(this.includeBodyCheckBox);
            this.requestGroupBox.Controls.Add(this.methodTextBox);
            this.requestGroupBox.Controls.Add(this.portTextBox);
            this.requestGroupBox.Controls.Add(this.serverTextBox);
            this.requestGroupBox.Controls.Add(this.useCustomMethodCheckBox);
            this.requestGroupBox.Location = new System.Drawing.Point(12, 12);
            this.requestGroupBox.Name = "requestGroupBox";
            this.requestGroupBox.Size = new System.Drawing.Size(376, 257);
            this.requestGroupBox.TabIndex = 5;
            this.requestGroupBox.TabStop = false;
            this.requestGroupBox.Text = "Request";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(6, 61);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(34, 19);
            this.portLabel.TabIndex = 3;
            this.portLabel.Text = "Port";
            // 
            // serverLabel
            // 
            this.serverLabel.AutoSize = true;
            this.serverLabel.Location = new System.Drawing.Point(6, 27);
            this.serverLabel.Name = "serverLabel";
            this.serverLabel.Size = new System.Drawing.Size(47, 19);
            this.serverLabel.TabIndex = 2;
            this.serverLabel.Text = "Server";
            // 
            // includeBodyCheckBox
            // 
            this.includeBodyCheckBox.AutoSize = true;
            this.includeBodyCheckBox.Location = new System.Drawing.Point(6, 128);
            this.includeBodyCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.includeBodyCheckBox.Name = "includeBodyCheckBox";
            this.includeBodyCheckBox.Size = new System.Drawing.Size(107, 23);
            this.includeBodyCheckBox.TabIndex = 15;
            this.includeBodyCheckBox.Text = "Include Body";
            this.includeBodyCheckBox.UseVisualStyleBackColor = true;
            this.includeBodyCheckBox.CheckedChanged += new System.EventHandler(this.includeBodyCheckBox_CheckedChanged);
            // 
            // methodTextBox
            // 
            this.methodTextBox.Location = new System.Drawing.Point(162, 101);
            this.methodTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.methodTextBox.MaxLength = 10;
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(79, 25);
            this.methodTextBox.TabIndex = 17;
            this.methodTextBox.Text = "POST";
            this.methodTextBox.Visible = false;
            this.methodTextBox.TextChanged += new System.EventHandler(this.methodTextBox_TextChanged);
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(59, 58);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(122, 25);
            this.portTextBox.TabIndex = 1;
            this.portTextBox.Text = "8080";
            this.portTextBox.TextChanged += new System.EventHandler(this.port_TextChanged);
            // 
            // serverTextBox
            // 
            this.serverTextBox.Location = new System.Drawing.Point(59, 24);
            this.serverTextBox.Name = "serverTextBox";
            this.serverTextBox.Size = new System.Drawing.Size(122, 25);
            this.serverTextBox.TabIndex = 0;
            this.serverTextBox.Text = "127.0.0.1";
            this.serverTextBox.TextChanged += new System.EventHandler(this.server_TextChanged);
            // 
            // useCustomMethodCheckBox
            // 
            this.useCustomMethodCheckBox.AutoSize = true;
            this.useCustomMethodCheckBox.Location = new System.Drawing.Point(6, 101);
            this.useCustomMethodCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.useCustomMethodCheckBox.Name = "useCustomMethodCheckBox";
            this.useCustomMethodCheckBox.Size = new System.Drawing.Size(152, 23);
            this.useCustomMethodCheckBox.TabIndex = 16;
            this.useCustomMethodCheckBox.Text = "Use custom method";
            this.useCustomMethodCheckBox.UseVisualStyleBackColor = true;
            this.useCustomMethodCheckBox.CheckedChanged += new System.EventHandler(this.useCustomMethodCheckBox_CheckedChanged);
            // 
            // resource
            // 
            this.resource.AcceptsReturn = true;
            this.resource.Location = new System.Drawing.Point(81, 87);
            this.resource.Margin = new System.Windows.Forms.Padding(2);
            this.resource.Name = "resource";
            this.resource.Size = new System.Drawing.Size(199, 25);
            this.resource.TabIndex = 5;
            this.resource.Text = "index.html";
            this.resource.TextChanged += new System.EventHandler(this.resource_TextChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 441);
            this.splitter1.TabIndex = 19;
            this.splitter1.TabStop = false;
            // 
            // methodsComboBox
            // 
            this.methodsComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.methodsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodsComboBox.FormattingEnabled = true;
            this.methodsComboBox.Items.AddRange(new object[] {
            "GET",
            "HEAD",
            "PUT",
            "DELETE",
            "Custom"});
            this.methodsComboBox.Location = new System.Drawing.Point(6, 87);
            this.methodsComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.methodsComboBox.Name = "methodsComboBox";
            this.methodsComboBox.Size = new System.Drawing.Size(71, 25);
            this.methodsComboBox.TabIndex = 13;
            this.methodsComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // URLLabel
            // 
            this.URLLabel.AutoSize = true;
            this.URLLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.URLLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.URLLabel.Location = new System.Drawing.Point(74, 35);
            this.URLLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URLLabel.MinimumSize = new System.Drawing.Size(296, 0);
            this.URLLabel.Name = "URLLabel";
            this.URLLabel.Padding = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.URLLabel.Size = new System.Drawing.Size(296, 33);
            this.URLLabel.TabIndex = 14;
            this.URLLabel.Text = "http://localhost:8080/index.txt";
            // 
            // sendGroupBox
            // 
            this.sendGroupBox.Controls.Add(this.URLLabel);
            this.sendGroupBox.Controls.Add(this.methodLabel);
            this.sendGroupBox.Controls.Add(this.resource);
            this.sendGroupBox.Controls.Add(this.methodsComboBox);
            this.sendGroupBox.Controls.Add(this.btnSend);
            this.sendGroupBox.Location = new System.Drawing.Point(12, 275);
            this.sendGroupBox.Name = "sendGroupBox";
            this.sendGroupBox.Size = new System.Drawing.Size(376, 160);
            this.sendGroupBox.TabIndex = 18;
            this.sendGroupBox.TabStop = false;
            // 
            // methodLabel
            // 
            this.methodLabel.AutoSize = true;
            this.methodLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.methodLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.methodLabel.Location = new System.Drawing.Point(8, 35);
            this.methodLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.methodLabel.MaximumSize = new System.Drawing.Size(100, 0);
            this.methodLabel.MinimumSize = new System.Drawing.Size(70, 0);
            this.methodLabel.Name = "methodLabel";
            this.methodLabel.Padding = new System.Windows.Forms.Padding(2, 4, 0, 4);
            this.methodLabel.Size = new System.Drawing.Size(70, 33);
            this.methodLabel.TabIndex = 14;
            this.methodLabel.Text = "GET";
            // 
            // responseBodyBox
            // 
            this.responseBodyBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.responseBodyBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseBodyBox.Location = new System.Drawing.Point(5, 186);
            this.responseBodyBox.Margin = new System.Windows.Forms.Padding(2);
            this.responseBodyBox.Multiline = true;
            this.responseBodyBox.Name = "responseBodyBox";
            this.responseBodyBox.ReadOnly = true;
            this.responseBodyBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseBodyBox.Size = new System.Drawing.Size(397, 231);
            this.responseBodyBox.TabIndex = 12;
            this.responseBodyBox.Text = "Recived message will be shown here.";
            // 
            // responseHeadersBox
            // 
            this.responseHeadersBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.responseHeadersBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseHeadersBox.Location = new System.Drawing.Point(5, 74);
            this.responseHeadersBox.Multiline = true;
            this.responseHeadersBox.Name = "responseHeadersBox";
            this.responseHeadersBox.ReadOnly = true;
            this.responseHeadersBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.responseHeadersBox.Size = new System.Drawing.Size(397, 107);
            this.responseHeadersBox.TabIndex = 3;
            this.responseHeadersBox.Text = "HTTP/1.1 200 OK\r\nServer: SK inf1412(54|69)\r\nDate: Wed Jan 13 20:35:38 2021 GMT\r\nC" +
    "ontent-Type: text/plain; charset=ASCII\r\nContent-Length: 34\r\n";
            // 
            // responseStatusMessageLabel
            // 
            this.responseStatusMessageLabel.AutoSize = true;
            this.responseStatusMessageLabel.BackColor = System.Drawing.SystemColors.Control;
            this.responseStatusMessageLabel.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseStatusMessageLabel.Location = new System.Drawing.Point(83, 23);
            this.responseStatusMessageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.responseStatusMessageLabel.Name = "responseStatusMessageLabel";
            this.responseStatusMessageLabel.Size = new System.Drawing.Size(197, 42);
            this.responseStatusMessageLabel.TabIndex = 8;
            this.responseStatusMessageLabel.Text = "Connecting...";
            // 
            // responseGroupBox
            // 
            this.responseGroupBox.Controls.Add(this.responseStatusMessageLabel);
            this.responseGroupBox.Controls.Add(this.responseStatusCodeLabel);
            this.responseGroupBox.Controls.Add(this.responseBodyBox);
            this.responseGroupBox.Controls.Add(this.responseHeadersBox);
            this.responseGroupBox.Location = new System.Drawing.Point(394, 12);
            this.responseGroupBox.Name = "responseGroupBox";
            this.responseGroupBox.Size = new System.Drawing.Size(409, 422);
            this.responseGroupBox.TabIndex = 20;
            this.responseGroupBox.TabStop = false;
            this.responseGroupBox.Text = "Response";
            // 
            // responseStatusCodeLabel
            // 
            this.responseStatusCodeLabel.AutoSize = true;
            this.responseStatusCodeLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.responseStatusCodeLabel.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.responseStatusCodeLabel.Location = new System.Drawing.Point(5, 21);
            this.responseStatusCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.responseStatusCodeLabel.Name = "responseStatusCodeLabel";
            this.responseStatusCodeLabel.Size = new System.Drawing.Size(74, 46);
            this.responseStatusCodeLabel.TabIndex = 18;
            this.responseStatusCodeLabel.Text = "200";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 441);
            this.Controls.Add(this.sendGroupBox);
            this.Controls.Add(this.responseGroupBox);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.requestGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "HTTP Client";
            this.requestGroupBox.ResumeLayout(false);
            this.requestGroupBox.PerformLayout();
            this.sendGroupBox.ResumeLayout(false);
            this.sendGroupBox.PerformLayout();
            this.responseGroupBox.ResumeLayout(false);
            this.responseGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox requestBodyBox;
        private System.Windows.Forms.GroupBox requestGroupBox;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.Label serverLabel;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.TextBox serverTextBox;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox resource;
        private System.Windows.Forms.ComboBox methodsComboBox;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.CheckBox includeBodyCheckBox;
        private System.Windows.Forms.CheckBox useCustomMethodCheckBox;
        private System.Windows.Forms.TextBox methodTextBox;
        private System.Windows.Forms.GroupBox sendGroupBox;
        private System.Windows.Forms.TextBox responseHeadersBox;
        private System.Windows.Forms.Label responseStatusMessageLabel;
        private System.Windows.Forms.TextBox responseBodyBox;
        private System.Windows.Forms.GroupBox responseGroupBox;
        private System.Windows.Forms.Label responseStatusCodeLabel;
        private System.Windows.Forms.Label methodLabel;
    }
}

