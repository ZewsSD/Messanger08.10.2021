namespace DZOOP19
{
    partial class FormServer
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
            this.buttonCreareForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreareForm
            // 
            this.buttonCreareForm.Location = new System.Drawing.Point(358, 205);
            this.buttonCreareForm.Name = "buttonCreareForm";
            this.buttonCreareForm.Size = new System.Drawing.Size(85, 40);
            this.buttonCreareForm.TabIndex = 4;
            this.buttonCreareForm.Text = "Добавить форму";
            this.buttonCreareForm.UseVisualStyleBackColor = true;
            this.buttonCreareForm.Click += new System.EventHandler(this.buttonCreareForm_Click);
            // 
            // FormMessangercs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreareForm);
            this.Name = "FormMessangercs";
            this.Text = "FormMessangercs";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreareForm;
    }
}