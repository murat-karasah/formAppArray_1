
namespace formAppArray_1
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
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.listbx1 = new System.Windows.Forms.ListBox();
            this.btn_Pull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Location = new System.Drawing.Point(11, 41);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(121, 21);
            this.cmb1.TabIndex = 1;
            // 
            // listbx1
            // 
            this.listbx1.FormattingEnabled = true;
            this.listbx1.Location = new System.Drawing.Point(11, 68);
            this.listbx1.Name = "listbx1";
            this.listbx1.Size = new System.Drawing.Size(120, 95);
            this.listbx1.TabIndex = 2;
            // 
            // btn_Pull
            // 
            this.btn_Pull.Location = new System.Drawing.Point(12, 12);
            this.btn_Pull.Name = "btn_Pull";
            this.btn_Pull.Size = new System.Drawing.Size(75, 23);
            this.btn_Pull.TabIndex = 3;
            this.btn_Pull.Text = "Getir";
            this.btn_Pull.UseVisualStyleBackColor = true;
            this.btn_Pull.Click += new System.EventHandler(this.btn_Pull_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(147, 498);
            this.Controls.Add(this.btn_Pull);
            this.Controls.Add(this.listbx1);
            this.Controls.Add(this.cmb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.ListBox listbx1;
        private System.Windows.Forms.Button btn_Pull;
    }
}

