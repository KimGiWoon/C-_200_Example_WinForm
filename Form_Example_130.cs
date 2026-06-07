using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 메세지 박스
namespace C__200_Example_WinForm
{
    public partial class Form_Example_130 : Form
    {
        public Form_Example_130()
        {
            InitializeComponent();

            Init();
        }

        // 초기화
        private void Init()
        {
            this.CenterToScreen();
        }

        // 버튼1 클릭
        private void btn1_Click(object sender, EventArgs e)
        {
            // 기본 메세지 박스
            MessageBox.Show("가장 기본적인 메세지 박스");
        }

        // 버튼2 클릭
        private void btn2_Click(object sender, EventArgs e)
        {
            // 타이틀 메시지 박스
            MessageBox.Show("타이들을 가진 메세지 박스", "Title Message");
        }

        // 버튼3 클릭 
        private void btn3_Click(object sender, EventArgs e)
        {
            // 느낌표와 알람소리 메세지 박스
            DialogResult result1 = MessageBox.Show("느낌표와 알람 메세지 박스", "느낌표와 알람소리", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        // 버튼4 클릭
        private void btn4_Click(object sender, EventArgs e)
        {
            // 두개의 버튼을 갖는 메세지 박스
            DialogResult result2 = MessageBox.Show("두개의 버튼을 갖는 메세지 박스", "Question", MessageBoxButtons.YesNo);
        }

        // 버튼5 클릭
        private void btn5_Click(object sender, EventArgs e)
        {
            // 세개의 버튼과 물음표 아이콘을 보여주는 메세지 박스
            DialogResult result3 = MessageBox.Show("세개의 버튼과 물음표 아이콘을 보여주는 메세지 박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
        }

        // 버튼6 클릭
        private void btn6_Click(object sender, EventArgs e)
        {
            // 디폴트 버튼을 두 번째 버튼으로 지정한 메세지 박스
            DialogResult result4 = MessageBox.Show("디폴트 버튼을 두 번째 버튼으로 지정한 메세지 박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        // 버튼7 클릭
        private void btn7_Click(object sender, EventArgs e)
        {
            // 선택결과를 보여주는 메세지 박스
            DialogResult result5 = MessageBox.Show("선택결과를 보여주는 메세지 박스", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            switch (result5)
            {
                case DialogResult.Yes:
                    MessageBox.Show($"{result5.ToString()} 선택");
                    break;
                case DialogResult.No:
                    MessageBox.Show($"{result5.ToString()} 선택");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show($"{result5.ToString()} 선택");
                    break;
            }
        }
    }
}
