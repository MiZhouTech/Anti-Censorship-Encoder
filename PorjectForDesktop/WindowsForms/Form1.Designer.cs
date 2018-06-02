namespace WindowsForms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Encode = new System.Windows.Forms.Button();
            this.Decode = new System.Windows.Forms.Button();
            this.EncryptedText = new System.Windows.Forms.TextBox();
            this.RawText = new System.Windows.Forms.TextBox();
            this.KeyString = new System.Windows.Forms.TextBox();
            this.KeyTips = new System.Windows.Forms.Label();
            this.LanguageButton = new System.Windows.Forms.Button();
            this.ErrorText = new System.Windows.Forms.Label();
            this.ErrorTips = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Encode
            // 
            this.Encode.Location = new System.Drawing.Point(422, 104);
            this.Encode.Margin = new System.Windows.Forms.Padding(4);
            this.Encode.Name = "Encode";
            this.Encode.Size = new System.Drawing.Size(148, 28);
            this.Encode.TabIndex = 0;
            this.Encode.Text = "打码 >>";
            this.Encode.UseVisualStyleBackColor = true;
            this.Encode.Click += new System.EventHandler(this.Encode_Click);
            // 
            // Decode
            // 
            this.Decode.Location = new System.Drawing.Point(422, 140);
            this.Decode.Margin = new System.Windows.Forms.Padding(4);
            this.Decode.Name = "Decode";
            this.Decode.Size = new System.Drawing.Size(148, 28);
            this.Decode.TabIndex = 1;
            this.Decode.Text = "<< 解码";
            this.Decode.UseVisualStyleBackColor = true;
            this.Decode.Click += new System.EventHandler(this.Decode_Click);
            // 
            // EncryptedText
            // 
            this.EncryptedText.Location = new System.Drawing.Point(578, 89);
            this.EncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptedText.Multiline = true;
            this.EncryptedText.Name = "EncryptedText";
            this.EncryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EncryptedText.Size = new System.Drawing.Size(413, 475);
            this.EncryptedText.TabIndex = 2;
            this.EncryptedText.Text = "这里输入你想要解码的内容，或显示左边原文已打码的结果";
            // 
            // RawText
            // 
            this.RawText.Location = new System.Drawing.Point(13, 89);
            this.RawText.Margin = new System.Windows.Forms.Padding(4);
            this.RawText.Multiline = true;
            this.RawText.Name = "RawText";
            this.RawText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.RawText.Size = new System.Drawing.Size(401, 475);
            this.RawText.TabIndex = 3;
            this.RawText.Text = "这里输入你想要打码的内容，或显示右边密文被解码的结果";
            // 
            // KeyString
            // 
            this.KeyString.Location = new System.Drawing.Point(30, 41);
            this.KeyString.Margin = new System.Windows.Forms.Padding(4);
            this.KeyString.Name = "KeyString";
            this.KeyString.Size = new System.Drawing.Size(942, 28);
            this.KeyString.TabIndex = 4;
            // 
            // KeyTips
            // 
            this.KeyTips.AutoSize = true;
            this.KeyTips.Font = new System.Drawing.Font("SimSun", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.KeyTips.Location = new System.Drawing.Point(32, 20);
            this.KeyTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.KeyTips.Name = "KeyTips";
            this.KeyTips.Size = new System.Drawing.Size(935, 17);
            this.KeyTips.TabIndex = 5;
            this.KeyTips.Text = "输入神秘代码：（格式： 用杠-分割的-替换字符-最长-可-16组-字词-互相-不能-重复-，-不足时-会有-默认-标点-补位）";
            // 
            // LanguageButton
            // 
            this.LanguageButton.Location = new System.Drawing.Point(422, 283);
            this.LanguageButton.Margin = new System.Windows.Forms.Padding(4);
            this.LanguageButton.Name = "LanguageButton";
            this.LanguageButton.Size = new System.Drawing.Size(148, 115);
            this.LanguageButton.TabIndex = 6;
            this.LanguageButton.Text = "Click to Switch Language\r\n\r\n点我改变语言";
            this.LanguageButton.UseVisualStyleBackColor = true;
            this.LanguageButton.Click += new System.EventHandler(this.LanguageButton_Click);
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ErrorText.Location = new System.Drawing.Point(31, 606);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(0, 19);
            this.ErrorText.TabIndex = 7;
            // 
            // ErrorTips
            // 
            this.ErrorTips.AutoSize = true;
            this.ErrorTips.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.ErrorTips.Location = new System.Drawing.Point(27, 580);
            this.ErrorTips.Name = "ErrorTips";
            this.ErrorTips.Size = new System.Drawing.Size(0, 19);
            this.ErrorTips.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(480, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "开发者weibo @技术宅痴女 http://weibo.com/TechLizard";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 638);
            this.Controls.Add(this.KeyString);
            this.Controls.Add(this.ErrorTips);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.LanguageButton);
            this.Controls.Add(this.KeyTips);
            this.Controls.Add(this.RawText);
            this.Controls.Add(this.EncryptedText);
            this.Controls.Add(this.Decode);
            this.Controls.Add(this.Encode);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("SimSun", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "文字打码助手 - 测试版 v0.0.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Encode;
        private System.Windows.Forms.Button Decode;
        private System.Windows.Forms.TextBox EncryptedText;
        private System.Windows.Forms.TextBox RawText;
        private System.Windows.Forms.TextBox KeyString;
        private System.Windows.Forms.Label KeyTips;
        private System.Windows.Forms.Button LanguageButton;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label ErrorTips;
        private System.Windows.Forms.Label label1;
    }
}

