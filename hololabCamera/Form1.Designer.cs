using Accord.Controls;
using Accord.Video.FFMPEG;
using System.Drawing;

namespace hololabCamera
{
    partial class HololabCamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HololabCamera));
            this.vsp = new Accord.Controls.VideoSourcePlayer();
            this.pictureBox1 = new Accord.Controls.PictureBox();
            this.btnReconect = new System.Windows.Forms.Button();
            this.btnServidor = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // vsp
            // 
            resources.ApplyResources(this.vsp, "vsp");
            this.vsp.Name = "vsp";
            this.vsp.VideoSource = null;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // btnReconect
            // 
            resources.ApplyResources(this.btnReconect, "btnReconect");
            this.btnReconect.Name = "btnReconect";
            this.btnReconect.UseVisualStyleBackColor = true;
            this.btnReconect.Click += new System.EventHandler(this.btnReconect_Click);
            // 
            // btnServidor
            // 
            resources.ApplyResources(this.btnServidor, "btnServidor");
            this.btnServidor.Name = "btnServidor";
            this.btnServidor.UseVisualStyleBackColor = true;
            this.btnServidor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnServidor_MouseClick);
            // 
            // btnParar
            // 
            resources.ApplyResources(this.btnParar, "btnParar");
            this.btnParar.Name = "btnParar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // HololabCamera
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnServidor);
            this.Controls.Add(this.btnReconect);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.vsp);
            this.Name = "HololabCamera";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HololabCamera_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Accord.Controls.VideoSourcePlayer vsp;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Button btnReconect;
        private System.Windows.Forms.Button btnServidor;
        private System.Windows.Forms.Button btnParar;
    }
}

