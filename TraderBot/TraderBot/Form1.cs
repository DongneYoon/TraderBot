using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TraderBot
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.axKHOpenAPI1.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.OnReceiveTrDataPlus);
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            long result;

            result = axKHOpenAPI1.CommConnect();

            if (result != 0)
            {
                MessageBox.Show("Fail open!");
            }
            else
            {
                btn_get.Enabled = true;
            }
        }

        private void UpdateInformation()
        {
            richTextBox1.Text = "";
            richTextBox1.Text += "Login ID : " + axKHOpenAPI1.GetLoginInfo("USER_ID");

            string str = axKHOpenAPI1.GetLoginInfo("ACCNO");

            string[] strArray = str.Split(';');
            richTextBox1.Text += "\n 보유한 계좌 :" + axKHOpenAPI1.GetLoginInfo("ACCOUNT_CNT");

            foreach(string forstring in strArray)
            {
                richTextBox1.Text += "\n Account : " + forstring;
            }

            richTextBox1.Text += "\n User Name :" + axKHOpenAPI1.GetLoginInfo("USER_NAME");
            richTextBox1.Text += "\n 키보드 보안 해지 여부 (0: 정상, 1: 해지) :" + axKHOpenAPI1.GetLoginInfo("KEY_BSECGB");
            richTextBox1.Text += "\n 방화벽 설정 여부 (0: 미설정, 1: 설정, 2: 해지) :" + axKHOpenAPI1.GetLoginInfo("FIREW_SECGB");
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            UpdateInformation();
        }

        private void btn_getInfo_Click(object sender, EventArgs e)
        {
            axKHOpenAPI1.SetInputValue("종목코드", textBox_code.Text.ToString());

            int nRet = axKHOpenAPI1.CommRqData("주식기본정보", "OPT10001", 0, "0101");
        }

        private void OnReceiveTrDataPlus(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            if(e.sRQName == "주식기본정보")
            {
                text_name.Text += axKHOpenAPI1.CommGetData(e.sTrCode,"",e.sRQName, 0, "종목명").ToString().TrimStart(' ');
                text_changeratio.Text = axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 0, "등락율").ToString().TrimStart(' ');
                text_traderatio.Text = axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 0, "거래량").ToString().TrimStart(' ');
                text_value.Text = axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 0, "시가").ToString().TrimStart(' ');
                text_high.Text = axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 0, "고가").ToString().TrimStart(' ');
                text_low.Text = axKHOpenAPI1.CommGetData(e.sTrCode, "", e.sRQName, 0, "저가").ToString().TrimStart(' ');

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
