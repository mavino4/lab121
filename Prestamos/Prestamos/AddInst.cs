using System;
using System.Windows.Forms;

namespace Prestamos
{

	public partial class AddRecursos : Form
	{
		private ArchRec archR = new ArchRec("Inventario.dat");
		
		public AddRecursos()
		{
			InitializeComponent();
		}
		
		void Label2Click(object sender, EventArgs e){}
		void Label1Click(object sender, EventArgs e){}
		void Label3Click(object sender, EventArgs e){}
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				if(CodR.Text != "" && Nombre.Text !="")
				{
				var Ri = new Recurso(Int32.Parse(CodR.Text), Nombre.Text);
				archR.addR(Ri);
				Close();
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
