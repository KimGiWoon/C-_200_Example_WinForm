using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 체크 박스
namespace C__200_Example_WinForm
{
    public partial class Form_Example_134 : Form
    {
        List<CheckBox> boxList = new List<CheckBox>();
        string[] bestFruitArray = null;

        public Form_Example_134()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            timer1.Start();

            chb1.Text = "사과";
            chb2.Text = "배";
            chb3.Text = "딸기";
            chb4.Text = "바나나";
            chb5.Text = "다 별로";

            boxList.Add(chb1);
            boxList.Add(chb2);
            boxList.Add(chb3);
            boxList.Add(chb4);
            boxList.Add(chb5);

            bestFruitArray = new string[boxList.Count];
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int checkCount = 0;
            string checkState = "";

            foreach (CheckBox box in boxList)
            {
                checkState += $"{box.Text} : {box.Checked}\n";

                if (box.Checked)
                {
                    bestFruitArray[checkCount] = box.Text;
                    checkCount++;
                }
            }

            if (checkCount == 0)
            {
                MessageBox.Show("하나라도 체크를 해야합니다.");
                return;
            }

            DialogResult result = MessageBox.Show(checkState, "체크 상태", MessageBoxButtons.OK);

            if (result == DialogResult.OK)
            {
                string info = "가장 좋아하는 과일은 : ";
                string bestFruits = string.Join(" ", bestFruitArray);

                MessageBox.Show($"{info}{bestFruits}", "가장 좋아하는 과일");
            }

            // 배열 정리
            Array.Clear(bestFruitArray, 0, bestFruitArray.Length);
        }

        // 타이머
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (chb5.Checked)
            {
                chb1.Enabled = false;
                chb2.Enabled = false;
                chb3.Enabled = false;
                chb4.Enabled = false;
            }
            else
            {
                chb1.Enabled = true;
                chb2.Enabled = true;
                chb3.Enabled = true;
                chb4.Enabled = true;
            }
        }
    }
}
