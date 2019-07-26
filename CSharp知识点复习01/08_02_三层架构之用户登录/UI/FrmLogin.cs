using _08_02_三层架构之用户登录.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_02_三层架构之用户登录
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show(UserBLL.OnUserLogin(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim()));
        }

        private void BtnModifyPwd_Click(object sender, EventArgs e)
        {

        }
    }
}
