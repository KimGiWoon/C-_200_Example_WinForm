using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 텍스트 박스, 레이블, 버튼 컨트롤
namespace C__200_Example_WinForm
{
    public partial class Form_Example_131 : Form
    {
        private string _name = "";

        public Form_Example_131()
        {
            InitializeComponent();
        }

        // 이름 데이터 넣기
        private void SetName(string text)
        {
            _name = text;
        }

        // 이름 데이터 가져오기
        private string GetName()
        {
            return _name;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (_name == "")
            {
                MessageBox.Show("이름을 입력해주세요.");
            }
            else
            {
                lblText.Text = $"{GetName()}님 안녕하세요!";
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            SetName(txtName.Text);
        }
    }
}
