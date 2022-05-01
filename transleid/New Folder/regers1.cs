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
using System.Net.Mail;
using System.Net.Mime;
using helper;
namespace transleid
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class reges1 : Form
	{
		public reges1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			hp h = new hp();
			h.email(textBox2.Text,textBox3.Text);
		}
	}
}
