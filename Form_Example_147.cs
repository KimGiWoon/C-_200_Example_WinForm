using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Timer 컨트롤을 이용한 디지털 시계
namespace C__200_Example_WinForm
{
    public partial class Form_Example_147 : Form
    {
        private int interval = 1000;

        public Form_Example_147()
        {
            InitializeComponent();
        }

        private void Form_Example_147_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            timer1.Interval = interval; // 1초 간격
            timer1.Tick += timer1_Tick; // 타이머 Tick 이벤트 연결
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(ClientSize.Width / 2 - label1.Width / 2, ClientSize.Height / 2 - label1.Height / 2);

            label1.Font = new Font("맑은 고딕", 30, FontStyle.Bold);
            label1.Text = DateTime.Now.ToString();
        }
    }
}
