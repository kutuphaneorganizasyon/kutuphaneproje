
namespace yeniotomasyon
{
    partial class uyesil
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.İdtextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 79);
            this.button1.TabIndex = 0;
            this.button1.Text = "Üyeyi Sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "SİLİNECEK ÜYE ID\'SİNİ GİRİNİZ";
            // 
            // İdtextbox
            // 
            this.İdtextbox.Location = new System.Drawing.Point(398, 111);
            this.İdtextbox.Name = "İdtextbox";
            this.İdtextbox.Size = new System.Drawing.Size(100, 22);
            this.İdtextbox.TabIndex = 4;
            // 
            // uyesil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(861, 548);
            this.Controls.Add(this.İdtextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "uyesil";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox İdtextbox;
    }
}