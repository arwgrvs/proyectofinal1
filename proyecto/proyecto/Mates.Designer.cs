﻿/*
 * Created by SharpDevelop.
 * User: CC2_PC43
 * Date: 24/10/2024
 * Time: 04:22 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace proyecto
{
	partial class Mates
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.btnp = new System.Windows.Forms.Button();
			this.btnc = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 142);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(97, 31);
			this.button1.TabIndex = 7;
			this.button1.Text = "Moda y Mediana";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// btnp
			// 
			this.btnp.Location = new System.Drawing.Point(263, 52);
			this.btnp.Name = "btnp";
			this.btnp.Size = new System.Drawing.Size(96, 36);
			this.btnp.TabIndex = 6;
			this.btnp.Text = "Promedio";
			this.btnp.UseVisualStyleBackColor = true;
			this.btnp.Click += new System.EventHandler(this.BtnpClick);
			// 
			// btnc
			// 
			this.btnc.Location = new System.Drawing.Point(12, 52);
			this.btnc.Name = "btnc";
			this.btnc.Size = new System.Drawing.Size(97, 36);
			this.btnc.TabIndex = 5;
			this.btnc.Text = "Calificaciones";
			this.btnc.UseVisualStyleBackColor = true;
			this.btnc.Click += new System.EventHandler(this.BtncClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(133, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 24);
			this.label1.TabIndex = 4;
			this.label1.Text = "Menu";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Mates
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 332);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnp);
			this.Controls.Add(this.btnc);
			this.Controls.Add(this.label1);
			this.Name = "Mates";
			this.Text = "Mates";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnc;
		private System.Windows.Forms.Button btnp;
		private System.Windows.Forms.Button button1;
	}
}
