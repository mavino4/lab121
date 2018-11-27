/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 04:46 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class QuienTieneY
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label Mensaje;
		private System.Windows.Forms.Button Consultar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Cod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button Cerrar;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.Mensaje = new System.Windows.Forms.Label();
			this.Consultar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Cod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Cerrar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Mensaje
			// 
			this.Mensaje.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Mensaje.Location = new System.Drawing.Point(36, 93);
			this.Mensaje.Name = "Mensaje";
			this.Mensaje.Size = new System.Drawing.Size(209, 45);
			this.Mensaje.TabIndex = 28;
			// 
			// Consultar
			// 
			this.Consultar.Location = new System.Drawing.Point(36, 151);
			this.Consultar.Name = "Consultar";
			this.Consultar.Size = new System.Drawing.Size(97, 28);
			this.Consultar.TabIndex = 27;
			this.Consultar.Text = "Consultar";
			this.Consultar.UseVisualStyleBackColor = true;
			this.Consultar.Click += new System.EventHandler(this.ConsultarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 63);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Código";
			// 
			// Cod
			// 
			this.Cod.Location = new System.Drawing.Point(94, 60);
			this.Cod.Name = "Cod";
			this.Cod.Size = new System.Drawing.Size(151, 20);
			this.Cod.TabIndex = 25;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(22, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 36);
			this.label2.TabIndex = 24;
			this.label2.Text = "¿Quien tiene el recurso Y?";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Cerrar
			// 
			this.Cerrar.Location = new System.Drawing.Point(148, 151);
			this.Cerrar.Name = "Cerrar";
			this.Cerrar.Size = new System.Drawing.Size(97, 28);
			this.Cerrar.TabIndex = 29;
			this.Cerrar.Text = "Cerrar";
			this.Cerrar.UseVisualStyleBackColor = true;
			this.Cerrar.Click += new System.EventHandler(this.CerrarClick);
			// 
			// QuienTieneY
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 219);
			this.Controls.Add(this.Cerrar);
			this.Controls.Add(this.Mensaje);
			this.Controls.Add(this.Consultar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Cod);
			this.Controls.Add(this.label2);
			this.Name = "QuienTieneY";
			this.Text = "QuienTieneY";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
