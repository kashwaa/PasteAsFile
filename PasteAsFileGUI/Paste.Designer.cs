namespace PasteAsFileGUI
{
    partial class Paste
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_location = new System.Windows.Forms.ToolStripStatusLabel();
            this.txt_fileName = new System.Windows.Forms.TextBox();
            this.cmb_fileType = new System.Windows.Forms.ComboBox();
            this.chk_empty = new System.Windows.Forms.CheckBox();
            this.lbl_filename = new System.Windows.Forms.Label();
            this.lbl_filetype = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_location});
            this.statusStrip1.Location = new System.Drawing.Point(0, 181);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(291, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_location
            // 
            this.lbl_location.Name = "lbl_location";
            this.lbl_location.Size = new System.Drawing.Size(0, 17);
            // 
            // txt_fileName
            // 
            this.txt_fileName.Location = new System.Drawing.Point(82, 26);
            this.txt_fileName.Name = "txt_fileName";
            this.txt_fileName.Size = new System.Drawing.Size(180, 20);
            this.txt_fileName.TabIndex = 1;
            // 
            // cmb_fileType
            // 
            this.cmb_fileType.FormattingEnabled = true;
            this.cmb_fileType.Location = new System.Drawing.Point(82, 57);
            this.cmb_fileType.Name = "cmb_fileType";
            this.cmb_fileType.Size = new System.Drawing.Size(83, 21);
            this.cmb_fileType.TabIndex = 2;
            // 
            // chk_empty
            // 
            this.chk_empty.AutoSize = true;
            this.chk_empty.Location = new System.Drawing.Point(82, 96);
            this.chk_empty.Name = "chk_empty";
            this.chk_empty.Size = new System.Drawing.Size(159, 17);
            this.chk_empty.TabIndex = 3;
            this.chk_empty.Text = "Empty clipboard after saving";
            this.chk_empty.UseVisualStyleBackColor = true;
            // 
            // lbl_filename
            // 
            this.lbl_filename.AutoSize = true;
            this.lbl_filename.Location = new System.Drawing.Point(13, 32);
            this.lbl_filename.Name = "lbl_filename";
            this.lbl_filename.Size = new System.Drawing.Size(54, 13);
            this.lbl_filename.TabIndex = 4;
            this.lbl_filename.Text = "File Name";
            // 
            // lbl_filetype
            // 
            this.lbl_filetype.AutoSize = true;
            this.lbl_filetype.Location = new System.Drawing.Point(12, 65);
            this.lbl_filetype.Name = "lbl_filetype";
            this.lbl_filetype.Size = new System.Drawing.Size(50, 13);
            this.lbl_filetype.TabIndex = 5;
            this.lbl_filetype.Text = "File Type";
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(25, 141);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 6;
            this.btn_save.Text = "&Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(166, 141);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "&Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // Paste
            // 
            this.AcceptButton = this.btn_save;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(291, 203);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_filetype);
            this.Controls.Add(this.lbl_filename);
            this.Controls.Add(this.chk_empty);
            this.Controls.Add(this.cmb_fileType);
            this.Controls.Add(this.txt_fileName);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Paste";
            this.Text = "Paste";
            this.Load += new System.EventHandler(this.Paste_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_location;
        private System.Windows.Forms.TextBox txt_fileName;
        private System.Windows.Forms.ComboBox cmb_fileType;
        private System.Windows.Forms.CheckBox chk_empty;
        private System.Windows.Forms.Label lbl_filename;
        private System.Windows.Forms.Label lbl_filetype;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}