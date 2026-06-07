using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 리스트박스에 항목을 표시하는 세가지 방법
namespace C__200_Example_WinForm
{
    public partial class Form_Example_140 : Form
    {
        private List<string> gdpList = new List<string> { "미국", "러시아", "중국", "영국", "독일", "프랑스", "일본", "이스라엘", "사우디아라비아", "UAE" };
        private List<string> goodLiveList = new List<string> { "오스트리아", "빈" };
        private List<string> happyList = new List<string> { "호주", "애들레이드" };

        public Form_Example_140()
        {
            InitializeComponent();
        }

        private void Form_Example_140_Load(object sender, EventArgs e)
        {
            lstGDP.DataSource = gdpList;
            lstGoodLive.DataSource = goodLiveList;
            lstHappy.DataSource = happyList;

            // Items.Add로 추가 가능
            //lstGDP.Items.Add("미국, 러시아, 중국, 영국, 독일, 프랑스, 일본, 이스라엘, 사우디아라비아, UAE");
            //lstGoodLive.Items.Add("오스트리아, 빈");
            //lstHappy.Items.Add("호주, 애들레이드");
        }

        private void lstGDP_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;  // 이벤트가 리스트 박스에만 연결되어 있으므로 강제 형변환
            // ListBox lst = sender as ListBox; // sender가 리스트 박스가 아닐 시 Null을 반환하는 방법도 사용가능


            txtGDPIndex.Text = (lst.SelectedIndex + 1).ToString() + "순위";
            txtGDPItem.Text = lst.SelectedItem.ToString();
        }

        private void lstGoodLive_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;

            txtGoodLiveIndex.Text = (lst.SelectedIndex + 1).ToString() + "순위";
            txtGoodLiveItem.Text = lst.SelectedItem.ToString();
        }

        private void lstHappy_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lst = (ListBox)sender;

            txtHappyIndex.Text = (lst.SelectedIndex + 1).ToString() + "순위";
            txtHappyItem.Text = lst.SelectedItem.ToString();
        }
    }
}
