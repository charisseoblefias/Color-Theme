/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 6/5/2021
 * Time: 3:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Color_Theme
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
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
		}
		void YellowRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.Yellow;
		}
		void RedRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.Red;
		}
		void WhiteRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Color.White;
		}
		void NormalRadioButtonCheckedChanged(object sender, EventArgs e)
		{
			this.BackColor = Control.DefaultBackColor;
		}
		void ExitbuttonClick(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
