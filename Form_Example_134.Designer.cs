namespace C__200_Example_WinForm
{
    partial class Form_Example_134
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.chb1 = new System.Windows.Forms.CheckBox();
            this.chb2 = new System.Windows.Forms.CheckBox();
            this.chb3 = new System.Windows.Forms.CheckBox();
            this.chb4 = new System.Windows.Forms.CheckBox();
            this.chb5 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // chb1
            // 
            this.chb1.AutoSize = true;
            this.chb1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chb1.Location = new System.Drawing.Point(112, 99);
            this.chb1.Name = "chb1";
            this.chb1.Size = new System.Drawing.Size(107, 20);
            this.chb1.TabIndex = 0;
            this.chb1.Text = "checkBox1";
            this.chb1.UseVisualStyleBackColor = true;
            // 
            // chb2
            // 
            this.chb2.AutoSize = true;
            this.chb2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chb2.Location = new System.Drawing.Point(112, 125);
            this.chb2.Name = "chb2";
            this.chb2.Size = new System.Drawing.Size(107, 20);
            this.chb2.TabIndex = 1;
            this.chb2.Text = "checkBox2";
            this.chb2.UseVisualStyleBackColor = true;
            // 
            // chb3
            // 
            this.chb3.AutoSize = true;
            this.chb3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chb3.Location = new System.Drawing.Point(112, 151);
            this.chb3.Name = "chb3";
            this.chb3.Size = new System.Drawing.Size(107, 20);
            this.chb3.TabIndex = 2;
            this.chb3.Text = "checkBox3";
            this.chb3.UseVisualStyleBackColor = true;
            // 
            // chb4
            // 
            this.chb4.AutoSize = true;
            this.chb4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chb4.Location = new System.Drawing.Point(111, 177);
            this.chb4.Name = "chb4";
            this.chb4.Size = new System.Drawing.Size(108, 20);
            this.chb4.TabIndex = 3;
            this.chb4.Text = "checkBox4";
            this.chb4.UseVisualStyleBackColor = true;
            // 
            // chb5
            // 
            this.chb5.AutoSize = true;
            this.chb5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chb5.Location = new System.Drawing.Point(112, 203);
            this.chb5.Name = "chb5";
            this.chb5.Size = new System.Drawing.Size(107, 20);
            this.chb5.TabIndex = 4;
            this.chb5.Text = "checkBox5";
            this.chb5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Q : 당신이 가장 좋아하는 과일은?";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnConfirm.Location = new System.Drawing.Point(233, 285);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(88, 39);
            this.btnConfirm.TabIndex = 6;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form_Example_134
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 336);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chb5);
            this.Controls.Add(this.chb4);
            this.Controls.Add(this.chb3);
            this.Controls.Add(this.chb2);
            this.Controls.Add(this.chb1);
            this.Name = "Form_Example_134";
            this.Text = "Form_Example_134";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chb1;
        private System.Windows.Forms.CheckBox chb2;
        private System.Windows.Forms.CheckBox chb3;
        private System.Windows.Forms.CheckBox chb4;
        private System.Windows.Forms.CheckBox chb5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Timer timer1;
    }
}