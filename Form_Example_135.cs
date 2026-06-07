using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 라디오버튼과 그룹박스
namespace C__200_Example_WinForm
{
    public partial class Form_Example_135 : Form
    {
        private string Nationality { get; set; }
        private string Gender { get; set; }

        private List<RadioButton> nationalityButtonList = new List<RadioButton>();
        private List<RadioButton> genderButtonList = new List<RadioButton>();

        public Form_Example_135()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            // 그룹박스에 추가
            grpNationality.Controls.Add(CreateButton("btnKorean", "한국", 20, 30));
            grpNationality.Controls.Add(CreateButton("btnChina", "중국", 20, 60));
            grpNationality.Controls.Add(CreateButton("btnJapan", "일본", 20, 90));
            grpNationality.Controls.Add(CreateButton("btnDefualt", "그 외 국가", 20, 120));

            grpGender.Controls.Add(CreateButton("btnMale", "남성", 20, 30));
            grpGender.Controls.Add(CreateButton("btnFemale", "여성", 20, 60));

            this.CenterToScreen();
        }

        // 버튼 생성
        private RadioButton CreateButton(string name, string text, int x, int y)
        {
            RadioButton button = new RadioButton();
            button.Name = name;
            button.Text = text;
            button.Location = new Point(x, y);
            button.AutoSize = true;

            if (text.Contains("성"))
            {
                genderButtonList.Add(button);
            }
            else
            {
                nationalityButtonList.Add(button);
            }

            return button;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            foreach(RadioButton button in nationalityButtonList)
            {
                if (button.Checked)
                {
                    Nationality = button.Text;
                }
            }

            foreach(RadioButton button in genderButtonList)
            {
                if (button.Checked)
                {
                    Gender = button.Text;
                }
            }

            if (Nationality == null || Gender == null)
            {
                MessageBox.Show("체크를 해주세요");
            }
            else
            {
                MessageBox.Show($"국적 : {Nationality}\n성별 : {Gender}", "결과");
            }
        }
    }
}
