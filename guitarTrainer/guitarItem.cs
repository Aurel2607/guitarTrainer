using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitarTrainer
{
	public class guitarItem
	{
		string name { get; }
		string linkFile { get; }
		string linkAudio { get; }
		string linkVideo { get; }

		public guitarItem(string name, string linkFile, string linkAudio, string linkVideo)
		{
			this.name = name;
			this.linkFile = linkFile;
			this.linkAudio = linkAudio;
			this.linkVideo = linkVideo;
		}
	}
}
