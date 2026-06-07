using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Flag를 이용한 이벤트 처리
namespace C__200_Example_WinForm
{
    public partial class Form_Example_133 : Form
    {
        private bool _flag = false;

        public Form_Example_133()
        {
            InitializeComponent();
        }

        private bool GetFlag()
        {
            return _flag;
        }

        private void SetFlag(bool value)
        {
            _flag = value;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (GetFlag() == false)
            {
                SetFlag(true);
                lblText.Text = "안녕하세요~!";
                btnHello.Text = "초기화";
            }
            else
            {
                SetFlag(false);
                lblText.Text = "";
                btnHello.Text = "인사하기";
            }
        }
    }
}
