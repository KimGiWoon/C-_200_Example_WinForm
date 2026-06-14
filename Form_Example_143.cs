using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// 콤보박스를 이용한 학점계산기
namespace C__200_Example_WinForm
{
    public partial class Form_Example_143 : Form
    {
        List<Label> titles = new List<Label>();
        List<ComboBox> units = new List<ComboBox>();
        List<ComboBox> records = new List<ComboBox>();

        public Form_Example_143()
        {
            InitializeComponent();

            TablePanelInit();
        }

        private void TablePanelInit()
        {
            // 과목명
            Label lblSubjectName1 = CreateLabel("lblSubName1", "인체의구조와기능I");
            Label lblSubjectName2 = CreateLabel("lblSubName2", "일반수학I");
            Label lblSubjectName3 = CreateLabel("lblSubName3", "디지털공학및실험");
            Label lblSubjectName4 = CreateLabel("lblSubName4", "자료구조");
            Label lblSubjectName5 = CreateLabel("lblSubName5", "비주얼프로그래밍");
            Label lblSubjectName6 = CreateLabel("lblSubName6", "기업가정신");
            Label lblSubjectName7 = CreateLabel("lblSubName7", "도덕");

            // 학점
            ComboBox cmbUnit1 = CreateComboBox("cmbUnit1", "", true);
            ComboBox cmbUnit2 = CreateComboBox("cmbUnit2", "", true);
            ComboBox cmbUnit3 = CreateComboBox("cmbUnit3", "", true);
            ComboBox cmbUnit4 = CreateComboBox("cmbUnit4", "", true);
            ComboBox cmbUnit5 = CreateComboBox("cmbUnit5", "", true);
            ComboBox cmbUnit6 = CreateComboBox("cmbUnit6", "", true);
            ComboBox cmbUnit7 = CreateComboBox("cmbUnit7", "", true);

            // 성적
            ComboBox cmbRecord1 = CreateComboBox("cmbRecord1", "", false);
            ComboBox cmbRecord2 = CreateComboBox("cmbRecord2", "", false);
            ComboBox cmbRecord3 = CreateComboBox("cmbRecord3", "", false);
            ComboBox cmbRecord4 = CreateComboBox("cmbRecord4", "", false);
            ComboBox cmbRecord5 = CreateComboBox("cmbRecord5", "", false);
            ComboBox cmbRecord6 = CreateComboBox("cmbRecord6", "", false);
            ComboBox cmbRecord7 = CreateComboBox("cmbRecord7", "", false);

            tableLayoutPanel1.Controls.Add(lblSubjectName1, 0, 0);
            tableLayoutPanel1.Controls.Add(lblSubjectName2, 0, 1);
            tableLayoutPanel1.Controls.Add(lblSubjectName3, 0, 2);
            tableLayoutPanel1.Controls.Add(lblSubjectName4, 0, 3);
            tableLayoutPanel1.Controls.Add(lblSubjectName5, 0, 4);
            tableLayoutPanel1.Controls.Add(lblSubjectName6, 0, 5);
            tableLayoutPanel1.Controls.Add(lblSubjectName7, 0, 6);
            tableLayoutPanel1.Controls.Add(cmbUnit1, 1, 0);
            tableLayoutPanel1.Controls.Add(cmbUnit2, 1, 1);
            tableLayoutPanel1.Controls.Add(cmbUnit3, 1, 2);
            tableLayoutPanel1.Controls.Add(cmbUnit4, 1, 3);
            tableLayoutPanel1.Controls.Add(cmbUnit5, 1, 4);
            tableLayoutPanel1.Controls.Add(cmbUnit6, 1, 5);
            tableLayoutPanel1.Controls.Add(cmbUnit7, 1, 6);
            tableLayoutPanel1.Controls.Add(cmbRecord1, 2, 0);
            tableLayoutPanel1.Controls.Add(cmbRecord2, 2, 1);
            tableLayoutPanel1.Controls.Add(cmbRecord3, 2, 2);
            tableLayoutPanel1.Controls.Add(cmbRecord4, 2, 3);
            tableLayoutPanel1.Controls.Add(cmbRecord5, 2, 4);
            tableLayoutPanel1.Controls.Add(cmbRecord6, 2, 5);
            tableLayoutPanel1.Controls.Add(cmbRecord7, 2, 6);
        }

        private ComboBox CreateComboBox(string name, string text, bool isScore)
        {
            ComboBox comboBox = new ComboBox();
            comboBox.Name = name;
            comboBox.Text = text;
            comboBox.Dock = DockStyle.Fill;

            if (isScore == true)
            {
                comboBox.Items.Add("1");
                comboBox.Items.Add("2");
                comboBox.Items.Add("3");
                comboBox.Items.Add("4");
                comboBox.Items.Add("5");
                comboBox.SelectedItem = 3;

                units.Add(comboBox);
            }
            else
            {
                comboBox.Items.Add("A+");
                comboBox.Items.Add("A");
                comboBox.Items.Add("B+");
                comboBox.Items.Add("B");
                comboBox.Items.Add("C+");
                comboBox.Items.Add("C");
                comboBox.Items.Add("D+");
                comboBox.Items.Add("D");
                comboBox.Items.Add("F");
                comboBox.SelectedItem = 3;

                records.Add(comboBox);
            }

            return comboBox;
        }

        private Label CreateLabel(string name, string text)
        {
            Label label = new Label();
            label.Name = name;
            label.Text = text;
            label.AutoSize = false;
            label.Dock = DockStyle.Fill;

            titles.Add(label);

            return label;
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalUnit = 0;

            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                if (titles[i].Text != "")
                {
                    int unit = int.Parse(units[i].SelectedItem.ToString());
                    totalUnit += unit;
                    totalScore += unit * GetGrade(records[i].SelectedItem.ToString());
                }
            }

            lblAverage.Text = (totalScore / totalUnit).ToString("0.00");
        }

        private double GetGrade(string text)
        {
            double grade = 0;

            switch (text)
            {
                case "A+":
                    grade = 4.5;    break;
                case "A":
                    grade = 4.0; break;
                case "B+":
                    grade = 3.5; break;
                case "B":
                    grade = 3.0; break;
                case "C+":
                    grade = 2.5; break;
                case "C":
                    grade = 2.0; break;
                case "D+":
                    grade = 1.5; break;
                case "D":
                    grade = 1.0; break;
                default:
                    grade = 0;  break;
            }

            return grade;
        }
    }
}
