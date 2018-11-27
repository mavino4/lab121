/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 05:04 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class QueDebeX
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button Cerrar;
		private System.Windows.Forms.Button Consultar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Cod;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Nombre;
		private System.Windows.Forms.DataGridView Grid;
		private System.Windows.Forms.DataGridViewTextBoxColumn Recurso;
		private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
		
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
			this.Cerrar = new System.Windows.Forms.Button();
			this.Consultar = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.Cod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Nombre = new System.Windows.Forms.Label();
			this.Grid = new System.Windows.Forms.DataGridView();
			this.Recurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
			this.SuspendLayout();
			// 
			// Cerrar
			// 
			this.Cerrar.Location = new System.Drawing.Point(156, 221);
			this.Cerrar.Name = "Cerrar";
			this.Cerrar.Size = new System.Drawing.Size(97, 28);
			this.Cerrar.TabIndex = 34;
			this.Cerrar.Text = "Cerrar";
			this.Cerrar.UseVisualStyleBackColor = true;
			this.Cerrar.Click += new System.EventHandler(this.CerrarClick);
			// 
			// Consultar
			// 
			this.Consultar.Location = new System.Drawing.Point(44, 221);
			this.Consultar.Name = "Consultar";
			this.Consultar.Size = new System.Drawing.Size(97, 28);
			this.Consultar.TabIndex = 33;
			this.Consultar.Text = "Consultar";
			this.Consultar.UseVisualStyleBackColor = true;
			this.Consultar.Click += new System.EventHandler(this.ConsultarClick);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 59);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(17, 15);
			this.label1.TabIndex = 32;
			this.label1.Text = "CI";
			// 
			// Cod
			// 
			this.Cod.Location = new System.Drawing.Point(35, 56);
			this.Cod.Name = "Cod";
			this.Cod.Size = new System.Drawing.Size(97, 20);
			this.Cod.TabIndex = 31;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 36);
			this.label2.TabIndex = 30;
			this.label2.Text = "¿Qué debe el estudiante X?";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(138, 56);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(116, 18);
			this.Nombre.TabIndex = 35;
			this.Nombre.Text = "Estudiante";
			this.Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Grid
			// 
			this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Recurso,
			this.Codigo});
			this.Grid.Location = new System.Drawing.Point(14, 82);
			this.Grid.Name = "Grid";
			this.Grid.Size = new System.Drawing.Size(258, 133);
			this.Grid.TabIndex = 36;
			// 
			// Recurso
			// 
			this.Recurso.HeaderText = "Recurso";
			this.Recurso.Name = "Recurso";
			// 
			// Codigo
			// 
			this.Codigo.HeaderText = "Codigo";
			this.Codigo.Name = "Codigo";
			// 
			// QueDebeX
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(292, 260);
			this.Controls.Add(this.Grid);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.Cerrar);
			this.Controls.Add(this.Consultar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Cod);
			this.Controls.Add(this.label2);
			this.Name = "QueDebeX";
			this.Text = "QueDebeX";
			((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
