using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// WinForm으로 Hello World 프로그램 만들기
namespace C__200_Example_WinForm
{
    public partial class Form_Example_127 : Form
    {
        public Form_Example_127()
        {
            InitializeComponent();

            Init();
        }

        // 초기화
        private void Init()
        {
            lblText.Text = "";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblText.Text = "Hello! WinForms Forms Application!";
        }
    }
}
