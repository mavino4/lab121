/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 10:30 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label Prestados;
		private System.Windows.Forms.Button AgregarR;
		private System.Windows.Forms.Button Prestar;
		private System.Windows.Forms.Button Devolver;
		private System.Windows.Forms.Button QuienTX;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AgregarEst;
		private System.Windows.Forms.Button QueTiX;
		private System.Windows.Forms.DataGridView GridPrestados;
		private System.Windows.Forms.DataGridView GridDisponibles;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
		private System.Windows.Forms.DataGridViewTextBoxColumn N;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridView GridEstudiantes;
		private System.Windows.Forms.DataGridViewTextBoxColumn CI;
		private System.Windows.Forms.DataGridViewTextBoxColumn NAMES;
		private System.Windows.Forms.DataGridViewTextBoxColumn Estudiante;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.Prestados = new System.Windows.Forms.Label();
			this.AgregarR = new System.Windows.Forms.Button();
			this.Prestar = new System.Windows.Forms.Button();
			this.Devolver = new System.Windows.Forms.Button();
			this.QuienTX = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.AgregarEst = new System.Windows.Forms.Button();
			this.QueTiX = new System.Windows.Forms.Button();
			this.GridDisponibles = new System.Windows.Forms.DataGridView();
			this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GridPrestados = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Estudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GridEstudiantes = new System.Windows.Forms.DataGridView();
			this.CI = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NAMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.GridDisponibles)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridPrestados)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Disponibles";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// Prestados
			// 
			this.Prestados.Location = new System.Drawing.Point(13, 198);
			this.Prestados.Name = "Prestados";
			this.Prestados.Size = new System.Drawing.Size(100, 23);
			this.Prestados.TabIndex = 2;
			this.Prestados.Text = "Prestados";
			this.Prestados.Click += new System.EventHandler(this.Label2Click);
			// 
			// AgregarR
			// 
			this.AgregarR.Location = new System.Drawing.Point(333, 78);
			this.AgregarR.Name = "AgregarR";
			this.AgregarR.Size = new System.Drawing.Size(70, 32);
			this.AgregarR.TabIndex = 6;
			this.AgregarR.Text = "Agregar";
			this.AgregarR.UseVisualStyleBackColor = true;
			this.AgregarR.Click += new System.EventHandler(this.Button1Click);
			// 
			// Prestar
			// 
			this.Prestar.Location = new System.Drawing.Point(333, 128);
			this.Prestar.Name = "Prestar";
			this.Prestar.Size = new System.Drawing.Size(70, 30);
			this.Prestar.TabIndex = 7;
			this.Prestar.Text = "Prestar";
			this.Prestar.UseVisualStyleBackColor = true;
			this.Prestar.Click += new System.EventHandler(this.Button2Click);
			// 
			// Devolver
			// 
			this.Devolver.Location = new System.Drawing.Point(73, 341);
			this.Devolver.Name = "Devolver";
			this.Devolver.Size = new System.Drawing.Size(75, 23);
			this.Devolver.TabIndex = 8;
			this.Devolver.Text = "Devolver";
			this.Devolver.UseVisualStyleBackColor = true;
			this.Devolver.Click += new System.EventHandler(this.Button3Click);
			// 
			// QuienTX
			// 
			this.QuienTX.Location = new System.Drawing.Point(221, 339);
			this.QuienTX.Name = "QuienTX";
			this.QuienTX.Size = new System.Drawing.Size(148, 26);
			this.QuienTX.TabIndex = 9;
			this.QuienTX.Text = "¿Quien tiene el recurso Y?";
			this.QuienTX.UseVisualStyleBackColor = true;
			this.QuienTX.Click += new System.EventHandler(this.Button4Click);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(106, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(179, 23);
			this.label2.TabIndex = 10;
			this.label2.Text = "Recursos";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(529, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(179, 23);
			this.label3.TabIndex = 11;
			this.label3.Text = "Estudiantes";
			// 
			// AgregarEst
			// 
			this.AgregarEst.Location = new System.Drawing.Point(765, 78);
			this.AgregarEst.Name = "AgregarEst";
			this.AgregarEst.Size = new System.Drawing.Size(70, 32);
			this.AgregarEst.TabIndex = 13;
			this.AgregarEst.Text = "Agregar";
			this.AgregarEst.UseVisualStyleBackColor = true;
			this.AgregarEst.Click += new System.EventHandler(this.Button5Click);
			// 
			// QueTiX
			// 
			this.QueTiX.Location = new System.Drawing.Point(765, 128);
			this.QueTiX.Name = "QueTiX";
			this.QueTiX.Size = new System.Drawing.Size(70, 75);
			this.QueTiX.TabIndex = 14;
			this.QueTiX.Text = "¿Qué tiene el estudiante X?";
			this.QueTiX.UseVisualStyleBackColor = true;
			this.QueTiX.Click += new System.EventHandler(this.Button6Click);
			// 
			// GridDisponibles
			// 
			this.GridDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridDisponibles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Nombre,
			this.N});
			this.GridDisponibles.Location = new System.Drawing.Point(13, 56);
			this.GridDisponibles.Name = "GridDisponibles";
			this.GridDisponibles.Size = new System.Drawing.Size(293, 129);
			this.GridDisponibles.TabIndex = 16;
			this.GridDisponibles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2CellContentClick);
			// 
			// Nombre
			// 
			this.Nombre.HeaderText = "RECURSO";
			this.Nombre.Name = "Nombre";
			this.Nombre.Width = 180;
			// 
			// N
			// 
			this.N.HeaderText = "CÓDIGO";
			this.N.Name = "N";
			this.N.Width = 70;
			// 
			// GridPrestados
			// 
			this.GridPrestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridPrestados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.Estudiante});
			this.GridPrestados.Location = new System.Drawing.Point(13, 224);
			this.GridPrestados.Name = "GridPrestados";
			this.GridPrestados.Size = new System.Drawing.Size(400, 102);
			this.GridPrestados.TabIndex = 17;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "RECURSO";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.Width = 180;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "CÓDIGO";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 70;
			// 
			// Estudiante
			// 
			this.Estudiante.HeaderText = "CI";
			this.Estudiante.Name = "Estudiante";
			// 
			// GridEstudiantes
			// 
			this.GridEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridEstudiantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.CI,
			this.NAMES});
			this.GridEstudiantes.Location = new System.Drawing.Point(435, 56);
			this.GridEstudiantes.Name = "GridEstudiantes";
			this.GridEstudiantes.Size = new System.Drawing.Size(324, 297);
			this.GridEstudiantes.TabIndex = 18;
			this.GridEstudiantes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridEstudiantesCellContentClick);
			// 
			// CI
			// 
			this.CI.HeaderText = "CI";
			this.CI.Name = "CI";
			// 
			// NAMES
			// 
			this.NAMES.HeaderText = "NOMBRE";
			this.NAMES.Name = "NAMES";
			this.NAMES.Width = 180;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(852, 383);
			this.Controls.Add(this.GridEstudiantes);
			this.Controls.Add(this.GridPrestados);
			this.Controls.Add(this.GridDisponibles);
			this.Controls.Add(this.QueTiX);
			this.Controls.Add(this.AgregarEst);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.QuienTX);
			this.Controls.Add(this.Devolver);
			this.Controls.Add(this.Prestar);
			this.Controls.Add(this.AgregarR);
			this.Controls.Add(this.Prestados);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "Prestamos";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.GridDisponibles)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridPrestados)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GridEstudiantes)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
