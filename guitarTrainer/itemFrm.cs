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
	public partial class itemFrm : Form
	{
		public itemFrm(string[] argLst)
		{
			InitializeComponent();

			// Affichage Nom
			if (argLst[0] != null)
			{
				this.lbl_Title.Text = argLst[0];
				this.Text = argLst[0];
			}

			// Affichage Image
			if (argLst[1] != "")
			{
				Console.WriteLine("Pic Name: '" + argLst[1] + "'");
				this.pb_file.Enabled = true;
				try
				{
					string filePath = AppConfigParser.getRessourceFolder() + @"\" + argLst[1];
					this.pb_file.Image = Image.FromFile(filePath);
				}
				catch(System.IO.FileNotFoundException)
				{
					this.pb_file.Enabled = false;
				}
			}
			else
			{
				Console.WriteLine("Pic Name: None");
				this.pb_file.Enabled = false;
			}

			// Affichage Audio
			if (argLst[2] != "")
			{
				Console.WriteLine("Audio Name: '" + argLst[2] + "'");
				this.vlc_Audio.CtlVisible = true;
				this.vlc_Audio.Toolbar = true;
				string filename = "file:///" + @AppConfigParser.getRessourceFolder() + @"\" + argLst[2];
				vlc_Audio.playlist.add(filename);
			}
			else
			{
				Console.WriteLine("Audio Name: None");
				this.vlc_Audio.CtlVisible = false;
				this.vlc_Audio.Toolbar = false;
			}

			// Affichage Video
			if (argLst[3] != "")
			{
				Console.WriteLine("Video Name: '" + argLst[3] + "'");
				this.vlc_video.CtlVisible = true;
				this.vlc_video.Toolbar = true;
				string filename = "file:///" + @AppConfigParser.getRessourceFolder() + @"\" + argLst[3];
				vlc_video.playlist.add(filename);
			}
			else
			{
				Console.WriteLine("Video Name: None");
				this.vlc_video.CtlVisible = false;
				this.vlc_video.Toolbar = false;
			}

		}
	}
}
