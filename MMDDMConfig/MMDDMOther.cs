using System;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void gravitytext_TextChanged(object sender, EventArgs e)
        {
            TextBox target = (TextBox)sender;
            common.Gravity = int.Parse(target.Text);
        }

        private void mspeedtext_TextChanged(object sender, EventArgs e)
        {
            TextBox target = (TextBox)sender;
            common.MoveSpeed = int.Parse(target.Text);
        }

        private void topmostcheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox target = (CheckBox)sender;
            if (target.Checked)
            {
                common.WindowTopMost = 1;
            }
            else
            {
                common.WindowTopMost = 0;
            }
        }

        private void fpscheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox target = (CheckBox)sender;
            if (target.Checked)
            {
                common.FpsDraw = 1;
            }
            else
            {
                common.FpsDraw = 0;
            }
        }

        private void backupcheck_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox target = (CheckBox)sender;
            if (target.Checked)
            {
                common.Backup = true;
            }
            else
            {
                common.Backup = false;
            }
        }
    }
}