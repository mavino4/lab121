/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 10:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Prestamos
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		ArchEst archE;
		ArchRec archR;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			archE = new ArchEst("HistEstudiantes.dat");
			archR = new ArchRec("Inventario.dat");
			listar();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void MainFormLoad(object sender, EventArgs e)
		{
	
		}
		void Label1Click(object sender, EventArgs e)
		{
	
		}
		void Label2Click(object sender, EventArgs e)
		{
	
		}
		void Button1Click(object sender, EventArgs e)
		{
			Form AggInst = new AddRecursos();
			AggInst.Show();
	
		}
		void Button3Click(object sender, EventArgs e)
		{
			Form Devolveri = new Devolver();
			Devolveri.Show();
		}
		void Button6Click(object sender, EventArgs e)
		{
			Form consulta = new QueDebeX();
			consulta.Show();
	
		}
		void Button2Click(object sender, EventArgs e)
		{
			Form Prestar_i = new Prestar();
			Prestar_i.Show();
	
		}
		void Button5Click(object sender, EventArgs e)
		{
			Form AddEst = new AddEst();
			AddEst.Show();
			Hide();
		}
		void DataGridView2CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
	
		}
		
		void GridEstudiantesCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
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
		void Button7Click(object sender, EventArgs e)
		{
			listar();
		}
		void Button4Click(object sender, EventArgs e)
		{
			Form consulta = new QuienTieneY();
			consulta.Show();
		}
	}
}
