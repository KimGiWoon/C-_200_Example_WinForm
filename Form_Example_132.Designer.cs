namespace C__200_Example_WinForm
{
    partial class Form_Example_132
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblExplain = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(28, 38);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(153, 29);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "라파엘로, 아테네 학당";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTitle.Location = new System.Drawing.Point(26, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(462, 36);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblExplain
            // 
            this.lblExplain.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblExplain.Location = new System.Drawing.Point(26, 115);
            this.lblExplain.Name = "lblExplain";
            this.lblExplain.Size = new System.Drawing.Size(462, 201);
            this.lblExplain.TabIndex = 2;
            this.lblExplain.Text = "label1";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(422, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 29);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "나가기";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form_Example_132
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 372);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblExplain);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnClick);
            this.Name = "Form_Example_132";
            this.Text = "Form_Example_132";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblExplain;
        private System.Windows.Forms.Button btnClose;
    }
}