namespace Setup
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
            this.txt_location = new System.Windows.Forms.TextBox();
            this.lbl_location = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btn_changedir = new System.Windows.Forms.Button();
            this.btn_setup = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_location
            // 
            this.txt_location.Location = new System.Drawing.Point(104, 25);
            this.txt_location.Name = "txt_location";
            this.txt_location.Size = new System.Drawing.Size(454, 20);
            this.txt_location.TabIndex = 0;
            // 
            // lbl_location
            // 
            this.lbl_location.AutoSize = true;
            this.lbl_location.Location = new System.Drawing.Point(23, 28);
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(75, 13);
            this.lbl_location.TabIndex = 1;
            this.lbl_location.Text = "Setup location";
            // 
            // btn_changedir
            // 
            this.btn_changedir.Location = new System.Drawing.Point(564, 23);
            this.btn_changedir.Name = "btn_changedir";
            this.btn_changedir.Size = new System.Drawing.Size(75, 23);
            this.btn_changedir.TabIndex = 2;
            this.btn_changedir.Text = "Change";
            this.btn_changedir.UseVisualStyleBackColor = true;
            this.btn_changedir.Click += new System.EventHandler(this.btn_changedir_Click);
            // 
            // btn_setup
            // 
            this.btn_setup.Location = new System.Drawing.Point(183, 91);
            this.btn_setup.Name = "btn_setup";
            this.btn_setup.Size = new System.Drawing.Size(75, 23);
            this.btn_setup.TabIndex = 3;
            this.btn_setup.Text = "Setup";
            this.btn_setup.UseVisualStyleBackColor = true;
            this.btn_setup.Click += new System.EventHandler(this.btn_setup_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(345, 91);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 153);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_setup);
            this.Controls.Add(this.btn_changedir);
            this.Controls.Add(this.lbl_location);
            this.Controls.Add(this.txt_location);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Setup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_location;
        private System.Windows.Forms.Label lbl_location;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btn_changedir;
        private System.Windows.Forms.Button btn_setup;
        private System.Windows.Forms.Button btn_cancel;
    }
}

