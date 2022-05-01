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
using helper;
namespace transleid
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class reges2 : Form
	{
		
		string code;
		public reges2()
		{
			InitializeComponent();
		}
			
		void Button1Click(object sender, EventArgs e)
		{
			string s = textBox1.Text.ToLower();
			string mb = code.ToLower();
			if (textBox1.Text != "")
			{
				if (mb == s)
				{
					MessageBox.Show("Account register", "#001x301",MessageBoxButtons.OK, MessageBoxIcon.Information);
					Application.Restart();
				}
				else
				{
					MessageBox.Show("Invalid captca", "#001x301",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Enter the code", "#001x001",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		void Reges2Load(object sender, EventArgs e)
		{
			genMath();
		}
		#region автогенерация капчи
		public void genMath()
		{
			genCode();
		}
		string sfg = "";
		void genCode()
		{
			
			char[] symbol = new char[62] { 'A', 'B', 'C', 'D','E','F','G','H','I','J','K','L',
				'M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
				'a','b','c','d','e','f','g','h','i','j','k','l','m','n',
				'o','p','q','r','s','t','u','v','w','x','y','z','0','1','2','3','4','5','6','7','8','9'};
			Random rm = new Random();
			for (int i = 0; i <= 6; i++)
			{
				int g = rm.Next(0, 61);
				sfg += symbol[g].ToString();
			}
			risl(sfg);
			
		}
		public void risl(string Code)
		{
			code = Code;
			Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			Graphics gr = Graphics.FromImage(bm);
			Pen pn = new Pen(Color.Blue);
			pn.Color = Color.Blue;
			
			Random rx = new Random();
			Random ry = new Random();
			int x1 = rx.Next(0,155);
			int x2 = rx.Next(0,155);
			int y1 = ry.Next(0,50);
			int y2 = ry.Next(0,50);
			gr.DrawLine(pn, x1, y2, x2, y1);
			gr.DrawLine(pn, x1, y1, x2, y2);
			gr.DrawLine(pn, x2, y2, x1, y1);
			
			
			gr.DrawString(Code,new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
			  , new SolidBrush(Color.Black), 10,5);
			pictureBox1.Image = bm;
		}
		void rand()
		{
			
		}
		#endregion	
	}
}
