using System;
using System.Windows.Forms;

namespace Prestamos
{
	public partial class QuienTieneY : Form
	{
		private ArchRec archR = new ArchRec("Inventario.dat");
		private ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public QuienTieneY()
		{
			InitializeComponent();
		}
		void Label2Click(object sender, EventArgs e){}
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
