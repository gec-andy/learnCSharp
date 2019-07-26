using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Winform两个窗体传值
{
    public partial class FrmMain : Form
    {
        public FrmSecond frmSecond = null;
        public bool isShow = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (this.frmSecond == null)
            {
                this.frmSecond = new FrmSecond();
                //注册这个委托事件
                this.frmSecond.sendMessage += this.frmSecond.ReceiveMessage;
                this.frmSecond.Show();
            }
            this.frmSecond.sendMessage(this.txtInput.Text);
            //frmSend.Show();
            //// frmSend.sendMessage += frmSend.ReceiveMessage(this.txtInput.Text.ToString());
            //frmSend.sendMessage += frmSend.ReceiveMessage;
            //frmSend.sendMessage(this.txtInput.Text);
            //if (isShow == false)
            //{
            //    this.frmSecond.Show();
            //    isShow = true;
            //}
            //else
            //{
            //    this.frmSecond.Hide();
            //    isShow = false;
            //}

        }
    }
}
