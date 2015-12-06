using System;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void mmddmpathtext_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.All;
            else e.Effect = DragDropEffects.None;
        }

        private void mmddmpathtext_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(file[0]))
                {
                    mmddmpathtext.Text = Path.GetDirectoryName(file[0]);
                }
                else if (Directory.Exists(file[0]))
                {
                    mmddmpathtext.Text = Path.GetDirectoryName(file[0] + "\\");
                }
                common.Directory = mmddmpathtext.Text;
            }
        }

        private void mmddmpathbutton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "フォルダを指定してください";
                fbd.RootFolder = Environment.SpecialFolder.Desktop;
                fbd.SelectedPath = @"C:\";
                fbd.ShowNewFolderButton = false;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    mmddmpathtext.Text = fbd.SelectedPath;
                    common.Directory = mmddmpathtext.Text;
                }
            }
        }
    }
}