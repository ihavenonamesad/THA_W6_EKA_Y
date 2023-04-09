namespace THA_W6_EKA_Y
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.txt_many = new System.Windows.Forms.TextBox();
            this.lbl_how = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Garamond", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(288, 75);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(192, 69);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "LE WORDE";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // txt_many
            // 
            this.txt_many.Location = new System.Drawing.Point(314, 184);
            this.txt_many.Name = "txt_many";
            this.txt_many.Size = new System.Drawing.Size(124, 20);
            this.txt_many.TabIndex = 1;
            this.txt_many.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_many_KeyPress);
            // 
            // lbl_how
            // 
            this.lbl_how.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_how.Location = new System.Drawing.Point(281, 124);
            this.lbl_how.Name = "lbl_how";
            this.lbl_how.Size = new System.Drawing.Size(199, 46);
            this.lbl_how.TabIndex = 2;
            this.lbl_how.Text = "Set How Many times You Can Guess!!";
            this.lbl_how.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_how.Click += new System.EventHandler(this.lbl_how_Click);
            // 
            // btn_start
            // 
            this.btn_start.Font = new System.Drawing.Font("Garamond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(327, 228);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(98, 27);
            this.btn_start.TabIndex = 3;
            this.btn_start.Text = "START!!!";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.lbl_how);
            this.Controls.Add(this.txt_many);
            this.Controls.Add(this.lbl_title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txt_many;
        private System.Windows.Forms.Label lbl_how;
        private System.Windows.Forms.Button btn_start;
    }
}

