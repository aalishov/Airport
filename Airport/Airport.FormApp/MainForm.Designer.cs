namespace Airport.FormApp
{
    partial class MainForm
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
            this.btnPilotForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPilotForm
            // 
            this.btnPilotForm.Location = new System.Drawing.Point(42, 39);
            this.btnPilotForm.Name = "btnPilotForm";
            this.btnPilotForm.Size = new System.Drawing.Size(163, 100);
            this.btnPilotForm.TabIndex = 0;
            this.btnPilotForm.Text = "button1";
            this.btnPilotForm.UseVisualStyleBackColor = true;
            this.btnPilotForm.Click += new System.EventHandler(this.btnPilotForm_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPilotForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPilotForm;
    }
}
