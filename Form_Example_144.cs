using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 리스트뷰를 이용한 상품 리스트
namespace C__200_Example_WinForm
{
    public partial class Form_Example_144 : Form
    {
        public Form_Example_144()
        {
            InitializeComponent();
        }

        private void Form_Example_144_Load(object sender, EventArgs e)
        {
            lvMain.GridLines = true;
            lvMain.FullRowSelect = true;

            lvMain.Columns.Add("제품명", 150);
            lvMain.Columns.Add("단가", 100, HorizontalAlignment.Right);
            lvMain.Columns.Add("수량", 70, HorizontalAlignment.Right);

            int remainWidth = lvMain.ClientSize.Width - 150 - 100 - 70 -5;
            lvMain.Columns.Add("금액", remainWidth, HorizontalAlignment.Right);

            ListViewItem item1 = new ListViewItem("Access", 0);
            ListViewItem item2 = new ListViewItem("Excel", 1);
            ListViewItem item3 = new ListViewItem("PowerPoint", 2);
            ListViewItem item4 = new ListViewItem("Word", 3);

            item1.SubItems.Add("22,000");
            item1.SubItems.Add("30");
            item1.SubItems.Add("660,000");

            item2.SubItems.Add("33,000");
            item2.SubItems.Add("50");
            item2.SubItems.Add("1,650,000");

            item3.SubItems.Add("11,000");
            item3.SubItems.Add("50");
            item3.SubItems.Add("550,000");

            item4.SubItems.Add("22,000");
            item4.SubItems.Add("30");
            item4.SubItems.Add("660,000");

            lvMain.Items.AddRange(new ListViewItem[] { item1, item2, item3, item4 });

            ImageList sImageList = new ImageList();
            ImageList lImageList = new ImageList();

            sImageList.ImageSize = new Size(24, 24);
            lImageList.ImageSize = new Size(64, 64);

            sImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/access.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/excel.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/ppt.png"));
            sImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/word.png"));

            lImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/access.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/excel.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/ppt.png"));
            lImageList.Images.Add(Bitmap.FromFile(@"C:/Users/rldns/OneDrive/바탕 화면/Image/word.png"));
        }

        private void rdoDetails_CheckedChanged(object sender, EventArgs e)
        {
            lvMain.View = View.Details;
        }

        private void rdoList_CheckedChanged(object sender, EventArgs e)
        {
            lvMain.View = View.List;
        }

        private void rdoSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            lvMain.View = View.SmallIcon;
        }

        private void rdoBigIcon_CheckedChanged(object sender, EventArgs e)
        {
            lvMain.View = View.LargeIcon;
        }

        private void lvMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblText.Text = "";

            ListView.SelectedListViewItemCollection selected = lvMain.SelectedItems;

            foreach(ListViewItem item in selected)
            {
                for (int i = 0; i < 4; i++)
                {
                    lblText.Text += $"{item.SubItems[i].Text}   \t";
                }
            }
        }
    }
}
