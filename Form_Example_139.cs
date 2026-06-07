using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 스크롤바로 RGB 컬러 조정
namespace C__200_Example_WinForm
{
    public partial class Form_Example_139 : Form
    {
        public Form_Example_139()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0, 0, 0); // RGB컬러
            txtR.Text = 0.ToString();
            txtG.Text = 0.ToString();
            txtB.Text = 0.ToString();

            scrR.Maximum = 255 + 9; // LargeChange의 값인 10을 고려하여 실제 최대값 255가 나오도록 설정 (최대값 : Maximum - LargeChange + 1)
            scrG.Maximum = 255 + 9;
            scrB.Maximum = 255 + 9;

            this.CenterToScreen();
        }

        // 스크롤 변화
        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            txtR.Text = scrR.Value.ToString();
            txtG.Text = scrG.Value.ToString();
            txtB.Text = scrB.Value.ToString();
            panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
        }

        // Text Box 변화
        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtR.Text != "" && txtG.Text != "" && txtB.Text != "")
            {
                scrR.Value = int.Parse(txtR.Text);
                scrG.Value = int.Parse(txtG.Text);
                scrB.Value = int.Parse(txtB.Text);
                panel1.BackColor = Color.FromArgb(scrR.Value, scrG.Value, scrB.Value);
            }
        }
    }
}
