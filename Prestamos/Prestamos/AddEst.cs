/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 11:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{
	/// <summary>
	/// Description of AddEst.
	/// </summary>
	public partial class AddEst : Form
	{
		
		ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public AddEst()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				if (CI.Text != "" && Nombre.Text != "")
				{
					var Ei = new Estudiante(Int32.Parse(CI.Text), Nombre.Text);
					archE.addE(Ei);
				}
				var Main = new MainForm();
				Main.listar();
				Main.Show();
				Close();
			}
			catch (Exception)
			{
				Alerta.Text = "C.I no valido, revise nuevamente";
			}
		}
	}
}
