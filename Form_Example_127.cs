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

        private void Form_Example_127_Load(object sender, EventArgs e)
        {
            CenterToParent();   // 폼의 위치를 부모의 중앙 위치로 설정
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();   // 창 닫기
        }
    }
}
