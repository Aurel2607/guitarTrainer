using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace guitarTrainer
{
	class AppConfigParser
	{
		public static List<string[]> parse(string section)
		{
			string keyName = "";
			int keyIndex = 0;
			string sToParse = "";
			List<string[]> lstToReturn = new List<string[]>();

			// Parse AppConfig file
			while (sToParse != null)
			{
				// Construct KeyName
				keyName = section + keyIndex.ToString();

				// Find KeyName in appConfig file
				sToParse = ConfigurationManager.AppSettings.Get(keyName);
				if (sToParse == null)
					break;

				Console.WriteLine("KeyName: '" + keyName + "'");

				// Parse KeyName Value
				string[] keyNameValueSplit = sToParse.Split(',');
				lstToReturn.Add(keyNameValueSplit);

				keyIndex++;
			}
			return lstToReturn;
		}
	}

}
