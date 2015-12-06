using System;
using System.Windows.Forms;
using System.IO;

namespace MMDDMConfig
{
    public partial class ConfigForm
    {
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(common.Directory))
            {
                string dir = common.Directory;
                string output = dir + "\\MMDDM.ini";

                if (File.Exists(output) && common.Backup)
                {
                    string newdir = dir + "\\backup";
                    if (!Directory.Exists(newdir))
                    {
                        Directory.CreateDirectory(newdir);
                    }
                    string cpfile = newdir + "\\MMDDM" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".ini";
                    File.Copy(output, cpfile, true);
                }

                IniFile ini = new IniFile(output);

                for (int i = 0; i < common.FileCount; i++)
                {
                    ini["common", String.Format("SoundF{0}", i + 1)] = common.SoundFile(i);
                }
                ini["common", "CameraPosition"] = 
                    String.Format("{0},{1},{2}", common.CPositionX, common.CPositionY, common.CPositionZ);
                ini["common", "CameraTarget"] =
                    String.Format("{0},{1},{2}", common.CTargetX, common.CTargetY, common.CTargetZ);
                ini["common", "FieldOfView"] = common.FieldOfView.ToString();
                ini["common", "WindowTopMost"] = common.WindowTopMost.ToString();
                ini["common", "TransParent"] =
                    String.Format("{0},{1},{2}", common.TransR, common.TransG, common.TransB);
                ini["common", "AntiAliasing"] = common.AliasLevel.ToString();
                ini["common", "SoundVol"] = common.Volume.ToString();
                ini["common", "Physics"] = common.Physics.ToString();
                ini["common", "Gravity"] = common.Gravity.ToString();
                ini["common", "FpsDraw"] = common.FpsDraw.ToString();
                ini["common", "FpsLimit"] = common.FpsLimit.ToString();
                ini["common", "MoveSpeed"] = common.MoveSpeed.ToString();

                MessageBox.Show("保存しました");
            }
        }
    }
}