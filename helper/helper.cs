/*
 * Created by SharpDevelop.
 * User: user
 * Date: 21.10.2019
 * Time: 10:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using transleid;
using System.Data;
namespace helper
{
	public partial class hp : UserControl
	{
		public hp()
		{
			InitializeComponent();
		}
		#region проверка всех файлов
		public static void start()
		{
			if (!Directory.Exists("sd"))
			{
				Directory.CreateDirectory("sd");
			}
			
			if (!File.Exists("sd/vemem.txt"))
			{
				File.Create("sd/vemem.txt");
			}
			if (!File.Exists("sd/transleit.txt"))
			{
				MessageBox.Show("Dictionary file not found.", "Critical error: #91x958",
				                MessageBoxButtons.OK,MessageBoxIcon.Error);
				Application.Exit();
			}
		}
		#endregion
		#region проверка кода подтверждения
		public void cod()
		{
			MessageBox.Show("The account is registered", "",MessageBoxButtons.OK, MessageBoxIcon.None);
			string s = File.ReadAllText("sd/vemem.txt");
			File.WriteAllText("sd/vemem.txt",Class1.login + "|" + Class1.password + "|" + Class1.email
			                  + Environment.NewLine + s);
			Application.Restart();
		}
		#endregion
		#region Авторизация в программе
		public void email(string st2, string st3)
		{
			if (st2 == ""|| st3 == "")
			{
				MessageBox.Show("Fill in all fields");
			}
			else
			{
				this.Hide();
				reges2 rg = new reges2();
				rg.ShowDialog();
			}
		}
		#endregion
		#region счетчик слов
		
		#endregion
		#region перевод №1
		public void trans1(TextBox textBox5,TextBox textBox1, string path,string inp, int cover, int a)
		{
			string input = inp.ToLower();
			string transleidYes = "";
			#region счетчик пробелов
			int count = 0;
			for( int i = 0; i < input.Length; i++ )
			{
				try
				{
					if( input[ i ] == ' ' )
						count++;
				}
				catch {}
			}
			count++;
			#endregion
			var ms = input.Split(' ');
			
			for(int i = 0; i<=count; i++)
			{
				try
				{
					foreach (string sdf in File.ReadAllLines(path, Encoding.UTF8))
					{
						#region распределение
						var vs = sdf.Split(':');
						if (ms[i] == vs[a])
						{
							transleidYes += vs[cover] + " ";
						}
						else
						{
							
						}
						#endregion
					}
				}
				catch {}
			}
			if (transleidYes != "")
			{
				textBox5.Text += transleidYes + Environment.NewLine + "--------------------"+ Environment.NewLine;
				if (File.Exists("sd/good.txt"))
				{
					string s = File.ReadAllText("sd/good.txt",Encoding.UTF8);
					File.WriteAllText("sd/good.txt",textBox5.Text + s);
				}
				else
				{
					File.WriteAllText("sd/good.txt",textBox5.Text);
				}
			}
			else
			{
				MessageBox.Show("Не знаю таких слов");
			}
			textBox1.Text = "";
			transleidYes = "";
			
		}
		#endregion
		#region чтение файла и его перевод
		public void trans(string Path, TextBox tx5, int i1, int i2)
		{
			string transleidYes = "";
			//Прочитать файл и разбить по строкам
			
			foreach (string str in File.ReadAllLines(Path))
			{
				//i1 поступление i2 на какой язык надо перевести
				#region счетчик пробелов в строке
				int count = 0;
				for( int i = 0; i < str.Length; i++ )
				{
					try
					{
						if( str[ i ] == ' ' )
							count++;
					}
					catch {}
				}
				count++;
				#endregion
				for (int i = 0; i < count; i++)
				{
					foreach (string sdr in File.ReadAllLines("sd/transleit.txt"))
					{
						try
						{
							var s = sdr.Split(':');
							var mg = str.Split(' ');
							if (mg[i]==s[i1])
							{
								transleidYes += s[i2] + " ";
							}
						} catch{}
						
					}
				}
				
			}
			if (transleidYes == "")
				MessageBox.Show("Мне не удалось перевести. :c");
			else
			{
				if (File.Exists("sd/good.txt"))
				{
					string s = File.ReadAllText("sd/good.txt",Encoding.UTF8);
					File.WriteAllText("sd/good.txt",tx5.Text + s);
				}
				else
				{
					File.WriteAllText("sd/good.txt",tx5.Text);
				}
				tx5.Text = transleidYes;
			}
		}
		#endregion
		#region чтение многих файлов и их перевод
		public void transled(string[] Path,TextBox tx5, int i1, int i2)
		{
			File.WriteAllLines("1", Path);
			foreach (string file in File.ReadAllLines("1"))
			{
				if (File.Exists(file))
				{
					string transleidYes = "";
					foreach (string str in File.ReadAllLines(file))
					{
						#region счетчик пробелов в строке
						int count = 0;
						for( int i = 0; i < str.Length; i++ )
						{
							try
							{
								if( str[ i ] == ' ' )
									count++;
							}
							catch {}
						}
						count++;
						#endregion
						for (int i = 0; i < count; i++)
						{
							foreach (string sdr in File.ReadAllLines("sd/transleit.txt"))
							{
								try
								{
									var s = sdr.Split(':');
									var mg = str.Split(' ');
									if (mg[i]==s[i1])
									{
										transleidYes += s[i2] + " ";
									}
								} catch{}
								
							}
						}
						
					}
					if (transleidYes == "")
						MessageBox.Show("Мне не удалось перевести. :c");
					else
					{
						tx5.Text += file + Environment.NewLine + "---------------------------------" + Environment.NewLine
							+ transleidYes + Environment.NewLine + "---------------------------------";
						if (File.Exists("sd/good.txt"))
						{
							string s = File.ReadAllText("sd/good.txt",Encoding.UTF8);
							File.WriteAllText("sd/good.txt",tx5.Text + s);
						}
						else
						{
							File.WriteAllText("sd/good.txt",tx5.Text);
						}						
					}
				}
				else
				{
					if (file != "")
					{
						MessageBox.Show("File no exists - " + file);
					}
				}
			}
		}
		#endregion
		
	}
}