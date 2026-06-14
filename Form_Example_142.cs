using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CheckedListBox를 이용한 희망 여행지 리스트
namespace C__200_Example_WinForm
{
    public partial class Form_Example_142 : Form
    {
        public Form_Example_142()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            listBox1.SelectionMode = SelectionMode.MultiExtended;
        }

        private void Form_Example_142_Load(object sender, EventArgs e)
        {
            checkedListBox1.Items.Add("오스트리아, 빈");
            checkedListBox1.Items.Add("호주, 멜버른");
            checkedListBox1.Items.Add("일본, 오사카");
            checkedListBox1.Items.Add("캐나다, 캘거리");
            checkedListBox1.Items.Add("호주, 시드니");
            checkedListBox1.Items.Add("캐나다, 밴쿠버");
            checkedListBox1.Items.Add("일본, 도쿄");
            checkedListBox1.Items.Add("캐나다, 토론토");
            checkedListBox1.Items.Add("덴마크, 코펜하겐");
            checkedListBox1.Items.Add("호주, 애들레이드");
        }

        // 오른쪽으로 이동
        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            foreach(var checkItem in checkedListBox1.CheckedItems)
            {
                listBox1.Items.Add(checkItem);
            }
        }

        // 전부 오른쪽으로 이동
        private void btnMoveAllRight_Click(object sender, EventArgs e)
        {
            foreach (var item in checkedListBox1.Items)
            {
                listBox1.Items.Add(item);
            }
        }

        // 뒤로가기
        private void btnBack_Click(object sender, EventArgs e)
        {
            List<string> removeItemsList = new List<string>();

            foreach (string item in listBox1.SelectedItems)
            {
                removeItemsList.Add(item);
            }

            foreach (string item in removeItemsList)
            {
                listBox1.Items.Remove(item);
            }

            // foreach로 SelectedItems를 순회하면서 직접 삭제할 수 없으므로 삭제할 항목을 별도 리스트에 저장한 후 삭제 필요
            //foreach(var item in listBox1.SelectedItems)
            //{
            //    listBox1.Items.Remove(item);
            //}
        }

        // 전체 삭제
        private void btnAllDelete_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
