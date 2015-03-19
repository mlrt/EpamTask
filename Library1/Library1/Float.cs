using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Library1
{
	/// <summary>
	//class coordinate
	/// </summary>
	public class Float
	{

		private string[] array;

		/// <summary>
		//function verifies the input data
		/// </summary>
		/// <returns>check out </returns>
		public string[] regex(string[] lines)
		{
			Regex regex = new Regex(@"\d+\.\d+\,\d+\.\d+");
			for (int i = 0; i < lines.Length; i++)
			{

				Match match = regex.Match(lines[i]);

				if (lines[i] == match.Value)
				{
					lines[i] = match.Value;
				}
				else
				{
					lines[i] = "Error";
				}
			}
			return lines;
		}

		/// <summary>
		//function replacment symbol
		/// </summary>
		/// <returns> replacement's string  </returns>
		public string[] replacement(string[] lines)
		{
			int len = lines.Length;
			array = new string[len];


			for (int i = 0; i < len; i++)
			{
				if (lines[i] == "Error")
				{
					array[i] = "Error inputs";
				}
				else
				{

					string[] word = lines[i].Split(new char[] {','});

					string X = "X: ";
					string Y = "Y: ";
					X += word[0];
					X = X.Replace(".", ",");
					Y += word[1];
					Y = Y.Replace(".", ",");
					string XandY = X + " " + Y;
					array[i] = XandY;
					X = null;
					Y = null;
					XandY = null;

				}

			}
			return array;

		}

	}

}






