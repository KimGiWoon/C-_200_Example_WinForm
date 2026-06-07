using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// MaskedTextBox (마스크 텍스트 박스)
namespace C__200_Example_WinForm
{
    public partial class Form_Example_138 : Form
    {
        public Form_Example_138()
        {
            InitializeComponent();

            this.CenterToScreen();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            string str;

            str = "입사일: " + txtDate.Text + "\n";
            str += "우편번호: " + txtMail.Text + "\n";
            str += "주소: " + txtAddr.Text + "\n";
            str += "휴대폰 번호: " + txtPhone.Text + "\n";
            str += "주민등록번호: " + txtId.Text + "\n";
            str += "이메일: " + txtEmail.Text + "\n";

            MessageBox.Show(str, "개인정보");
        }
    }
}
