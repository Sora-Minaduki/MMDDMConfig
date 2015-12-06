using System;
using System.Collections.Generic;
using System.IO;

namespace MMDDMConfig
{
    public class Common
    {
        private static Common instance;
        private static List<string> soundFiles;
        private const int filecount = 10;

        public static Common Instance { get { return instance ?? (instance = new Common()); } }
        public decimal CPositionX { get; set; }
        public decimal CPositionY { get; set; }
        public decimal CPositionZ { get; set; }
        public decimal CTargetX { get; set; }
        public decimal CTargetY { get; set; }
        public decimal CTargetZ { get; set; }
        public decimal FieldOfView { get; set; }
        public int WindowTopMost { get; set; }
        public decimal TransR { get; set; }
        public decimal TransG { get; set; }
        public decimal TransB { get; set; }
        public int AliasLevel { get; set; }
        public decimal Volume { get; set; }
        public int Physics { get; set; }
        public int Gravity { get; set; }
        public int FpsDraw { get; set; }
        public decimal FpsLimit { get; set; }
        public double MoveSpeed { get; set; }
        public string Directory { get; set; }
        public bool Backup { get; set; }
        public int FileCount
        {
            get { return filecount; }
        }

        public string SoundFile(int i)
        {
            return soundFiles[i];
        }

        public void SoundFile(int i, string file)
        {
            soundFiles[i] = file;
        }

        private Common()
        {
            Initialize();
        }

        private void Initialize()
        {
            soundFiles = new List<string>();
            for (int i = 0; i < filecount; i++)
            {
                soundFiles.Add("");
            }
        }
    }
}