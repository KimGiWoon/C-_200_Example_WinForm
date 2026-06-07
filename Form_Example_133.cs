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
        public bool Flag { get; set; }

        public Form_Example_133()
        {
            InitializeComponent();
        }

        private bool IsFlag()
        {
            return _flag;
        }

        private void SetFlag(bool value)
        {
            _flag = value;
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            if (IsFlag() == false)
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

            //-------------------------------------------------------------
            //SetFlag(!IsFlag());   // !Flag를 활용한 토글 방식으로 구현 가능

            //if (IsFlag())
            //{
            //    lblText.Text = "안녕하세요~!";
            //    btnHello.Text = "초기화";
            //}
            //else
            //{
            //    lblText.Text = "";
            //    btnHello.Text = "인사하기";
            //}

            //-------------------------------------------------------------
            //Flag = !Flag;   // 프로퍼티를 사용하여 구현 가능

            //if (Flag)
            //{
            //    lblText.Text = "안녕하세요~!";
            //    btnHello.Text = "초기화";
            //}
            //else
            //{
            //    lblText.Text = "";
            //    btnHello.Text = "인사하기";
            //}
        }
    }
}
