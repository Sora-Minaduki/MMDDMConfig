using System;
using System.Collections.Generic;
using System.IO;

namespace MMDDMConfig
{
    public class ModelInfoList
    {
        private static ModelInfoList instance;

        public static ModelInfoList Instance { get { return instance ?? (instance = new ModelInfoList()); } }
        public List<ModelInfo> MInfos { get; private set; }

        public ModelInfoList()
        {
            MInfos = new List<ModelInfo>();
        }
    }

    public class ModelInfo
    {
        public string File { get; set; }
        public decimal MPositionX { get; set; }
        public decimal MPositionY { get; set; }
        public decimal MPositionZ { get; set; }
        public decimal MRotationX { get; set; }
        public decimal MRotationY { get; set; }
        public decimal MRotationZ { get; set; }
        public double ModelScale { get; set; }
        public double OutLineDotWidth { get; set; }
        public double OutLineWidth { get; set; }
        public string MotionSetDirectory { get; set; }

        public ModelInfo(string file, decimal mpx, decimal mpy, decimal mpz, decimal mrx,
            decimal mry, decimal mrz, double ms, double oldw, double olw, string msd)
        {
            File = file;
            MPositionX = mpx; MPositionY = mpy; MPositionZ = mpz;
            MRotationX = mrx; MRotationY = mry; MRotationZ = mrz;
            ModelScale = ms;
            OutLineDotWidth = oldw;
            OutLineWidth = olw;
            MotionSetDirectory = msd;
        }
    }
}
