using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void modellist_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView target = (ListView)sender;
            SuperListViewItem item = (SuperListViewItem)target.SelectedItems[0];
            int index = item.Index;
            ModelInfo mi = mil.MInfos[index];

            using (ModelConfig mc = new ModelConfig(mi.MPositionX, mi.MPositionY, mi.MPositionZ, mi.MRotationX, 
                mi.MRotationY, mi.MRotationZ, mi.ModelScale.ToString("F"), mi.OutLineDotWidth.ToString("F"), 
                mi.OutLineWidth.ToString("F"), mi.MotionSetDirectory))
            {
                if (mc.ShowDialog() == DialogResult.OK)
                {
                    mil.MInfos[index] = new ModelInfo(item.FilePath, mc.MPositionX, mc.MPositionY, mc.MPositionZ,
                        mc.MRotationX, mc.MRotationY, mc.MRotationZ, double.Parse(mc.ModelScale),
                        double.Parse(mc.OutLineDotWidth), double.Parse(mc.OutLineWidth), mc.MotionSet);
                }
            }
        }

        private void modeladdbutton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PMD/PMXファイル(*.pmd;*.pmx)|*.pmd;*.pmx";
                ofd.Title = "ファイルを選択してください";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string file = ofd.FileName;
                    modellist.Items.Add(new SuperListViewItem(Path.GetFileName(file), file));
                    mil.MInfos.Add(new ModelInfo(file, 0, 0, 80, 0, 0, 0, 0.7, 0.5, 1.0, ""));
                }
            }
        }

        private void modeldelbutton_Click(object sender, EventArgs e)
        {
            if (modellist.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                ListViewItem item = modellist.SelectedItems[0];
                int index = item.Index;
                modellist.Items.Remove(item);
                mil.MInfos.RemoveAt(index);
            }
        }

        public class SuperListViewItem : ListViewItem
        {
            public string FilePath { get; set; }

            public SuperListViewItem(string filename, string filepath) : base(filename)
            {
                FilePath = filepath;
            }
        }
    }
}