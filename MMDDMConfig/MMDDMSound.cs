using System;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void soundlist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView target = (ListView)sender;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "音楽ファイル(*.mp3;*.wav)|*.mp3;*.wav";
                ofd.Title = "ファイルを選択してください";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    common.SoundFile(target.SelectedItems[0].Index, ofd.FileName);
                    if (target.SelectedItems[0].SubItems.Count == 2)
                    {
                        target.SelectedItems[0].SubItems[1].Text = Path.GetFileName(ofd.FileName);
                    }
                    else
                    {
                        target.SelectedItems[0].SubItems.Add(Path.GetFileName(ofd.FileName));
                    }
                }
            }
        }
    }
}