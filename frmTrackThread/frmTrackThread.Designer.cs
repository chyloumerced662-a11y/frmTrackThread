namespace ThreadPriority
{
    partial class FrmThreadTrack
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRun = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.BackColor = Color.Silver;
            btnRun.Location = new Point(162, 137);
            btnRun.Margin = new Padding(3, 2, 3, 2);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(105, 38);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = false;
            btnRun.Click += btnRun_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 24F);
            label1.Location = new Point(65, 49);
            label1.Name = "label1";
            label1.Size = new Size(329, 42);
            label1.TabIndex = 1;
            label1.Text = "-Thread Starts -";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmThreadTrack
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(442, 204);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmThreadTrack";
            Text = "frmTrackThread";
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label1;
    }
}