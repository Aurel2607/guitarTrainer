using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guitarTrainer
{
	public partial class sectionDisplay : Form
	{
		public sectionDisplay(string titleName)
		{
			InitializeComponent();
			this.Text = titleName;
		}

		public sectionDisplay(string titleName, List<string[]> argList)
		{
			InitializeComponent();
			this.Text = titleName;
			int offset = 0;
			List<Button> btnList = new List<Button>();

			this.SuspendLayout();

			foreach (string[] strTab in argList)
			{
				// Label Name
				Label label = new Label();
				label.AutoSize = true;
				label.Location = new System.Drawing.Point(30, 45 + offset);
				label.Name = strTab[0];
				label.Size = new System.Drawing.Size(40, 20);
				label.Text = strTab[0];
				this.Controls.Add(label);

				// File Btn ==> 
				Button btnFile = new Button();
				btnFile.Location = new System.Drawing.Point(180, 40 + offset);
				btnFile.Name = "File";
				btnFile.Size = new System.Drawing.Size(100, 20);
				btnFile.Text = "File";
				btnFile.UseVisualStyleBackColor = true;
				this.Controls.Add(btnFile);
				btnList.Add(btnFile);

				// Audio Btn ==> Vlc
				Button btnAudio = new Button();
				btnAudio.Location = new System.Drawing.Point(280, 40 + offset);
				btnAudio.Name = "Audio";
				btnAudio.Size = new System.Drawing.Size(100, 20);
				btnAudio.Text = "Audio";
				btnAudio.UseVisualStyleBackColor = true;
				this.Controls.Add(btnAudio);
				btnList.Add(btnAudio);

				// Video Btn ==> Vlc
				Button btnVideo = new Button();
				btnVideo.Location = new System.Drawing.Point(380, 40 + offset);
				btnVideo.Name = "Video";
				btnVideo.Size = new System.Drawing.Size(100, 20);
				btnVideo.Text = "Video";
				btnVideo.UseVisualStyleBackColor = true;
				this.Controls.Add(btnVideo);
				btnList.Add(btnVideo);

				offset += 20;
			}


			this.ResumeLayout(false);
		}

	}
}
