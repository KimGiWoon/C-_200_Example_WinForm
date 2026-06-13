using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__200_Example_WinForm
{
    public partial class Form_Example_141 : Form
    {
        public Form_Example_141()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            string[] arr = { "쿠우쿠우", "고메스퀘어", "화리화리" };

            foreach(string a in arr)
            {
                comboBox1.Items.Add(a);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                lblChoice.Text = $"{comboBox1.Text} 추가!";
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                lblChoice.Text = $"{comboBox1.SelectedItem.ToString()} 제거!";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
            else
            {
                lblChoice.Text = "제거할 항목이 없음";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            lblChoice.Text = $"이번 주 모임장소는 : {comboBox.SelectedItem.ToString()}";
        }
    }
}
