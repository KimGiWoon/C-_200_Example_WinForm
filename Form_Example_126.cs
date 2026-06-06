using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 윈폼 템플릿 없이 윈폼 프로그램을 만드는 방법
namespace C__200_Example_WinForm
{
    public partial class Form_Example_126 : Form
    {
        public Form_Example_126()
        {
            InitializeComponent();
            CreateMyForm();
        }

        private void CreateMyForm()
        {
            Form form = new Form();

            Button button1 = new Button();
            Button button2 = new Button();

            button1.Text = "OK";
            button2.Text = "Cancel";

            button1.Location = new Point(10, 10);
            button2.Location = new Point(button1.Left, button1.Height + button1.Top + 10);

            form.Text = "My Dialog Box";

            button1.Click += Button1_Click;

            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.StartPosition = FormStartPosition.CenterScreen;

            form.Controls.Add(button1);
            form.Controls.Add(button2);

            form.ShowDialog();
        }

        // 버튼1 클릭
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK Button Click");
        }
    }
}
