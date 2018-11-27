/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 11:40 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class Prestar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CI;
		private System.Windows.Forms.TextBox fecha;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Cod;
		private System.Windows.Forms.Label Mensaje;
		
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
			this.fecha = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.Cod = new System.Windows.Forms.TextBox();
			this.Mensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(75, 171);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 28);
			this.button1.TabIndex = 28;
			this.button1.Text = "Prestar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(39, 98);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 27;
			this.label3.Text = "C.I.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(39, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 26;
			this.label1.Text = "Fecha";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// CI
			// 
			this.CI.Location = new System.Drawing.Point(97, 95);
			this.CI.Name = "CI";
			this.CI.Size = new System.Drawing.Size(151, 20);
			this.CI.TabIndex = 25;
			// 
			// fecha
			// 
			this.fecha.Location = new System.Drawing.Point(97, 69);
			this.fecha.Name = "fecha";
			this.fecha.Size = new System.Drawing.Size(151, 20);
			this.fecha.TabIndex = 24;
			this.fecha.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(65, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 32);
			this.label2.TabIndex = 23;
			this.label2.Text = "Prestar recurso";
			this.label2.Click += new System.EventHandler(this.Label2Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(39, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 17);
			this.label4.TabIndex = 30;
			this.label4.Text = "Código";
			// 
			// Cod
			// 
			this.Cod.Location = new System.Drawing.Point(97, 121);
			this.Cod.Name = "Cod";
			this.Cod.Size = new System.Drawing.Size(151, 20);
			this.Cod.TabIndex = 29;
			// 
			// Mensaje
			// 
			this.Mensaje.ForeColor = System.Drawing.Color.Red;
			this.Mensaje.Location = new System.Drawing.Point(39, 150);
			this.Mensaje.Name = "Mensaje";
			this.Mensaje.Size = new System.Drawing.Size(209, 18);
			this.Mensaje.TabIndex = 31;
			// 
			// Prestar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 226);
			this.Controls.Add(this.Mensaje);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.Cod);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CI);
			this.Controls.Add(this.fecha);
			this.Controls.Add(this.label2);
			this.Name = "Prestar";
			this.Text = "Prestar";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
