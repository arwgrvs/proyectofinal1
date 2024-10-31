/*
 * Created by SharpDevelop.
 * User: CC2_PC45
 * Date: 31/10/2024
 * Time: 06:59 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace proyecto
{
	/// <summary>
	/// Description of Portada.
	/// </summary>
	public partial class Portada : Form
	{
		public Portada()
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
			Form1 Form1 = new Form1();
			Form1.Show();
		}
	}
}
