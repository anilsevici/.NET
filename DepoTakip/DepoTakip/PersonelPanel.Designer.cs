namespace DepoTakip
{
    partial class PersonelPanel
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
            this.usSorgu1 = new DepoTakip.UsSorgu();
            this.SuspendLayout();
            // 
            // usSorgu1
            // 
            this.usSorgu1.Location = new System.Drawing.Point(12, 30);
            this.usSorgu1.Name = "usSorgu1";
            this.usSorgu1.Size = new System.Drawing.Size(1153, 537);
            this.usSorgu1.TabIndex = 0;
            // 
            // PersonelPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1197, 570);
            this.Controls.Add(this.usSorgu1);
            this.Name = "PersonelPanel";
            this.Text = "PersonelPanel";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PersonelPanel_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private UsSorgu usSorgu1;
    }
}