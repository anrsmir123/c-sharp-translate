/*
 * Created by SharpDevelop.
 * User: user
 * Date: 09.10.2019
 * Time: 21:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Web;
using helper;
using System.Threading;
namespace transleid
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			
			hp.start();
			if (File.Exists("sd/vx.cfg"))
			{
				string a = File.ReadAllText("sd/vx.cfg");
				var s = a.Split('|');
				textBox1.Text = s[0];
				textBox2.Text = s[1];
				checkBox1.Checked = true;
			}
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			input(textBox1,textBox2, checkBox1);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			reges1 rg = new reges1();
			rg.ShowDialog();
		}
		#region вход
		public void input(TextBox textBox1,TextBox textBox2, CheckBox checkBox1)
		{
			string s1 = textBox2.Text;
			if (checkBox1.Checked == true)
			{
				File.WriteAllText("sd/vx.cfg", textBox1.Text + "|" + s1);
			}
			int cont = 0;
			if (File.Exists("sd/vx.cfg"))
			{
				foreach (string str in File.ReadAllLines("sd/vx.cfg"))
				{
					try
					{
						//проверка на правильность пароля
						var m1 = str.Split('|');
						if (m1[0] == textBox1.Text||m1[1] == textBox2.Text)
						{
							this.Hide();
							glavd g = new glavd();
							g.ShowDialog();
							cont = 0;
						}
						else
						{
							cont++;
						}
					}
					catch(Exception ee)
					{
						MessageBox.Show(ee.ToString());
					}
				}
				if (cont > 0)
				{
					MessageBox.Show("Wrong login or password.", "#11x21", MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Error file.", "#01x001", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		#endregion
		
		void СправкаToolStripMenuItemClick(object sender, EventArgs e)
		{
			Spravka sp = new Spravka();
			sp.ShowDialog();
		}
	}
}
