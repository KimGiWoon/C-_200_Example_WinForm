using System;
using System.Drawing;
using System.Windows.Forms;

// 성적계산기
namespace C__200_Example_WinForm
{
    public partial class Form_Example_137 : Form
    {
        private TextBox txtScore1 = null;
        private TextBox txtScore2 = null;
        private TextBox txtScore3 = null;
        private TextBox txtTotalScore = null;
        private TextBox txtAverage = null;

        private int maxSub = 3;

        public Form_Example_137()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            txtScore1 = CreateTextBox("txtScore1", "", 70, 40, false);
            txtScore2 = CreateTextBox("txtScore2", "", 70, 80, false);
            txtScore3 = CreateTextBox("txtScore3", "", 70, 120, false);

            groupBox1.Controls.Add(CreateLabel("lblSubject1", "국어", 20, 40));
            groupBox1.Controls.Add(CreateLabel("lblSubject2", "수학", 20, 80));
            groupBox1.Controls.Add(CreateLabel("lblSubject3", "영어", 20, 120));
            groupBox1.Controls.Add(txtScore1);
            groupBox1.Controls.Add(txtScore2);
            groupBox1.Controls.Add(txtScore3);

            txtTotalScore = CreateTextBox("txtTotalScore", "", 70, 40, true);
            txtAverage = CreateTextBox("txtAverage", "", 70, 80, true);

            groupBox2.Controls.Add(CreateLabel("lblTotal", "총점", 20, 40));
            groupBox2.Controls.Add(CreateLabel("lblAverage", "평균", 20, 80));
            groupBox2.Controls.Add(txtTotalScore);
            groupBox2.Controls.Add(txtAverage);

            this.CenterToScreen();
        }

        // 라벨 생성
        private Label CreateLabel(string name, string text, int x, int y)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.Location = new Point(x, y);
            label.AutoSize = false;
            label.Size = new Size(30, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;

            return label;
        }

        // 텍스트 박스 생성
        private TextBox CreateTextBox(string name, string text, int x, int y, bool read)
        {
            TextBox textBox = new TextBox();
            textBox.Name = name;
            textBox.Text = text;
            textBox.Location = new Point(x, y);
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.ReadOnly = read;
            textBox.TextAlign = HorizontalAlignment.Center;

            return textBox;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int totalScore = 0;
            double scoreAverage = 0;

            if (txtScore1.Text == "" || txtScore2.Text == "" || txtScore3.Text == "")
            {
                MessageBox.Show("점수를 모두 입력하세요");
                return;
            }

            totalScore = int.Parse(txtScore1.Text) + int.Parse(txtScore2.Text) + int.Parse(txtScore3.Text);
            scoreAverage = totalScore / maxSub;

            txtTotalScore.Text = totalScore.ToString();
            txtAverage.Text = scoreAverage.ToString("F1");
        }
    }
}
