using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Setup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txt_location.Text= Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)+"\\PasteAsFile";
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {

            try
            {
                if (!Directory.Exists(txt_location.Text))
                {
                    Directory.CreateDirectory(txt_location.Text);
                   
                }
                File.Copy(Environment.CurrentDirectory + "\\PasteAsFileGUI.exe", txt_location.Text + "\\PasteAsFileGUI.exe",true);
                var key = Microsoft.Win32.Registry.ClassesRoot.OpenSubKey("Directory\\Background\\shell", true);
                key.CreateSubKey("Paste as File").CreateSubKey("command").SetValue("", txt_location.Text + "\\PasteAsFileGUI.exe %V");
                MessageBox.Show("Installation successful!");
                Environment.Exit(0);
            }
            catch (Exception)
            {
                MessageBox.Show("Installation Failed, try again");
            }
        }

        private void btn_changedir_Click(object sender, EventArgs e)
        {
           var res= folderBrowserDialog1.ShowDialog();
           if (res==System.Windows.Forms.DialogResult.OK)
           {
               txt_location.Text = folderBrowserDialog1.SelectedPath;
           }
        }
    }
}
