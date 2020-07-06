namespace VolvoS90PlayListMaker
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBox_HintMessage = new System.Windows.Forms.RichTextBox();
            this.TextBox_Result = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Button_Run = new System.Windows.Forms.Button();
            this.Button_Rescan = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择U盘盘符：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 20);
            this.comboBox1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "生成播放列表：";
            // 
            // TextBox_HintMessage
            // 
            this.TextBox_HintMessage.Location = new System.Drawing.Point(33, 347);
            this.TextBox_HintMessage.Name = "TextBox_HintMessage";
            this.TextBox_HintMessage.Size = new System.Drawing.Size(436, 160);
            this.TextBox_HintMessage.TabIndex = 3;
            this.TextBox_HintMessage.Text = "";
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Location = new System.Drawing.Point(33, 107);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(436, 195);
            this.TextBox_Result.TabIndex = 3;
            this.TextBox_Result.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "使用帮助：";
            // 
            // Button_Run
            // 
            this.Button_Run.Location = new System.Drawing.Point(207, 61);
            this.Button_Run.Name = "Button_Run";
            this.Button_Run.Size = new System.Drawing.Size(75, 23);
            this.Button_Run.TabIndex = 4;
            this.Button_Run.Text = "生成";
            this.Button_Run.UseVisualStyleBackColor = true;
            this.Button_Run.Click += new System.EventHandler(this.Button_Run_Click);
            // 
            // Button_Rescan
            // 
            this.Button_Rescan.Location = new System.Drawing.Point(335, 21);
            this.Button_Rescan.Name = "Button_Rescan";
            this.Button_Rescan.Size = new System.Drawing.Size(75, 23);
            this.Button_Rescan.TabIndex = 5;
            this.Button_Rescan.Text = "重新扫描";
            this.Button_Rescan.UseVisualStyleBackColor = true;
            this.Button_Rescan.Click += new System.EventHandler(this.Button_Rescan_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(288, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 538);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Button_Rescan);
            this.Controls.Add(this.Button_Run);
            this.Controls.Add(this.TextBox_Result);
            this.Controls.Add(this.TextBox_HintMessage);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VolvoS90车机播放列表生成器";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox TextBox_HintMessage;
        private System.Windows.Forms.RichTextBox TextBox_Result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Button_Run;
        private System.Windows.Forms.Button Button_Rescan;
        private System.Windows.Forms.Label label6;
    }
}

