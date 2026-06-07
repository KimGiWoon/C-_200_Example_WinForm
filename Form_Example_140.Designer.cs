namespace C__200_Example_WinForm
{
    partial class Form_Example_140
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
            this.lstGDP = new System.Windows.Forms.ListBox();
            this.lstGoodLive = new System.Windows.Forms.ListBox();
            this.lstHappy = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGDPIndex = new System.Windows.Forms.TextBox();
            this.txtGoodLiveIndex = new System.Windows.Forms.TextBox();
            this.txtHappyIndex = new System.Windows.Forms.TextBox();
            this.txtGDPItem = new System.Windows.Forms.TextBox();
            this.txtGoodLiveItem = new System.Windows.Forms.TextBox();
            this.txtHappyItem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstGDP
            // 
            this.lstGDP.FormattingEnabled = true;
            this.lstGDP.ItemHeight = 12;
            this.lstGDP.Location = new System.Drawing.Point(108, 61);
            this.lstGDP.Name = "lstGDP";
            this.lstGDP.Size = new System.Drawing.Size(116, 124);
            this.lstGDP.TabIndex = 0;
            this.lstGDP.SelectedIndexChanged += new System.EventHandler(this.lstGDP_SelectedIndexChanged);
            // 
            // lstGoodLive
            // 
            this.lstGoodLive.FormattingEnabled = true;
            this.lstGoodLive.ItemHeight = 12;
            this.lstGoodLive.Location = new System.Drawing.Point(246, 61);
            this.lstGoodLive.Name = "lstGoodLive";
            this.lstGoodLive.Size = new System.Drawing.Size(116, 124);
            this.lstGoodLive.TabIndex = 1;
            this.lstGoodLive.SelectedIndexChanged += new System.EventHandler(this.lstGoodLive_SelectedIndexChanged);
            // 
            // lstHappy
            // 
            this.lstHappy.FormattingEnabled = true;
            this.lstHappy.ItemHeight = 12;
            this.lstHappy.Location = new System.Drawing.Point(384, 61);
            this.lstHappy.Name = "lstHappy";
            this.lstHappy.Size = new System.Drawing.Size(116, 124);
            this.lstHappy.TabIndex = 2;
            this.lstHappy.SelectedIndexChanged += new System.EventHandler(this.lstHappy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "GDP 순위";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "살기좋은 도시";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "행복한 나라";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ranking";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Country";
            // 
            // txtGDPIndex
            // 
            this.txtGDPIndex.Location = new System.Drawing.Point(108, 206);
            this.txtGDPIndex.Name = "txtGDPIndex";
            this.txtGDPIndex.Size = new System.Drawing.Size(110, 21);
            this.txtGDPIndex.TabIndex = 8;
            // 
            // txtGoodLiveIndex
            // 
            this.txtGoodLiveIndex.Location = new System.Drawing.Point(246, 206);
            this.txtGoodLiveIndex.Name = "txtGoodLiveIndex";
            this.txtGoodLiveIndex.Size = new System.Drawing.Size(110, 21);
            this.txtGoodLiveIndex.TabIndex = 9;
            // 
            // txtHappyIndex
            // 
            this.txtHappyIndex.Location = new System.Drawing.Point(384, 206);
            this.txtHappyIndex.Name = "txtHappyIndex";
            this.txtHappyIndex.Size = new System.Drawing.Size(110, 21);
            this.txtHappyIndex.TabIndex = 10;
            // 
            // txtGDPItem
            // 
            this.txtGDPItem.Location = new System.Drawing.Point(108, 237);
            this.txtGDPItem.Name = "txtGDPItem";
            this.txtGDPItem.Size = new System.Drawing.Size(110, 21);
            this.txtGDPItem.TabIndex = 11;
            // 
            // txtGoodLiveItem
            // 
            this.txtGoodLiveItem.Location = new System.Drawing.Point(246, 237);
            this.txtGoodLiveItem.Name = "txtGoodLiveItem";
            this.txtGoodLiveItem.Size = new System.Drawing.Size(110, 21);
            this.txtGoodLiveItem.TabIndex = 12;
            // 
            // txtHappyItem
            // 
            this.txtHappyItem.Location = new System.Drawing.Point(384, 237);
            this.txtHappyItem.Name = "txtHappyItem";
            this.txtHappyItem.Size = new System.Drawing.Size(110, 21);
            this.txtHappyItem.TabIndex = 13;
            // 
            // Form_Example_140
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 298);
            this.Controls.Add(this.txtHappyItem);
            this.Controls.Add(this.txtGoodLiveItem);
            this.Controls.Add(this.txtGDPItem);
            this.Controls.Add(this.txtHappyIndex);
            this.Controls.Add(this.txtGoodLiveIndex);
            this.Controls.Add(this.txtGDPIndex);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstHappy);
            this.Controls.Add(this.lstGoodLive);
            this.Controls.Add(this.lstGDP);
            this.Name = "Form_Example_140";
            this.Text = "Form_Example_140";
            this.Load += new System.EventHandler(this.Form_Example_140_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGDP;
        private System.Windows.Forms.ListBox lstGoodLive;
        private System.Windows.Forms.ListBox lstHappy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGDPIndex;
        private System.Windows.Forms.TextBox txtGoodLiveIndex;
        private System.Windows.Forms.TextBox txtHappyIndex;
        private System.Windows.Forms.TextBox txtGDPItem;
        private System.Windows.Forms.TextBox txtGoodLiveItem;
        private System.Windows.Forms.TextBox txtHappyItem;
    }
}