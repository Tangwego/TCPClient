namespace TcpClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.headerInput = new System.Windows.Forms.Panel();
            this.lenBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.portText = new System.Windows.Forms.TextBox();
            this.sendBtn = new System.Windows.Forms.Button();
            this.urlText = new System.Windows.Forms.TextBox();
            this.recvText = new System.Windows.Forms.RichTextBox();
            this.sendText = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lenText = new System.Windows.Forms.Label();
            this.headerInput.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerInput
            // 
            this.headerInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.headerInput.BackColor = System.Drawing.Color.Transparent;
            this.headerInput.Controls.Add(this.lenBit);
            this.headerInput.Controls.Add(this.label3);
            this.headerInput.Controls.Add(this.label2);
            this.headerInput.Controls.Add(this.label1);
            this.headerInput.Controls.Add(this.portText);
            this.headerInput.Controls.Add(this.sendBtn);
            this.headerInput.Controls.Add(this.urlText);
            this.headerInput.Location = new System.Drawing.Point(12, 1);
            this.headerInput.Name = "headerInput";
            this.headerInput.Size = new System.Drawing.Size(689, 40);
            this.headerInput.TabIndex = 0;
            // 
            // lenBit
            // 
            this.lenBit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lenBit.FormatString = "N0";
            this.lenBit.FormattingEnabled = true;
            this.lenBit.Items.AddRange(new object[] {
            "1",
            "2",
            "4",
            "6",
            "8",
            "10"});
            this.lenBit.Location = new System.Drawing.Point(497, 7);
            this.lenBit.Name = "lenBit";
            this.lenBit.Size = new System.Drawing.Size(70, 20);
            this.lenBit.TabIndex = 2;
            this.lenBit.Text = "8";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "长度位：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "IP：";
            // 
            // portText
            // 
            this.portText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portText.Location = new System.Drawing.Point(380, 8);
            this.portText.Name = "portText";
            this.portText.Size = new System.Drawing.Size(61, 21);
            this.portText.TabIndex = 1;
            this.portText.Text = "9991";
            // 
            // sendBtn
            // 
            this.sendBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sendBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.sendBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.sendBtn.ForeColor = System.Drawing.Color.White;
            this.sendBtn.Location = new System.Drawing.Point(586, 4);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(79, 31);
            this.sendBtn.TabIndex = 3;
            this.sendBtn.Text = "Send";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // urlText
            // 
            this.urlText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.urlText.Location = new System.Drawing.Point(39, 7);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(288, 21);
            this.urlText.TabIndex = 0;
            this.urlText.Text = "192.168.0.181";
            // 
            // recvText
            // 
            this.recvText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recvText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recvText.Location = new System.Drawing.Point(12, 3);
            this.recvText.Name = "recvText";
            this.recvText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.recvText.Size = new System.Drawing.Size(686, 182);
            this.recvText.TabIndex = 5;
            this.recvText.Text = "";
            // 
            // sendText
            // 
            this.sendText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sendText.Location = new System.Drawing.Point(12, 3);
            this.sendText.Name = "sendText";
            this.sendText.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.sendText.Size = new System.Drawing.Size(686, 141);
            this.sendText.TabIndex = 4;
            this.sendText.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 40);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.sendText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lenText);
            this.splitContainer1.Panel2.Controls.Add(this.recvText);
            this.splitContainer1.Size = new System.Drawing.Size(701, 364);
            this.splitContainer1.SplitterDistance = 148;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 5;
            this.splitContainer1.TabStop = false;
            // 
            // lenText
            // 
            this.lenText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lenText.AutoSize = true;
            this.lenText.Location = new System.Drawing.Point(583, 192);
            this.lenText.Name = "lenText";
            this.lenText.Size = new System.Drawing.Size(71, 12);
            this.lenText.TabIndex = 5;
            this.lenText.Text = "返回长度: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(701, 406);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.headerInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TCP客户端";
            this.headerInput.ResumeLayout(false);
            this.headerInput.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerInput;
        private System.Windows.Forms.TextBox urlText;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox portText;
        private System.Windows.Forms.RichTextBox recvText;
        private System.Windows.Forms.RichTextBox sendText;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lenText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lenBit;

    }
}

