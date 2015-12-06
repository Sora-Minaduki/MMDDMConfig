using System;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void pxnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CPositionX = target.Value;
        }

        private void pynum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CPositionY = target.Value;
        }

        private void pznum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CPositionZ = target.Value;
        }

        private void txnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CTargetX = target.Value;
        }

        private void tynum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CTargetY = target.Value;
        }

        private void tznum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.CTargetZ = target.Value;
        }

        private void transrnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.TransR = target.Value;
        }

        private void transgnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.TransG = target.Value;
        }

        private void transbnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.TransB = target.Value;
        }

        private void viewnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.FieldOfView = target.Value;
        }

        private void fpslimitnum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.FpsLimit = target.Value;
        }

        private void volumenum_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown target = (NumericUpDown)sender;
            common.Volume = target.Value;
        }
    }
}