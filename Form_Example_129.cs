using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Form클래스와 두 개의 폼 띄우기
namespace C__200_Example_WinForm
{
    public partial class Form_Example_129 : Form
    {
        public Form_Example_129()
        {
            Form_Example_127 form2 = new Form_Example_127();

            InitializeComponent();

            Init();
            Form_Example_127_Open(form2);
        }

        // 초기화
        private void Init()
        {
            this.Text = "Test"; // 타이틀바에 표시되는 텍스트 변경
            this.ClientSize = new Size(800, 800);   // 클라이언트 창 사이즈 변경
            this.StartPosition = FormStartPosition.CenterScreen;    // 스크린 중앙 위치 설정
            //CenterToScreen();   // 이렇게 스크린 중앙 위치 설정도 가능

            this.FormBorderStyle = FormBorderStyle.Fixed3D; // 폼의 테두리 모양 변경

        }

        private void Form_Example_127_Open(Form_Example_127 form2)
        {
            this.AddOwnedForm(form2);    // form2를 현재의 폼에 추가
            form2.Show(); // 여러 창을 동시에 사용가능
            //form2.ShowDialog(); // form2를 모달 다이얼로그 박스로 보여줌 (form2를 닫기 전에는 다른폼을 조작할 수 없음)

            form2.Activate();   // form2를 활성화하여 입력 포커스를 줌
        }
    }
}
