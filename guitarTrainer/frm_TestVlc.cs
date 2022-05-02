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
	public partial class frm_TestVlc : Form
	{
		int itemToPlay;
		string filename = "";

		public frm_TestVlc()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog1 = new OpenFileDialog();
			openFileDialog1.Filter = "( *.mp4) | *.mp4";
			if(openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				filename = "file:///" + @openFileDialog1.FileName;
				lbl_fileName.Text = "Playing File: " + filename;
				itemToPlay = axVLCPlugin21.playlist.add(filename);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			axVLCPlugin21.playlist.playItem(itemToPlay);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			axVLCPlugin21.playlist.stop();
		}

		private void button4_Click(object sender, EventArgs e)
		{
			axVLCPlugin21.playlist.togglePause();
		}
	}
}
