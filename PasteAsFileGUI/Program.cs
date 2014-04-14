using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasteAsFileGUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length<1)
            {
                Environment.Exit(1);
            }
            FileType fileType=FileType.None;
            if (Clipboard.ContainsText())
            {
                fileType = FileType.Txt;
            }
            else if (Clipboard.ContainsImage())
            {
                fileType = FileType.Image;
            }
            else
            {
                MessageBox.Show("Empty Clipboard");
                Environment.Exit(2);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //concat arguments, send them to paste form as one string -in case of a directory containing spaces-
            Application.Run(new Paste(string.Join(" ",args),fileType));
        }
        
    }
    public enum FileType
    { Image, Txt, None }
}
