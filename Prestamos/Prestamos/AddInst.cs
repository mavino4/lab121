/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 10:54 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{

	public partial class AddRecursos : Form
	{
		ArchRec archR = new ArchRec("Inventario.dat");
		
		public AddRecursos()
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
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label3Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				if(CodR.Text != "" && Nombre.Text !="")
				{
				var Ri = new Recurso(Int32.Parse(CodR.Text), Nombre.Text);
				archR.addR(Ri);
				Hide();
				}	
			}
			catch (Exception)
			{
				Alerta.Text = "Introduzca un código Válido";
				Console.WriteLine("Error al agregar el recurso");
			}
			
		}
	}
}
