namespace C__200_Example_WinForm
{
    partial class Form_Example_144
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
            this.lvMain = new System.Windows.Forms.ListView();
            this.rdoDetails = new System.Windows.Forms.RadioButton();
            this.rdoList = new System.Windows.Forms.RadioButton();
            this.rdoSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdoBigIcon = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvMain
            // 
            this.lvMain.HideSelection = false;
            this.lvMain.Location = new System.Drawing.Point(25, 67);
            this.lvMain.Name = "lvMain";
            this.lvMain.Size = new System.Drawing.Size(456, 201);
            this.lvMain.TabIndex = 0;
            this.lvMain.UseCompatibleStateImageBehavior = false;
            this.lvMain.SelectedIndexChanged += new System.EventHandler(this.lvMain_SelectedIndexChanged);
            // 
            // rdoDetails
            // 
            this.rdoDetails.AutoSize = true;
            this.rdoDetails.Location = new System.Drawing.Point(61, 33);
            this.rdoDetails.Name = "rdoDetails";
            this.rdoDetails.Size = new System.Drawing.Size(59, 16);
            this.rdoDetails.TabIndex = 1;
            this.rdoDetails.TabStop = true;
            this.rdoDetails.Text = "자세히";
            this.rdoDetails.UseVisualStyleBackColor = true;
            this.rdoDetails.CheckedChanged += new System.EventHandler(this.rdoDetails_CheckedChanged);
            // 
            // rdoList
            // 
            this.rdoList.AutoSize = true;
            this.rdoList.Location = new System.Drawing.Point(159, 33);
            this.rdoList.Name = "rdoList";
            this.rdoList.Size = new System.Drawing.Size(59, 16);
            this.rdoList.TabIndex = 2;
            this.rdoList.TabStop = true;
            this.rdoList.Text = "리스트";
            this.rdoList.UseVisualStyleBackColor = true;
            this.rdoList.CheckedChanged += new System.EventHandler(this.rdoList_CheckedChanged);
            // 
            // rdoSmallIcon
            // 
            this.rdoSmallIcon.AutoSize = true;
            this.rdoSmallIcon.Location = new System.Drawing.Point(257, 33);
            this.rdoSmallIcon.Name = "rdoSmallIcon";
            this.rdoSmallIcon.Size = new System.Drawing.Size(87, 16);
            this.rdoSmallIcon.TabIndex = 3;
            this.rdoSmallIcon.TabStop = true;
            this.rdoSmallIcon.Text = "작은 아이콘";
            this.rdoSmallIcon.UseVisualStyleBackColor = true;
            this.rdoSmallIcon.CheckedChanged += new System.EventHandler(this.rdoSmallIcon_CheckedChanged);
            // 
            // rdoBigIcon
            // 
            this.rdoBigIcon.AutoSize = true;
            this.rdoBigIcon.Location = new System.Drawing.Point(371, 33);
            this.rdoBigIcon.Name = "rdoBigIcon";
            this.rdoBigIcon.Size = new System.Drawing.Size(75, 16);
            this.rdoBigIcon.TabIndex = 4;
            this.rdoBigIcon.TabStop = true;
            this.rdoBigIcon.Text = "큰 아이콘";
            this.rdoBigIcon.UseVisualStyleBackColor = true;
            this.rdoBigIcon.CheckedChanged += new System.EventHandler(this.rdoBigIcon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Selected";
            // 
            // lblText
            // 
            this.lblText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblText.Location = new System.Drawing.Point(302, 289);
            this.lblText.Name = "lblText";
            this.lblText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblText.Size = new System.Drawing.Size(179, 27);
            this.lblText.TabIndex = 6;
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Example_144
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 337);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rdoBigIcon);
            this.Controls.Add(this.rdoSmallIcon);
            this.Controls.Add(this.rdoList);
            this.Controls.Add(this.rdoDetails);
            this.Controls.Add(this.lvMain);
            this.Name = "Form_Example_144";
            this.Text = "Form_Example_144";
            this.Load += new System.EventHandler(this.Form_Example_144_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMain;
        private System.Windows.Forms.RadioButton rdoDetails;
        private System.Windows.Forms.RadioButton rdoList;
        private System.Windows.Forms.RadioButton rdoSmallIcon;
        private System.Windows.Forms.RadioButton rdoBigIcon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblText;
    }
}