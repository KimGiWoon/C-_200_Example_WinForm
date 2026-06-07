using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 로그인 창 만들기
namespace C__200_Example_WinForm
{
    public partial class Form_Example_136 : Form
    {
        private string userId = "rldns";
        private string userPassword = "1234";

        public Form_Example_136()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserId.Text == userId && txtUserPassword.Text == userPassword)
            {
                lblLoginState.Text = "로그인 성공";
                MessageBox.Show("로그인 했습니다.", "확인");
            }
            else
            {
                lblLoginState.Text = "로그인 실패";

                if (txtUserId.Text == userId)
                {
                    MessageBox.Show("패스워드가 틀렸습니다.", "확인");
                    txtUserPassword.Clear();
                    txtUserPassword.Focus();               
                }
                else if (txtUserPassword.Text == userPassword)
                {
                    MessageBox.Show("아이디가 틀렸습니다.", "확인");
                    txtUserId.Clear();
                    txtUserId.Focus();
                }
                else
                {
                    MessageBox.Show("아이디와 패스워드를 입력해주세요.", "확인");
                    txtUserId.Focus();
                }
            }
        }
    }
}
