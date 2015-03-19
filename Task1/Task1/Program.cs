using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Library1;


namespace Task1
{
	/// <summary>
	///the main class 
	/// </summary>

	internal class Program
	{


		/// <summary>
		///read with file
		/// </summary>
		/// <returns>read information from file </returns>
		public static string[] ReadWithFile()
		{

			int i = 0;
			string[] points = new string[3];
			string path = @"D:\out.txt";
			using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
			{
				string line;
				while ((line = sr.ReadLine()) != null)
				{
					points[i] = line;
					i++;
				}
			}
			return points;
		}

		/// <summary>
		///write in file
		/// </summary>
		public static void WriteInFile(string[] array)
		{
			string writePath = @"D:\in.txt";
			using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
			{
				for (int i = 0; i < array.Length; i++)
					sw.WriteLine(array[i]);
			}

		}

		/// <summary>
		///function selection between write data or file data
		/// </summary>
		/// <returns>your select </returns>
		public static int Or()
		{

			int road;
			Console.WriteLine("your choice 1-with File,0-input string");
			road = Convert.ToInt32(Console.ReadLine());
			return road;

		}

		/// <summary>
		///main function replacment date
		/// </summary>
		private static void Main(string[] args)
		{
			string[] mas = {"12.21,13.12", "43.5r4,65.54"};

			Float A = new Float();
			Float B = new Float();


			if (Or() == 0)
			{
				string[] buff = A.replacement(A.regex(mas));
				for (int i = 0; i < buff.Length; i++)
					Console.WriteLine(buff[i]);
			}
			else
			{
				string[] buff1 = A.replacement(A.regex(ReadWithFile()));
				WriteInFile(buff1);

			}


		}
	}

}