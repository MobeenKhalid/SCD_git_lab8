
namespace LAB_8
{
    partial class playarea
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playarea));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topwall = new System.Windows.Forms.Panel();
            this.bottomwall = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rightwall = new System.Windows.Forms.Panel();
            this.leftwall = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LAB_8.Properties.Resources.cat;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(327, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 69);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // topwall
            // 
            this.topwall.Dock = System.Windows.Forms.DockStyle.Top;
            this.topwall.Location = new System.Drawing.Point(0, 0);
            this.topwall.Margin = new System.Windows.Forms.Padding(1);
            this.topwall.Name = "topwall";
            this.topwall.Size = new System.Drawing.Size(800, 10);
            this.topwall.TabIndex = 1;
            // 
            // bottomwall
            // 
            this.bottomwall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomwall.Location = new System.Drawing.Point(0, 430);
            this.bottomwall.Name = "bottomwall";
            this.bottomwall.Size = new System.Drawing.Size(800, 20);
            this.bottomwall.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(327, 56);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 50);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // rightwall
            // 
            this.rightwall.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightwall.Location = new System.Drawing.Point(770, 10);
            this.rightwall.Name = "rightwall";
            this.rightwall.Size = new System.Drawing.Size(30, 420);
            this.rightwall.TabIndex = 4;
            // 
            // leftwall
            // 
            this.leftwall.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftwall.Location = new System.Drawing.Point(0, 10);
            this.leftwall.Name = "leftwall";
            this.leftwall.Size = new System.Drawing.Size(30, 420);
            this.leftwall.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            // 
            // playarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.leftwall);
            this.Controls.Add(this.rightwall);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.bottomwall);
            this.Controls.Add(this.topwall);
            this.Controls.Add(this.pictureBox1);
            this.Name = "playarea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.playarea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topwall;
        private System.Windows.Forms.Panel bottomwall;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel rightwall;
        private System.Windows.Forms.Panel leftwall;
        private System.Windows.Forms.Timer timer1;
    }
}

