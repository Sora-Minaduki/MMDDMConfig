using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MMDDMConfig
{
    public partial class ModelConfig : Form
    {
        public ModelConfig()
        {
            InitializeComponent();
            InitNumeric();
        }

        public ModelConfig(decimal mpx, decimal mpy, decimal mpz, decimal mrx, decimal mry, decimal mrz,
            string ms, string oldw, string olw, string msd)
        {
            InitializeComponent();
            InitNumeric();
            MPositionX = mpx; MPositionY = mpy; MPositionZ = mpz;
            MRotationX = mrx; MRotationY = mry; MRotationZ = mrz;
            ModelScale = ms;
            OutLineDotWidth = oldw;
            OutLineWidth = olw;
            MotionSet = msd;
        }

        private void InitNumeric()
        {
            mpxnum.Maximum = decimal.MaxValue;
            mpxnum.Minimum = decimal.MinValue;
            mpynum.Maximum = decimal.MaxValue;
            mpynum.Minimum = decimal.MinValue;
            mpznum.Maximum = decimal.MaxValue;
            mpznum.Minimum = decimal.MinValue;
            mrxnum.Maximum = decimal.MaxValue;
            mrxnum.Minimum = decimal.MinValue;
            mrynum.Maximum = decimal.MaxValue;
            mrynum.Minimum = decimal.MinValue;
            mrznum.Maximum = decimal.MaxValue;
            mrznum.Minimum = decimal.MinValue;
        }

        private void okbutton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public decimal MPositionX { get { return mpxnum.Value; } set { mpxnum.Value = value; } }
        public decimal MPositionY { get { return mpynum.Value; } set { mpynum.Value = value; } }
        public decimal MPositionZ { get { return mpznum.Value; } set { mpznum.Value = value; } }
        public decimal MRotationX { get { return mrxnum.Value; } set { mrxnum.Value = value; } }
        public decimal MRotationY { get { return mrynum.Value; } set { mrynum.Value = value; } }
        public decimal MRotationZ { get { return mrznum.Value; } set { mrznum.Value = value; } }
        public string ModelScale { get { return scaletext.Text; } set { scaletext.Text = value; } }
        public string OutLineDotWidth { get { return oldwtext.Text; } set { oldwtext.Text = value; } }
        public string OutLineWidth { get { return olwtext.Text; } set { olwtext.Text = value; } }
        public string MotionSet { get { return motionsetpathtext.Text; } set { motionsetpathtext.Text = value; } }
    }
}
