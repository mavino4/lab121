using System;
using System.Windows.Forms;
namespace Prestamos
{
	public partial class Prestar : Form
	{
		private ArchEst archE;
		private ArchRec archR;
		public Prestar()
		{
			InitializeComponent();
			archE = new ArchEst("HistEstudiantes.dat");
			archR = new ArchRec("Inventario.dat");
		}
		void Label2Click(object sender, EventArgs e){}
		void Button1Click(object sender, EventArgs e)
		{
			if (fecha.Text != "" && CI.Text != "" && Cod.Text !="")
			try
			{
				Recurso Ri =  archR.getrecurso(Int32.Parse(Cod.Text));
				if (Ri.getEstadoR())
				{
					Mensaje.Text = "El recurso ya ha sido prestado";
				}
				else
				{
					Ri.setEstado(true);
					Estudiante Ei = archE.getEstudante(Int32.Parse(CI.Text));
					Ei.prestarX(Ri.getCodR());
					Ri.setCiPrest(Ei.getCI());
					archR.eliminar(Int32.Parse(Cod.Text));
					archR.addR(Ri);
					archE.eliminar(Int32.Parse(CI.Text));
					archE.addE(Ei);
					Close();					
				}
			}
			catch (Exception)
			{
				Mensaje.Text = "Error, revise sus parámetros";
			}			
		}
		void Label1Click(object sender, EventArgs e){}
		void TextBox1TextChanged(object sender, EventArgs e){}
	}
}
