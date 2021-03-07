namespace ShoppingListPejsar
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
            this.labelHotovo = new System.Windows.Forms.Label();
            this.labelCoKoupit = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHotovo
            // 
            this.labelHotovo.AutoSize = true;
            this.labelHotovo.Location = new System.Drawing.Point(470, 90);
            this.labelHotovo.Name = "labelHotovo";
            this.labelHotovo.Size = new System.Drawing.Size(40, 13);
            this.labelHotovo.TabIndex = 3;
            this.labelHotovo.Text = "hotovo";
            // 
            // labelCoKoupit
            // 
            this.labelCoKoupit.AutoSize = true;
            this.labelCoKoupit.Location = new System.Drawing.Point(110, 90);
            this.labelCoKoupit.Name = "labelCoKoupit";
            this.labelCoKoupit.Size = new System.Drawing.Size(50, 13);
            this.labelCoKoupit.TabIndex = 4;
            this.labelCoKoupit.Text = "CoKoupit";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 170);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(22, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelCoKoupit);
            this.Controls.Add(this.labelHotovo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelHotovo;
        private System.Windows.Forms.Label labelCoKoupit;
        private System.Windows.Forms.Button btnAdd;
    }
}

