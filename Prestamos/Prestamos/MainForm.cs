using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Prestamos
{
	public partial class MainForm : Form
	{
		private ArchEst archE;
		private ArchRec archR;

		public MainForm()
		{
			InitializeComponent();
			archE = new ArchEst("HistEstudiantes.dat");
			archR = new ArchRec("Inventario.dat");
			listar();
		}
		
		void MainFormLoad(object sender, EventArgs e){}
		void Label1Click(object sender, EventArgs e){}
		void Label2Click(object sender, EventArgs e){}
		
		void Button1Click(object sender, EventArgs e)
		{
			Form AggInst = new AddRecursos();
			AggInst.FormClosed += new System.Windows.Forms.FormClosedEventHandler( FormClosed );
			AggInst.Show();
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form Prestar_i = new Prestar();
			Prestar_i.FormClosed += new System.Windows.Forms.FormClosedEventHandler( FormClosed );
			Prestar_i.Show();
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			Form Devolveri = new Devolver();
			Devolveri.FormClosed += new System.Windows.Forms.FormClosedEventHandler( FormClosed );
			Devolveri.Show();
		}

		void Button4Click(object sender, EventArgs e)
		{
			Form consulta = new QuienTieneY();
			consulta.Show();
		}

		void Button5Click(object sender, EventArgs e)
		{
			Form AddEst = new AddEst();
			AddEst.FormClosed += new System.Windows.Forms.FormClosedEventHandler( FormClosed );
			AddEst.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form consulta = new QueDebeX();
			consulta.FormClosed += new System.Windows.Forms.FormClosedEventHandler( FormClosed );
			consulta.Show();
	
		}
		
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e){}
		void GridEstudiantesCellContentClick(object sender, DataGridViewCellEventArgs e){}
		
		private void FormClosed( object sender, FormClosedEventArgs e ) {    
		   listar();
		}
		
		
		public void listar() {
            var estList = archE.listar();
            GridEstudiantes.Rows.Clear();
            foreach (Estudiante Ei in estList) {
                int n= GridEstudiantes.Rows.Add();
                GridEstudiantes.Rows[n].Cells[1].Value = Ei.getNombre();
                GridEstudiantes.Rows[n].Cells[0].Value = Ei.getCI();
            }
            var recList = archR.listar();
            GridDisponibles.Rows.Clear();
            GridPrestados.Rows.Clear(); 
            foreach (Recurso Ri in recList) {
            	if (Ri.getEstadoR())
            	{int n= GridPrestados.Rows.Add();
                GridPrestados.Rows[n].Cells[1].Value = Ri.getCodR();
                GridPrestados.Rows[n].Cells[0].Value = Ri.getNombreR();
                GridPrestados.Rows[n].Cells[2].Value = Ri.getCiPrest();
            	}
            	else
            	{int n= GridDisponibles.Rows.Add();
     			  	GridDisponibles.Rows[n].Cells[1].Value = Ri.getCodR();
                	GridDisponibles.Rows[n].Cells[0].Value = Ri.getNombreR();	
            	}
            }
            
        }
	}
}
