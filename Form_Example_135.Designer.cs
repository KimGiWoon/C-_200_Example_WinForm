namespace C__200_Example_WinForm
{
    partial class Form_Example_135
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
            this.grpNationality = new System.Windows.Forms.GroupBox();
            this.grpGender = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // grpNationality
            // 
            this.grpNationality.Location = new System.Drawing.Point(36, 37);
            this.grpNationality.Name = "grpNationality";
            this.grpNationality.Size = new System.Drawing.Size(156, 155);
            this.grpNationality.TabIndex = 1;
            this.grpNationality.TabStop = false;
            this.grpNationality.Text = "국적";
            // 
            // grpGender
            // 
            this.grpGender.Location = new System.Drawing.Point(224, 37);
            this.grpGender.Name = "grpGender";
            this.grpGender.Size = new System.Drawing.Size(156, 96);
            this.grpGender.TabIndex = 2;
            this.grpGender.TabStop = false;
            this.grpGender.Text = "성별";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(308, 242);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(93, 45);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "확인";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // Form_Example_135
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 299);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.grpGender);
            this.Controls.Add(this.grpNationality);
            this.Name = "Form_Example_135";
            this.Text = "Form_Example_135";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpNationality;
        private System.Windows.Forms.GroupBox grpGender;
        private System.Windows.Forms.Button btnConfirm;
    }
}