using System;
using System.Windows.Forms;

namespace _03_Winform两个窗体传值
{
    public partial class FrmSecond : Form
    {
        public Action<string> sendMessage;
        public FrmSecond()
        {
            InitializeComponent();

        }
        public void ReceiveMessage(string message)
        {
            this.txtInput.Text = message;
        }
    }
}
