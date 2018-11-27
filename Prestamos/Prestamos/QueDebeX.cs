using System;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{

	public partial class QueDebeX : Form
	{
		ArchRec archR = new ArchRec("Inventario.dat");
		ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public QueDebeX()
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
