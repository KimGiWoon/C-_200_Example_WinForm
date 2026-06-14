namespace C__200_Example_WinForm
{
    partial class Form_Example_142
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveAllRight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAllDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(29, 51);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(213, 290);
            this.checkedListBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(381, 51);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 225);
            this.listBox1.TabIndex = 1;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(265, 123);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(88, 29);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // btnMoveAllRight
            // 
            this.btnMoveAllRight.Location = new System.Drawing.Point(265, 158);
            this.btnMoveAllRight.Name = "btnMoveAllRight";
            this.btnMoveAllRight.Size = new System.Drawing.Size(88, 29);
            this.btnMoveAllRight.TabIndex = 3;
            this.btnMoveAllRight.Text = ">>";
            this.btnMoveAllRight.UseVisualStyleBackColor = true;
            this.btnMoveAllRight.Click += new System.EventHandler(this.btnMoveAllRight_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(265, 218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 29);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAllDelete
            // 
            this.btnAllDelete.Location = new System.Drawing.Point(474, 300);
            this.btnAllDelete.Name = "btnAllDelete";
            this.btnAllDelete.Size = new System.Drawing.Size(108, 29);
            this.btnAllDelete.TabIndex = 5;
            this.btnAllDelete.Text = "모두 삭제";
            this.btnAllDelete.UseVisualStyleBackColor = true;
            this.btnAllDelete.Click += new System.EventHandler(this.btnAllDelete_Click);
            // 
            // Form_Example_142
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 369);
            this.Controls.Add(this.btnAllDelete);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMoveAllRight);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form_Example_142";
            this.Text = "Form_Example_142";
            this.Load += new System.EventHandler(this.Form_Example_142_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveAllRight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAllDelete;
    }
}