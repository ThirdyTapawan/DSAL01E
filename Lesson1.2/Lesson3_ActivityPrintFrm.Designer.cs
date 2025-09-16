namespace Lesson1._2
{
    partial class Lesson3_ActivityPrintFrm
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
            this.Enrollment_Reciept = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Enrollment_Reciept
            // 
            this.Enrollment_Reciept.FormattingEnabled = true;
            this.Enrollment_Reciept.ItemHeight = 16;
            this.Enrollment_Reciept.Location = new System.Drawing.Point(13, 13);
            this.Enrollment_Reciept.Name = "Enrollment_Reciept";
            this.Enrollment_Reciept.Size = new System.Drawing.Size(1048, 756);
            this.Enrollment_Reciept.TabIndex = 0;
            // 
            // Lesson3_ActivityPrintFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 795);
            this.Controls.Add(this.Enrollment_Reciept);
            this.Name = "Lesson3_ActivityPrintFrm";
            this.Text = "Lesson3_ActivityPrintFrm";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox Enrollment_Reciept;
    }
}