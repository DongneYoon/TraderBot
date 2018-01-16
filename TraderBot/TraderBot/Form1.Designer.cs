namespace TraderBot
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            this.btn_login = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_get = new System.Windows.Forms.Button();
            this.btn_getInfo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.text_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.text_changeratio = new System.Windows.Forms.TextBox();
            this.text_traderatio = new System.Windows.Forms.TextBox();
            this.text_value = new System.Windows.Forms.TextBox();
            this.text_high = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_low = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(0, 0);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 19;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 69);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(302, 353);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login Information";
            // 
            // btn_get
            // 
            this.btn_get.Enabled = false;
            this.btn_get.Location = new System.Drawing.Point(240, 113);
            this.btn_get.Name = "btn_get";
            this.btn_get.Size = new System.Drawing.Size(75, 23);
            this.btn_get.TabIndex = 4;
            this.btn_get.Text = "Get";
            this.btn_get.UseVisualStyleBackColor = true;
            this.btn_get.Click += new System.EventHandler(this.btn_get_Click);
            // 
            // btn_getInfo
            // 
            this.btn_getInfo.Location = new System.Drawing.Point(599, 110);
            this.btn_getInfo.Name = "btn_getInfo";
            this.btn_getInfo.Size = new System.Drawing.Size(74, 23);
            this.btn_getInfo.TabIndex = 6;
            this.btn_getInfo.Text = "GetInfo";
            this.btn_getInfo.UseVisualStyleBackColor = true;
            this.btn_getInfo.Click += new System.EventHandler(this.btn_getInfo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "종목코드 :";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(401, 112);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(125, 21);
            this.textBox_code.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "종목명 :";
            // 
            // text_name
            // 
            this.text_name.Enabled = false;
            this.text_name.Location = new System.Drawing.Point(401, 150);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(125, 21);
            this.text_name.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(326, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "등락율 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(326, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "거래율 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(326, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "시가 :";
            // 
            // text_changeratio
            // 
            this.text_changeratio.Location = new System.Drawing.Point(401, 185);
            this.text_changeratio.Name = "text_changeratio";
            this.text_changeratio.Size = new System.Drawing.Size(122, 21);
            this.text_changeratio.TabIndex = 16;
            // 
            // text_traderatio
            // 
            this.text_traderatio.Location = new System.Drawing.Point(401, 225);
            this.text_traderatio.Name = "text_traderatio";
            this.text_traderatio.Size = new System.Drawing.Size(122, 21);
            this.text_traderatio.TabIndex = 17;
            // 
            // text_value
            // 
            this.text_value.Location = new System.Drawing.Point(401, 259);
            this.text_value.Name = "text_value";
            this.text_value.Size = new System.Drawing.Size(122, 21);
            this.text_value.TabIndex = 18;
            // 
            // text_high
            // 
            this.text_high.Location = new System.Drawing.Point(401, 296);
            this.text_high.Name = "text_high";
            this.text_high.Size = new System.Drawing.Size(122, 21);
            this.text_high.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "고가 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "저가 :";
            // 
            // text_low
            // 
            this.text_low.Location = new System.Drawing.Point(401, 332);
            this.text_low.Name = "text_low";
            this.text_low.Size = new System.Drawing.Size(122, 21);
            this.text_low.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 523);
            this.Controls.Add(this.text_low);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.text_high);
            this.Controls.Add(this.text_value);
            this.Controls.Add(this.text_traderatio);
            this.Controls.Add(this.text_changeratio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_getInfo);
            this.Controls.Add(this.btn_get);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.axKHOpenAPI1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_get;
        private System.Windows.Forms.Button btn_getInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox text_changeratio;
        private System.Windows.Forms.TextBox text_traderatio;
        private System.Windows.Forms.TextBox text_value;
        private System.Windows.Forms.TextBox text_high;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_low;
    }
}

