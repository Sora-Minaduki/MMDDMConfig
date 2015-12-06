using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm : Form
    {
        private Common common = Common.Instance;
        private ModelInfoList mil = ModelInfoList.Instance;

        public ConfigForm()
        {
            InitializeComponent();
            InitNumeric();
            InitConfig();
        }

        private void InitNumeric()
        {
            pxnum.Maximum = decimal.MaxValue;
            pxnum.Minimum = decimal.MinValue;
            pynum.Maximum = decimal.MaxValue;
            pynum.Minimum = decimal.MinValue;
            pznum.Maximum = decimal.MaxValue;
            pznum.Minimum = decimal.MinValue;
            txnum.Maximum = decimal.MaxValue;
            txnum.Minimum = decimal.MinValue;
            tynum.Maximum = decimal.MaxValue;
            tynum.Minimum = decimal.MinValue;
            tznum.Maximum = decimal.MaxValue;
            tznum.Minimum = decimal.MinValue;
        }

        private void InitConfig()
        {
            common.Directory = "";
            common.Backup = true;
            common.CPositionX = pxnum.Value;
            common.CPositionY = pynum.Value;
            common.CPositionZ = pznum.Value;
            common.CTargetX = txnum.Value;
            common.CTargetY = tynum.Value;
            common.CTargetZ = tznum.Value;
            common.TransR = transrnum.Value;
            common.TransG = transgnum.Value;
            common.TransB = transgnum.Value;
            common.AliasLevel = int.Parse(aliascombo.Text);
            common.Physics = int.Parse(physicscombo.Text);
            common.FieldOfView = viewnum.Value;
            common.FpsLimit = fpslimitnum.Value;
            common.Volume = volumenum.Value;
            common.Gravity = int.Parse(gravitytext.Text);
            common.MoveSpeed = double.Parse(mspeedtext.Text);
            if (topmostcheck.Checked)
            {
                common.WindowTopMost = 1;
            }
            else
            {
                common.WindowTopMost = 0;
            }
            if (fpscheck.Checked)
            {
                common.FpsDraw = 1;
            }
            else
            {
                common.FpsDraw = 0;
            }
        }

        private void ConfigForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(drags[0]) && drags[0].EndsWith(".ini"))
                {
                    e.Effect = DragDropEffects.All;
                }
                else e.Effect = DragDropEffects.None;
            }
            else e.Effect = DragDropEffects.None;
        }

        private void ConfigForm_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                if (File.Exists(file[0]) && file[0].EndsWith(".ini"))
                {
                    MessageBox.Show(file[0]);
                }
            }
        }
    }
}
