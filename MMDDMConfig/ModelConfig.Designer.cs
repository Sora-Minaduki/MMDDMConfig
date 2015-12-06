namespace MMDDMConfig
{
    partial class ModelConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mpgroup = new System.Windows.Forms.GroupBox();
            this.mppanel = new System.Windows.Forms.Panel();
            this.mpznum = new System.Windows.Forms.NumericUpDown();
            this.mpynum = new System.Windows.Forms.NumericUpDown();
            this.mpxnum = new System.Windows.Forms.NumericUpDown();
            this.mpzlabel = new System.Windows.Forms.Label();
            this.mpylabel = new System.Windows.Forms.Label();
            this.mpxlabel = new System.Windows.Forms.Label();
            this.mrgroup = new System.Windows.Forms.GroupBox();
            this.mrpanel = new System.Windows.Forms.Panel();
            this.mrznum = new System.Windows.Forms.NumericUpDown();
            this.mrynum = new System.Windows.Forms.NumericUpDown();
            this.mrxnum = new System.Windows.Forms.NumericUpDown();
            this.mrzlabel = new System.Windows.Forms.Label();
            this.mrylabel = new System.Windows.Forms.Label();
            this.mrxlabel = new System.Windows.Forms.Label();
            this.pathpanel = new System.Windows.Forms.Panel();
            this.motionsetlabel = new System.Windows.Forms.Label();
            this.motionsetpathtext = new System.Windows.Forms.TextBox();
            this.motionsetpathbutton = new System.Windows.Forms.Button();
            this.scalegroup = new System.Windows.Forms.GroupBox();
            this.scaletext = new System.Windows.Forms.TextBox();
            this.oldwgroup = new System.Windows.Forms.GroupBox();
            this.oldwtext = new System.Windows.Forms.TextBox();
            this.olwgroup = new System.Windows.Forms.GroupBox();
            this.olwtext = new System.Windows.Forms.TextBox();
            this.okbutton = new System.Windows.Forms.Button();
            this.mpgroup.SuspendLayout();
            this.mppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpznum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpxnum)).BeginInit();
            this.mrgroup.SuspendLayout();
            this.mrpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrznum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrynum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrxnum)).BeginInit();
            this.pathpanel.SuspendLayout();
            this.scalegroup.SuspendLayout();
            this.oldwgroup.SuspendLayout();
            this.olwgroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // mpgroup
            // 
            this.mpgroup.Controls.Add(this.mppanel);
            this.mpgroup.Location = new System.Drawing.Point(14, 56);
            this.mpgroup.Name = "mpgroup";
            this.mpgroup.Size = new System.Drawing.Size(95, 102);
            this.mpgroup.TabIndex = 12;
            this.mpgroup.TabStop = false;
            this.mpgroup.Text = "モデルの座標";
            // 
            // mppanel
            // 
            this.mppanel.Controls.Add(this.mpznum);
            this.mppanel.Controls.Add(this.mpynum);
            this.mppanel.Controls.Add(this.mpxnum);
            this.mppanel.Controls.Add(this.mpzlabel);
            this.mppanel.Controls.Add(this.mpylabel);
            this.mppanel.Controls.Add(this.mpxlabel);
            this.mppanel.Location = new System.Drawing.Point(6, 18);
            this.mppanel.Name = "mppanel";
            this.mppanel.Size = new System.Drawing.Size(77, 77);
            this.mppanel.TabIndex = 10;
            // 
            // mpznum
            // 
            this.mpznum.Location = new System.Drawing.Point(22, 54);
            this.mpznum.Name = "mpznum";
            this.mpznum.Size = new System.Drawing.Size(47, 19);
            this.mpznum.TabIndex = 22;
            this.mpznum.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            // 
            // mpynum
            // 
            this.mpynum.Location = new System.Drawing.Point(22, 29);
            this.mpynum.Name = "mpynum";
            this.mpynum.Size = new System.Drawing.Size(47, 19);
            this.mpynum.TabIndex = 22;
            // 
            // mpxnum
            // 
            this.mpxnum.Location = new System.Drawing.Point(22, 4);
            this.mpxnum.Name = "mpxnum";
            this.mpxnum.Size = new System.Drawing.Size(47, 19);
            this.mpxnum.TabIndex = 7;
            // 
            // mpzlabel
            // 
            this.mpzlabel.AutoSize = true;
            this.mpzlabel.Location = new System.Drawing.Point(3, 56);
            this.mpzlabel.Name = "mpzlabel";
            this.mpzlabel.Size = new System.Drawing.Size(12, 12);
            this.mpzlabel.TabIndex = 3;
            this.mpzlabel.Text = "z:";
            // 
            // mpylabel
            // 
            this.mpylabel.AutoSize = true;
            this.mpylabel.Location = new System.Drawing.Point(3, 31);
            this.mpylabel.Name = "mpylabel";
            this.mpylabel.Size = new System.Drawing.Size(13, 12);
            this.mpylabel.TabIndex = 2;
            this.mpylabel.Text = "y:";
            // 
            // mpxlabel
            // 
            this.mpxlabel.AutoSize = true;
            this.mpxlabel.Location = new System.Drawing.Point(3, 6);
            this.mpxlabel.Name = "mpxlabel";
            this.mpxlabel.Size = new System.Drawing.Size(13, 12);
            this.mpxlabel.TabIndex = 1;
            this.mpxlabel.Text = "x:";
            // 
            // mrgroup
            // 
            this.mrgroup.Controls.Add(this.mrpanel);
            this.mrgroup.Location = new System.Drawing.Point(14, 164);
            this.mrgroup.Name = "mrgroup";
            this.mrgroup.Size = new System.Drawing.Size(95, 102);
            this.mrgroup.TabIndex = 13;
            this.mrgroup.TabStop = false;
            this.mrgroup.Text = "モデルの向き";
            // 
            // mrpanel
            // 
            this.mrpanel.Controls.Add(this.mrznum);
            this.mrpanel.Controls.Add(this.mrynum);
            this.mrpanel.Controls.Add(this.mrxnum);
            this.mrpanel.Controls.Add(this.mrzlabel);
            this.mrpanel.Controls.Add(this.mrylabel);
            this.mrpanel.Controls.Add(this.mrxlabel);
            this.mrpanel.Location = new System.Drawing.Point(6, 18);
            this.mrpanel.Name = "mrpanel";
            this.mrpanel.Size = new System.Drawing.Size(77, 77);
            this.mrpanel.TabIndex = 10;
            // 
            // mrznum
            // 
            this.mrznum.Location = new System.Drawing.Point(22, 54);
            this.mrznum.Name = "mrznum";
            this.mrznum.Size = new System.Drawing.Size(47, 19);
            this.mrznum.TabIndex = 22;
            // 
            // mrynum
            // 
            this.mrynum.Location = new System.Drawing.Point(22, 29);
            this.mrynum.Name = "mrynum";
            this.mrynum.Size = new System.Drawing.Size(47, 19);
            this.mrynum.TabIndex = 22;
            // 
            // mrxnum
            // 
            this.mrxnum.Location = new System.Drawing.Point(22, 4);
            this.mrxnum.Name = "mrxnum";
            this.mrxnum.Size = new System.Drawing.Size(47, 19);
            this.mrxnum.TabIndex = 7;
            // 
            // mrzlabel
            // 
            this.mrzlabel.AutoSize = true;
            this.mrzlabel.Location = new System.Drawing.Point(3, 56);
            this.mrzlabel.Name = "mrzlabel";
            this.mrzlabel.Size = new System.Drawing.Size(12, 12);
            this.mrzlabel.TabIndex = 3;
            this.mrzlabel.Text = "z:";
            // 
            // mrylabel
            // 
            this.mrylabel.AutoSize = true;
            this.mrylabel.Location = new System.Drawing.Point(3, 31);
            this.mrylabel.Name = "mrylabel";
            this.mrylabel.Size = new System.Drawing.Size(13, 12);
            this.mrylabel.TabIndex = 2;
            this.mrylabel.Text = "y:";
            // 
            // mrxlabel
            // 
            this.mrxlabel.AutoSize = true;
            this.mrxlabel.Location = new System.Drawing.Point(3, 6);
            this.mrxlabel.Name = "mrxlabel";
            this.mrxlabel.Size = new System.Drawing.Size(13, 12);
            this.mrxlabel.TabIndex = 1;
            this.mrxlabel.Text = "x:";
            // 
            // pathpanel
            // 
            this.pathpanel.Controls.Add(this.motionsetlabel);
            this.pathpanel.Controls.Add(this.motionsetpathtext);
            this.pathpanel.Controls.Add(this.motionsetpathbutton);
            this.pathpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pathpanel.Location = new System.Drawing.Point(0, 0);
            this.pathpanel.Name = "pathpanel";
            this.pathpanel.Size = new System.Drawing.Size(272, 50);
            this.pathpanel.TabIndex = 14;
            // 
            // motionsetlabel
            // 
            this.motionsetlabel.AutoSize = true;
            this.motionsetlabel.Location = new System.Drawing.Point(12, 9);
            this.motionsetlabel.Name = "motionsetlabel";
            this.motionsetlabel.Size = new System.Drawing.Size(58, 12);
            this.motionsetlabel.TabIndex = 0;
            this.motionsetlabel.Text = "MotionSet:";
            // 
            // motionsetpathtext
            // 
            this.motionsetpathtext.AllowDrop = true;
            this.motionsetpathtext.Location = new System.Drawing.Point(14, 24);
            this.motionsetpathtext.Name = "motionsetpathtext";
            this.motionsetpathtext.Size = new System.Drawing.Size(188, 19);
            this.motionsetpathtext.TabIndex = 1;
            // 
            // motionsetpathbutton
            // 
            this.motionsetpathbutton.Location = new System.Drawing.Point(208, 22);
            this.motionsetpathbutton.Name = "motionsetpathbutton";
            this.motionsetpathbutton.Size = new System.Drawing.Size(49, 23);
            this.motionsetpathbutton.TabIndex = 2;
            this.motionsetpathbutton.Text = "参照";
            this.motionsetpathbutton.UseVisualStyleBackColor = true;
            // 
            // scalegroup
            // 
            this.scalegroup.Controls.Add(this.scaletext);
            this.scalegroup.Location = new System.Drawing.Point(115, 56);
            this.scalegroup.Name = "scalegroup";
            this.scalegroup.Size = new System.Drawing.Size(142, 48);
            this.scalegroup.TabIndex = 19;
            this.scalegroup.TabStop = false;
            this.scalegroup.Text = "倍率(モデル)";
            // 
            // scaletext
            // 
            this.scaletext.Location = new System.Drawing.Point(6, 19);
            this.scaletext.Name = "scaletext";
            this.scaletext.Size = new System.Drawing.Size(130, 19);
            this.scaletext.TabIndex = 0;
            this.scaletext.Text = "0.7";
            // 
            // oldwgroup
            // 
            this.oldwgroup.Controls.Add(this.oldwtext);
            this.oldwgroup.Location = new System.Drawing.Point(115, 110);
            this.oldwgroup.Name = "oldwgroup";
            this.oldwgroup.Size = new System.Drawing.Size(142, 48);
            this.oldwgroup.TabIndex = 20;
            this.oldwgroup.TabStop = false;
            this.oldwgroup.Text = "倍率(太さ不変の輪郭線)";
            // 
            // oldwtext
            // 
            this.oldwtext.Location = new System.Drawing.Point(6, 19);
            this.oldwtext.Name = "oldwtext";
            this.oldwtext.Size = new System.Drawing.Size(130, 19);
            this.oldwtext.TabIndex = 0;
            this.oldwtext.Text = "0.5";
            // 
            // olwgroup
            // 
            this.olwgroup.Controls.Add(this.olwtext);
            this.olwgroup.Location = new System.Drawing.Point(115, 164);
            this.olwgroup.Name = "olwgroup";
            this.olwgroup.Size = new System.Drawing.Size(142, 48);
            this.olwgroup.TabIndex = 21;
            this.olwgroup.TabStop = false;
            this.olwgroup.Text = "倍率(太さ可変の輪郭線)";
            // 
            // olwtext
            // 
            this.olwtext.Location = new System.Drawing.Point(6, 19);
            this.olwtext.Name = "olwtext";
            this.olwtext.Size = new System.Drawing.Size(130, 19);
            this.olwtext.TabIndex = 0;
            this.olwtext.Text = "1.0";
            // 
            // okbutton
            // 
            this.okbutton.Location = new System.Drawing.Point(187, 243);
            this.okbutton.Name = "okbutton";
            this.okbutton.Size = new System.Drawing.Size(64, 23);
            this.okbutton.TabIndex = 22;
            this.okbutton.Text = "OK";
            this.okbutton.UseVisualStyleBackColor = true;
            this.okbutton.Click += new System.EventHandler(this.okbutton_Click);
            // 
            // ModelConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 282);
            this.Controls.Add(this.okbutton);
            this.Controls.Add(this.olwgroup);
            this.Controls.Add(this.oldwgroup);
            this.Controls.Add(this.scalegroup);
            this.Controls.Add(this.pathpanel);
            this.Controls.Add(this.mrgroup);
            this.Controls.Add(this.mpgroup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModelConfig";
            this.Text = "ModelConfig";
            this.mpgroup.ResumeLayout(false);
            this.mppanel.ResumeLayout(false);
            this.mppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mpznum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mpxnum)).EndInit();
            this.mrgroup.ResumeLayout(false);
            this.mrpanel.ResumeLayout(false);
            this.mrpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mrznum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrynum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrxnum)).EndInit();
            this.pathpanel.ResumeLayout(false);
            this.pathpanel.PerformLayout();
            this.scalegroup.ResumeLayout(false);
            this.scalegroup.PerformLayout();
            this.oldwgroup.ResumeLayout(false);
            this.oldwgroup.PerformLayout();
            this.olwgroup.ResumeLayout(false);
            this.olwgroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mpgroup;
        private System.Windows.Forms.Panel mppanel;
        private System.Windows.Forms.NumericUpDown mpznum;
        private System.Windows.Forms.NumericUpDown mpynum;
        private System.Windows.Forms.NumericUpDown mpxnum;
        private System.Windows.Forms.Label mpzlabel;
        private System.Windows.Forms.Label mpylabel;
        private System.Windows.Forms.Label mpxlabel;
        private System.Windows.Forms.GroupBox mrgroup;
        private System.Windows.Forms.Panel mrpanel;
        private System.Windows.Forms.NumericUpDown mrznum;
        private System.Windows.Forms.NumericUpDown mrynum;
        private System.Windows.Forms.NumericUpDown mrxnum;
        private System.Windows.Forms.Label mrzlabel;
        private System.Windows.Forms.Label mrylabel;
        private System.Windows.Forms.Label mrxlabel;
        private System.Windows.Forms.Panel pathpanel;
        private System.Windows.Forms.Label motionsetlabel;
        private System.Windows.Forms.TextBox motionsetpathtext;
        private System.Windows.Forms.Button motionsetpathbutton;
        private System.Windows.Forms.GroupBox scalegroup;
        private System.Windows.Forms.TextBox scaletext;
        private System.Windows.Forms.GroupBox oldwgroup;
        private System.Windows.Forms.TextBox oldwtext;
        private System.Windows.Forms.GroupBox olwgroup;
        private System.Windows.Forms.TextBox olwtext;
        private System.Windows.Forms.Button okbutton;
    }
}