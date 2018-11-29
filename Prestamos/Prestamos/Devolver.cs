using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{
	public partial class Devolver : Form
	{
		private ArchEst archE;
		private ArchRec archR;
		public Devolver()
		{
			InitializeComponent();
			archE = new ArchEst("HistEstudiantes.dat");
			archR = new ArchRec("Inventario.dat");
		}
		void Label1Click(object sender, EventArgs e){}
		void Button1Click(object sender, EventArgs e)
		{
			if ( CI.Text != "" && Cod.Text !="")
			{	try
				{
					Recurso Ri =  archR.getrecurso(Int32.Parse(Cod.Text));
					if (!Ri.getEstadoR())
					{
						Mensaje.Text = "El recurso NO ha sido prestado";
					}
					else {
						Estudiante Ei = archE.getEstudante(Int32.Parse(CI.Text));
						if (Ei.devolverX(Ri.getCodR()))
						{ Mensaje.Text = "Se devolvió el Articulo";
							Ri.setEstado(false);
							archR.eliminar(Int32.Parse(Cod.Text));
							archR.addR(Ri);
							archE.eliminar(Int32.Parse(CI.Text));
							archE.addE(Ei);
							Close();
						}
						else{ Mensaje.Text = "El Estudiante no tiene el artículo";}
					}
				}
				catch (Exception)
				{
					Mensaje.Text = "Error, revise sus parámetros";
				}
			}
			
		}
	}
}
