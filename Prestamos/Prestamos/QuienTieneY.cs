/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 04:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{
	/// <summary>
	/// Description of QuienTieneY.
	/// </summary>
	public partial class QuienTieneY : Form
	{
		ArchRec archR = new ArchRec("Inventario.dat");
		ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public QuienTieneY()
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
		void CerrarClick(object sender, EventArgs e)
		{
			Close();
		}
		void ConsultarClick(object sender, EventArgs e)
		{
			if (Cod.Text != "")
			{
				try
				{
					Recurso Ri = archR.getrecurso(Int32.Parse(Cod.Text));
					if (Ri.getEstadoR())
					{
						Estudiante Ei = archE.getEstudante(Ri.getCiPrest());
						Mensaje.Text = "REC:\t" + Ri.getNombreR() + "\n" + "EST:\t" +  Ei.getNombre() + "\n" +"CI:\t"+   Ei.getCI();
					}
					else
					{
						Mensaje.Text = "ACTUALMENTE DISPONIBLE";
					}
					
				}
				catch (Exception)
				{
					Mensaje.Text = "NO EXISTE";
				}
				
			}
		}
	}
}
