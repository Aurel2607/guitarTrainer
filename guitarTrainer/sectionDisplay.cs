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

			this.SuspendLayout();

			foreach (string[] strTab in argList)
			{
				// Item Name
				Button btnFile = new Button();
				btnFile.Location = new System.Drawing.Point(20, 20 + offset);
				btnFile.Name = strTab[0];
				btnFile.Size = new System.Drawing.Size(100, 20);
				btnFile.Text = strTab[0];
				btnFile.UseVisualStyleBackColor = true;
				btnFile.Click += (sender, EventArgs) => { ButtonClick(sender, EventArgs, strTab); };
				this.Controls.Add(btnFile);

				offset += 20;
			}


			this.ResumeLayout(false);
		}

		private void ButtonClick(object sender, EventArgs e, string[] strTab)
		{
			itemFrm item = new itemFrm(strTab);
			item.Show();
		}

	}
}
