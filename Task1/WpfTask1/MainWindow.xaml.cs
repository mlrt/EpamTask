using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Library1;

namespace WpfTask1
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		/// <summary>
		///Ввод с файла
		/// </summary>
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
		///Button replace
		/// </summary>
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Float A = new Float();
			string[] buffin = ReadWithFile();
			for (int i = 0; i < buffin.Length; i++)
			{

				TextBox2.AppendText(buffin[i] + '\n');

			}

			string[] buffout = A.replacement(A.regex(ReadWithFile()));
			TextBox1.Clear();
			for (int i = 0; i < buffout.Length; i++)
			{

				TextBox1.AppendText(buffout[i] + '\n');

			}


		}

		/// <summary>
		///TextBox input data
		/// </summary>
		private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
		{

		}

		/// <summary>
		//TextBox output data
		/// </summary>
		private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
		{

		}
	}

}
