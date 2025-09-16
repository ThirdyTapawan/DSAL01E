namespace Lesson1._2
{
    partial class Activity3_PrintFrm
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
            this.printDisplayListbox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // printDisplayListbox
            // 
            this.printDisplayListbox.FormattingEnabled = true;
            this.printDisplayListbox.ItemHeight = 16;
            this.printDisplayListbox.Location = new System.Drawing.Point(62, 86);
            this.printDisplayListbox.Name = "printDisplayListbox";
            this.printDisplayListbox.Size = new System.Drawing.Size(466, 468);
            this.printDisplayListbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(471, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "TAPAWAN Food Ordering Application";
            // 
            // Activity3_PrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 617);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.printDisplayListbox);
            this.Name = "Activity3_PrintFrm";
            this.Text = "Activity3_PrintFrm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox printDisplayListbox;
        private System.Windows.Forms.Label label1;
    }
}