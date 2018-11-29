using System;
using System.Windows.Forms;

namespace Prestamos
{
	public partial class QueDebeX : Form
	{
		private ArchRec archR = new ArchRec("Inventario.dat");
		private ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public QueDebeX()
		{
			InitializeComponent();
		}
		void Label2Click(object sender, EventArgs e){ }
		void ConsultarClick(object sender, EventArgs e)
		{
			if (Cod.Text != "")
			{
				try
				{
					Estudiante Ei = archE.getEstudante(Int32.Parse(Cod.Text));
					Nombre.Text = Ei.getNombre();
					var recList = archR.listar();
		            Grid.Rows.Clear();
		            foreach (Recurso Ri in recList) {
		            	if (Ri.getEstadoR() && Ri.getCiPrest() == Ei.getCI())
		            	{int n= Grid.Rows.Add();
		                Grid.Rows[n].Cells[1].Value = Ri.getCodR();
		                Grid.Rows[n].Cells[0].Value = Ri.getNombreR();
		            	}
		            }
				}
				catch (Exception)
				{
					Nombre.Text = "NO EXISTE";
				}
			}
		}
		
		void CerrarClick(object sender, EventArgs e)
		{
			Close();
		}
	}
}
