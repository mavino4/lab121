/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 11:45 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class AddEst
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CI;
		private System.Windows.Forms.TextBox Nombre;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Alerta;
		
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
			this.button1 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.CI = new System.Windows.Forms.TextBox();
			this.Nombre = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Alerta = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(80, 132);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 28);
			this.button1.TabIndex = 28;
			this.button1.Text = "Agregar Estudiante";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(38, 92);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 27;
			this.label3.Text = "C.I.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 66);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Nombre";
			// 
			// CI
			// 
			this.CI.Location = new System.Drawing.Point(96, 89);
			this.CI.Name = "CI";
			this.CI.Size = new System.Drawing.Size(151, 20);
			this.CI.TabIndex = 25;
			// 
			// Nombre
			// 
			this.Nombre.Location = new System.Drawing.Point(96, 63);
			this.Nombre.Name = "Nombre";
			this.Nombre.Size = new System.Drawing.Size(151, 20);
			this.Nombre.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(63, 18);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(184, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "Agregar Estudiante";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// Alerta
			// 
			this.Alerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Alerta.ForeColor = System.Drawing.Color.Red;
			this.Alerta.Location = new System.Drawing.Point(96, 112);
			this.Alerta.Name = "Alerta";
			this.Alerta.Size = new System.Drawing.Size(151, 17);
			this.Alerta.TabIndex = 29;
			// 
			// AddEst
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 185);
			this.Controls.Add(this.Alerta);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CI);
			this.Controls.Add(this.Nombre);
			this.Controls.Add(this.label2);
			this.Name = "AddEst";
			this.Text = "AddEst";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
