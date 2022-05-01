/*
 * Created by SharpDevelop.
 * User: user
 * Date: 09.10.2019
 * Time: 21:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Text;
using helper;
using System.Diagnostics;
using System.Data;
namespace transleid
{
	/// <summary>
	/// Description of glavd.
	/// </summary>
	public partial class glavd : Form
	{
		hp h = new hp();
		string path = "sd/transleit.txt";
		DataGrid dtg = new DataGrid();
		public glavd()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			dtg.DataG();
			dataGridView1.DataSource = dtg.dataset1;
			dataGridView1.DataMember = dtg.dataset1.Tables["EngRusDet"].ToString();
		}
		void Button1Click(object sender, EventArgs e)
		{
			//eng[0]:rus[1]:det[2]
			int cover = 10;
			int special = 10;
			if (radioButton1.Checked == true)
			{
				cover = 0;
				special = 1;
			}
			if (radioButton2.Checked == true)
			{
				cover = 1;
				special = 0;
			}
			if (radioButton3.Checked == true)
			{
				cover = 2;
				special = 0;
			}
			if (radioButton4.Checked == true)
			{
				cover = 0;
				special = 2;
			}
			if (radioButton5.Checked == true)
			{
				cover = 2;
				special = 1;
			}
			if (radioButton6.Checked == true)
			{
				cover = 1;
				special = 2;
			}
			h.trans1(textBox5,textBox1, path, textBox1.Text, cover, special);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == openFileDialog1.ShowDialog())
			{
				textBox2.Text = openFileDialog1.FileName;
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			if (DialogResult.OK == openFileDialog2.ShowDialog())
			{
				textBox3.Text = "";
				for (int i = 0; i < openFileDialog2.FileNames.Length; i++) {
					textBox3.Text += openFileDialog2.FileNames[i] + Environment.NewLine;
				}
				
			}
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			//eng[0]:rus[1]:det[2]
			int cover = 10;
			int special = 10;
			if (radioButton1.Checked == true)
			{
				cover = 0;
				special = 1;
			}
			if (radioButton2.Checked == true)
			{
				cover = 1;
				special = 0;
			}
			if (radioButton3.Checked == true)
			{
				cover = 2;
				special = 0;
			}
			if (radioButton4.Checked == true)
			{
				cover = 0;
				special = 2;
			}
			if (radioButton5.Checked == true)
			{
				cover = 2;
				special = 1;
			}
			if (radioButton6.Checked == true)
			{
				cover = 1;
				special = 2;
			}
			h.trans1(textBox5,textBox4, path, textBox4.Text, cover, special);
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			if (textBox2.Text != "")
			{
				chek(textBox2, 0);
			}
			else
			{
				MessageBox.Show("Select File");
			}
			
		}
		
		void GlavdFormClosing(object sender, FormClosingEventArgs e)
		{
			dtg.dataset1.WriteXml("sd/member.xml");
			Application.Exit();
		}
		#region Ссылки
		void LinkLabel3LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://yougame.biz/members/233584/");
		}
		
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://lolzteam.net/members/433571/");
		}
		
		void LinkLabel2LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://vk.com/id526015177");
		}
		#endregion
		void Button7Click(object sender, EventArgs e)
		{
			if (textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "")
			{
				MessageBox.Show("Заполните все поля");
			}
			else
			{
				int cj = 0;
				int count = System.IO.File.ReadAllLines(path).Length;
				dtg.table1.Rows.Add(textBox6.Text.ToLower(), textBox7.Text.ToLower(), textBox8.Text.ToLower());
				string b = textBox7.Text.ToLower() + ":" + textBox6.Text.ToLower() + ":" + textBox8.Text.ToLower();
				foreach (string bs in File.ReadAllLines(path))
				{
					if (b != bs) cj++;
				}
				if (cj > 0)
				{
					string a = File.ReadAllText(path);
					File.WriteAllText(path, a + Environment.NewLine + b);
				}
			}
		}
		
		void GlavdLoad(object sender, EventArgs e)
		{
			cslov(path);
			foreach (string member in File.ReadAllLines(path))
			{
				var jf = member.Split(':');
				dtg.table1.Rows.Add(jf[1], jf[0], jf[2]);
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			if (textBox3.Text != "")
			{
				chek(textBox3, 1);
			}
			else
			{
				MessageBox.Show("Select File");
			}
			
		}
		#region чекер
		void chek(TextBox tx, int cn)
		{
			int crb= 10;
			if (radioButton1.Checked == true)
			{
				crb= 0;
			}
			if (radioButton2.Checked == true)
			{
				crb= 1;
			}
			if (radioButton3.Checked == true)
			{
				crb= 2;
			}
			if (radioButton4.Checked == true)
			{
				crb= 3;
			}
			if (radioButton5.Checked == true)
			{
				crb= 4;
			}
			if (radioButton6.Checked == true)
			{
				crb= 5;
			}
			
			
			if (cn == 0)
			{
				lx(tx.Text, crb);
			}
			else
			{
				lxy(tx.Text, crb);
			}
			
		}
		#endregion
		#region счетчик слов
		public void cslov(string path)
		{
			int s1 = 0;
			foreach (string a1 in File.ReadAllLines(path))
			{
				s1++;
			}
			label9.Text = "Слов eng: " + s1;
			label10.Text = "Слов rus: " + s1;
			label11.Text = "Слов det: " + s1;
			
		}
		#endregion
		#region чтение файла и его перевод
		
		void lx(string Path, int crb)
		{
			//проверить есть ли файл
			if (File.Exists(path))
			{
				//какой язык выбран
				switch (crb)
				{
					case 0:
						h.trans(Path, textBox5, 1, 0);
						break;
					case 1:
						h.trans(Path, textBox5, 0, 1);
						break;
					case 2:
						h.trans(Path,textBox5, 0, 2);
						break;
					case 3:
						h.trans(Path,textBox5, 2, 0);
						break;
					case 4:
						h.trans(Path,textBox5, 1, 2);
						break;
					case 5:
						h.trans(Path, textBox5, 2, 1);
						break;
						default: MessageBox.Show("Error"); break;
				}
			}
			else
			{
				MessageBox.Show("Error");
			}
		}
		
		#endregion
		#region чтение файлов и их перевод
		void lxy(string Path, int crb)
		{
			string[] jh = {textBox3.Text + ""};
			//проверить есть ли файл
			//какой язык выбран
			switch (crb)
			{
				case 0:
					h.transled(jh, textBox5, 1, 0);
					break;
				case 1:
					h.transled(jh, textBox5, 0, 1);
					break;
				case 2:
					h.transled(jh, textBox5, 0, 2);
					break;
				case 3:
					h.transled(jh, textBox5, 2, 0);
					break;
				case 4:
					h.transled(jh, textBox5, 1, 2);
					break;
				case 5:
					h.transled(jh, textBox5, 2, 1);
					break;
					default: MessageBox.Show("Error"); break;
			}
		}
		#endregion
		
		void ВыходToolStripMenuItemClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
		
		void СправкаToolStripMenuItemClick(object sender, EventArgs e)
		{
			helper.Spravka spr = new Spravka();
			spr.ShowDialog();
		}
	}
}
