namespace picture_box_demo
{
    partial class Form1
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
            this.pbx1 = new System.Windows.Forms.PictureBox();
            this.pbx2 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx1
            // 
            this.pbx1.BackColor = System.Drawing.Color.Black;
            this.pbx1.Location = new System.Drawing.Point(16, 22);
            this.pbx1.Name = "pbx1";
            this.pbx1.Size = new System.Drawing.Size(75, 75);
            this.pbx1.TabIndex = 0;
            this.pbx1.TabStop = false;
            // 
            // pbx2
            // 
            this.pbx2.BackColor = System.Drawing.Color.Black;
            this.pbx2.Location = new System.Drawing.Point(136, 22);
            this.pbx2.Name = "pbx2";
            this.pbx2.Size = new System.Drawing.Size(75, 75);
            this.pbx2.TabIndex = 1;
            this.pbx2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 129);
            this.Controls.Add(this.pbx2);
            this.Controls.Add(this.pbx1);
            this.Name = "Form1";
            this.Text = "Blinker";
            ((System.ComponentModel.ISupportInitialize)(this.pbx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx1;
        private System.Windows.Forms.PictureBox pbx2;
        private System.Windows.Forms.Timer timer1;
    }
}

