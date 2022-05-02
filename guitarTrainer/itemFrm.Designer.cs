namespace guitarTrainer
{
	partial class itemFrm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(itemFrm));
			this.pb_file = new System.Windows.Forms.PictureBox();
			this.vlc_Audio = new AxAXVLC.AxVLCPlugin2();
			this.vlc_video = new AxAXVLC.AxVLCPlugin2();
			this.lbl_Title = new System.Windows.Forms.Label();
			this.vlc_PB = new AxAXVLC.AxVLCPlugin2();
			((System.ComponentModel.ISupportInitialize)(this.pb_file)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_Audio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_video)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_PB)).BeginInit();
			this.SuspendLayout();
			// 
			// pb_file
			// 
			this.pb_file.InitialImage = null;
			this.pb_file.Location = new System.Drawing.Point(12, 56);
			this.pb_file.Name = "pb_file";
			this.pb_file.Size = new System.Drawing.Size(573, 611);
			this.pb_file.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_file.TabIndex = 0;
			this.pb_file.TabStop = false;
			// 
			// vlc_Audio
			// 
			this.vlc_Audio.Enabled = true;
			this.vlc_Audio.Location = new System.Drawing.Point(12, 678);
			this.vlc_Audio.Name = "vlc_Audio";
			this.vlc_Audio.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlc_Audio.OcxState")));
			this.vlc_Audio.Size = new System.Drawing.Size(573, 54);
			this.vlc_Audio.TabIndex = 1;
			// 
			// vlc_video
			// 
			this.vlc_video.Enabled = true;
			this.vlc_video.Location = new System.Drawing.Point(591, 56);
			this.vlc_video.Name = "vlc_video";
			this.vlc_video.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlc_video.OcxState")));
			this.vlc_video.Size = new System.Drawing.Size(633, 610);
			this.vlc_video.TabIndex = 2;
			// 
			// lbl_Title
			// 
			this.lbl_Title.AutoSize = true;
			this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Title.Location = new System.Drawing.Point(537, 9);
			this.lbl_Title.Name = "lbl_Title";
			this.lbl_Title.Size = new System.Drawing.Size(60, 25);
			this.lbl_Title.TabIndex = 3;
			this.lbl_Title.Text = "Titre";
			// 
			// vlc_PB
			// 
			this.vlc_PB.Enabled = true;
			this.vlc_PB.Location = new System.Drawing.Point(591, 678);
			this.vlc_PB.Name = "vlc_PB";
			this.vlc_PB.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vlc_PB.OcxState")));
			this.vlc_PB.Size = new System.Drawing.Size(633, 54);
			this.vlc_PB.TabIndex = 4;
			// 
			// itemFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1237, 744);
			this.Controls.Add(this.vlc_PB);
			this.Controls.Add(this.lbl_Title);
			this.Controls.Add(this.vlc_video);
			this.Controls.Add(this.vlc_Audio);
			this.Controls.Add(this.pb_file);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "itemFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "itemFrm";
			((System.ComponentModel.ISupportInitialize)(this.pb_file)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_Audio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_video)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.vlc_PB)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pb_file;
		private AxAXVLC.AxVLCPlugin2 vlc_Audio;
		private AxAXVLC.AxVLCPlugin2 vlc_video;
		private System.Windows.Forms.Label lbl_Title;
		private AxAXVLC.AxVLCPlugin2 vlc_PB;
	}
}