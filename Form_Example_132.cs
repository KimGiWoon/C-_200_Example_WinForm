using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 레이블에서 여러 줄의 문자열 표시
namespace C__200_Example_WinForm
{
    public partial class Form_Example_132 : Form
    {
        public Form_Example_132()
        {
            InitializeComponent();
            lblTitle.Text = "";
            lblExplain.Text = "";
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            string title = "라파엘로 산치오, 이탈리아, 르네상스 3대 거장, 1483~1520";
            string explain = "라파엘로(Raphael, Raffaello Sanzio da Urbino)는 " +
                "동시대의 대가인 미켈란젤로, 레오나드로 다빈치와 함꼐 르네상스 3대 거장으로 " +
                "알려져 있습니다. 가장 유명한 작품은 <아테네 학당(The School of Athens> 으로 " +
                "바티칸궁(Apostolic Palace)에 있는 프레스코 벽화 입니다\n";

            lblTitle.Text = title;
            lblExplain.Text = explain;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
