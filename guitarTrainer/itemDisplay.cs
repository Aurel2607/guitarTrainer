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
	public partial class itemDisplay : Form
	{
		public itemDisplay(string titleName)
		{
			InitializeComponent();
			this.Text = titleName;
		}
	}
}
