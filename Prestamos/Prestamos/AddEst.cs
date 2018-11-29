using System;
using System.Windows.Forms;

namespace Prestamos
{
	public partial class AddEst : Form
	{
		
		private ArchEst archE = new ArchEst("HistEstudiantes.dat");
		public AddEst()
		{
			InitializeComponent();
		}
		void Label2Click(object sender, EventArgs e){}
		void Button1Click(object sender, EventArgs e)
		{
			try
			{
				if (CI.Text != "" && Nombre.Text != "")
				{
					var Ei = new Estudiante(Int32.Parse(CI.Text), Nombre.Text);
					archE.addE(Ei);
				}
				Close();
			}
			catch (Exception)
			{
				Alerta.Text = "C.I no valido, revise nuevamente";
			}
		}
	}
}
