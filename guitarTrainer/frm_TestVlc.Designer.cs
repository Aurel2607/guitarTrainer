﻿namespace guitarTrainer
{
	partial class frm_TestVlc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_TestVlc));
			this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.lbl_fileName = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
			this.SuspendLayout();
			// 
			// axVLCPlugin21
			// 
			this.axVLCPlugin21.Enabled = true;
			this.axVLCPlugin21.Location = new System.Drawing.Point(12, 12);
			this.axVLCPlugin21.Name = "axVLCPlugin21";
			this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
			this.axVLCPlugin21.Size = new System.Drawing.Size(528, 392);
			this.axVLCPlugin21.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(621, 67);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Load";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(621, 96);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Start";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(621, 125);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Stop";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(621, 154);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Pause";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// lbl_fileName
			// 
			this.lbl_fileName.AutoSize = true;
			this.lbl_fileName.Location = new System.Drawing.Point(22, 447);
			this.lbl_fileName.Name = "lbl_fileName";
			this.lbl_fileName.Size = new System.Drawing.Size(35, 13);
			this.lbl_fileName.TabIndex = 5;
			this.lbl_fileName.Text = "label1";
			// 
			// frm_TestVlc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 502);
			this.Controls.Add(this.lbl_fileName);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.axVLCPlugin21);
			this.Name = "frm_TestVlc";
			this.Text = "Testing VLC";
			((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Label lbl_fileName;
	}
}