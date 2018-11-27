/*
 * Created by SharpDevelop.
 * User: VINO
 * Date: 27/11/2018
 * Time: 11:34 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Prestamos
{
	partial class Devolver
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CI;
		private System.Windows.Forms.TextBox Cod;
		private System.Windows.Forms.Label label2;
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
			this.Cod = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Mensaje = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(78, 137);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(132, 28);
			this.button1.TabIndex = 22;
			this.button1.Text = "Devolver";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(36, 97);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 17);
			this.label3.TabIndex = 21;
			this.label3.Text = "C.I.";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(36, 71);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 17);
			this.label1.TabIndex = 20;
			this.label1.Text = "Código";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// CI
			// 
			this.CI.Location = new System.Drawing.Point(94, 94);
			this.CI.Name = "CI";
			this.CI.Size = new System.Drawing.Size(151, 20);
			this.CI.TabIndex = 19;
			// 
			// Cod
			// 
			this.Cod.Location = new System.Drawing.Point(94, 68);
			this.Cod.Name = "Cod";
			this.Cod.Size = new System.Drawing.Size(151, 20);
			this.Cod.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Minion Pro", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(62, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(164, 32);
			this.label2.TabIndex = 17;
			this.label2.Text = "Devolver recurso";
			// 
			// Mensaje
			// 
			this.Mensaje.ForeColor = System.Drawing.SystemColors.Highlight;
			this.Mensaje.Location = new System.Drawing.Point(36, 118);
			this.Mensaje.Name = "Mensaje";
			this.Mensaje.Size = new System.Drawing.Size(209, 23);
			this.Mensaje.TabIndex = 23;
			// 
			// Devolver
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 194);
			this.Controls.Add(this.Mensaje);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.CI);
			this.Controls.Add(this.Cod);
			this.Controls.Add(this.label2);
			this.Name = "Devolver";
			this.Text = "Devolver";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
