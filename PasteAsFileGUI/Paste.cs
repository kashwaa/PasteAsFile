using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace PasteAsFileGUI
{
    public partial class Paste : Form
    {
        // directory holds the current direcoty where the file will be saved
        public string directory { get; set; }

        public FileType fileType { get; set; }
        public Paste(string directory,FileType fileType)
        {
            InitializeComponent();
            // add / to directory name if it doesn't already end in one
            this.directory = directory.Last()=='\\'?directory:directory+"\\";
            this.fileType = fileType;
        }

        private void Paste_Load(object sender, EventArgs e)
        {
            // place the current dir in status bar
            lbl_location.Text = directory;
            
            if (fileType==FileType.Txt)
            {
                // get list of text files extensions
                BindFileTypesAsTxt();
            }
            else if (fileType == FileType.Image)
            {
                // get list of image files extensions
                BindFileTypesAsImage();
            }

            //get the default file name
            txt_fileName.Text = GenerateFileName("default");
        }

        /// <summary>
        /// Saves the clipboard content in a file on the current directory
        /// </summary>
        void Save()
        {
            //make sure the content type wasn't changed during execution
            if (fileType == FileType.Txt && Clipboard.ContainsText())
            {
                string text = Clipboard.GetText();
                File.WriteAllText(directory + txt_fileName.Text + "." + cmb_fileType.SelectedItem, text);
            }
            else if (fileType == FileType.Image && Clipboard.ContainsImage())
            {
                Image image = Clipboard.GetImage();
                //get suitable image extension for the chosen format
                image.Save(directory + txt_fileName.Text + "." + cmb_fileType.SelectedItem, GetImageFormatFromExtension(cmb_fileType.SelectedItem.ToString()));
            }
            else //content type changed!!
            {
                MessageBox.Show("Wrong data type in Clipboard");
                Environment.Exit(3);
            }
            //clear clipboard if the user chose to
            if (chk_empty.Checked)
            {
                Clipboard.Clear();
            }
        }
        /// <summary>
        /// get a list of text files extensions and bind it to the extension combobox
        /// </summary>
        void BindFileTypesAsTxt()
        { 
        cmb_fileType.DataSource=new string[]{"txt","html"};
        }
        /// <summary>
        /// get a list of image files extensions and bind it to the extension combobox
        /// </summary>
        void BindFileTypesAsImage()
        {
            cmb_fileType.DataSource = new string[] { "bmp", "jpg","gif","tif","png" };
        }
        /// <summary>
        /// get the suitable image format for a given file extension
        /// </summary>
        /// <param name="extension">String</param>
        /// <returns>ImageFormat</returns>
        ImageFormat GetImageFormatFromExtension(string extension)
        {
            switch (extension)
            {
                case "bmp":
                    return ImageFormat.Bmp;
                case "jpg":
                    return ImageFormat.Jpeg;
                case "gif":
                    return ImageFormat.Gif;
                case "tif":
                    return ImageFormat.Tiff;
                case "png":
                    return ImageFormat.Png;
                default:
                    return null;
            }
        }
        /// <summary>
        /// checks for the consistency of a given filename
        /// </summary>
        /// <returns>True if file name suitable, False otherwise</returns>
         bool CheckFileName()
        {
            if (txt_fileName.Text.Length<1)
            {
                return false;
            }
            string[] banned = { "<",">",":","\"","/","\\","|","?","*" };
            foreach (var letter in banned)
            {
                if (txt_fileName.Text.Contains(letter))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// generates a unique file name in a given path
        /// </summary>
        /// <param name="initialName">Default file name</param>
        /// <returns>unique filename</returns>
         string GenerateFileName(string initialName)
         {
             string name=initialName;
             int i=0;
             while (File.Exists(directory + name + "." + cmb_fileType.SelectedItem))
             {
                 name = initialName + (++i);
             }
             return name;
         }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!CheckFileName())
            {
                MessageBox.Show("Illegal filename");
                return;
            }
            Save();
            Environment.Exit(0);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
