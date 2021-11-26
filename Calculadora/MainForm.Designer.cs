/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 08/11/2021
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Calculadora
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button lbl_limpiar_todo;
		private System.Windows.Forms.Button lbl_limpiar;
		private System.Windows.Forms.Button lbl_borrar;
		private System.Windows.Forms.Button lbl_division;
		private System.Windows.Forms.Button lbl_7;
		private System.Windows.Forms.Button lbl_8;
		private System.Windows.Forms.Button lbl_9;
		private System.Windows.Forms.Button lbl_multiplicacion;
		private System.Windows.Forms.Button lbl_resta;
		private System.Windows.Forms.Button lbl_6;
		private System.Windows.Forms.Button lbl_5;
		private System.Windows.Forms.Button lbl_4;
		private System.Windows.Forms.Button lbl_1;
		private System.Windows.Forms.Button lbl_2;
		private System.Windows.Forms.Button lbl_3;
		private System.Windows.Forms.Button lbl_suma;
		private System.Windows.Forms.Button lbl_igual;
		private System.Windows.Forms.Button lbl_0;
		private System.Windows.Forms.TextBox txt_2;
		private System.Windows.Forms.TextBox txt_1;
		
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
			this.lbl_limpiar_todo = new System.Windows.Forms.Button();
			this.lbl_limpiar = new System.Windows.Forms.Button();
			this.lbl_borrar = new System.Windows.Forms.Button();
			this.lbl_division = new System.Windows.Forms.Button();
			this.lbl_7 = new System.Windows.Forms.Button();
			this.lbl_8 = new System.Windows.Forms.Button();
			this.lbl_9 = new System.Windows.Forms.Button();
			this.lbl_multiplicacion = new System.Windows.Forms.Button();
			this.lbl_resta = new System.Windows.Forms.Button();
			this.lbl_6 = new System.Windows.Forms.Button();
			this.lbl_5 = new System.Windows.Forms.Button();
			this.lbl_4 = new System.Windows.Forms.Button();
			this.lbl_1 = new System.Windows.Forms.Button();
			this.lbl_2 = new System.Windows.Forms.Button();
			this.lbl_3 = new System.Windows.Forms.Button();
			this.lbl_suma = new System.Windows.Forms.Button();
			this.lbl_igual = new System.Windows.Forms.Button();
			this.lbl_0 = new System.Windows.Forms.Button();
			this.txt_2 = new System.Windows.Forms.TextBox();
			this.txt_1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lbl_limpiar_todo
			// 
			this.lbl_limpiar_todo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_limpiar_todo.Location = new System.Drawing.Point(12, 127);
			this.lbl_limpiar_todo.Name = "lbl_limpiar_todo";
			this.lbl_limpiar_todo.Size = new System.Drawing.Size(65, 75);
			this.lbl_limpiar_todo.TabIndex = 18;
			this.lbl_limpiar_todo.Text = "CE";
			this.lbl_limpiar_todo.UseVisualStyleBackColor = true;
			// 
			// lbl_limpiar
			// 
			this.lbl_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_limpiar.Location = new System.Drawing.Point(83, 127);
			this.lbl_limpiar.Name = "lbl_limpiar";
			this.lbl_limpiar.Size = new System.Drawing.Size(65, 75);
			this.lbl_limpiar.TabIndex = 19;
			this.lbl_limpiar.Text = "C";
			this.lbl_limpiar.UseVisualStyleBackColor = true;
			// 
			// lbl_borrar
			// 
			this.lbl_borrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
			this.lbl_borrar.Location = new System.Drawing.Point(154, 127);
			this.lbl_borrar.Name = "lbl_borrar";
			this.lbl_borrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lbl_borrar.Size = new System.Drawing.Size(65, 75);
			this.lbl_borrar.TabIndex = 20;
			this.lbl_borrar.Text = "←";
			this.lbl_borrar.UseVisualStyleBackColor = true;
			// 
			// lbl_division
			// 
			this.lbl_division.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_division.Location = new System.Drawing.Point(225, 127);
			this.lbl_division.Name = "lbl_division";
			this.lbl_division.Size = new System.Drawing.Size(65, 75);
			this.lbl_division.TabIndex = 21;
			this.lbl_division.Text = "/";
			this.lbl_division.UseVisualStyleBackColor = true;
			this.lbl_division.Click += new System.EventHandler(this.Lbl_sumaClick);
			// 
			// lbl_7
			// 
			this.lbl_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_7.Location = new System.Drawing.Point(12, 208);
			this.lbl_7.Name = "lbl_7";
			this.lbl_7.Size = new System.Drawing.Size(65, 75);
			this.lbl_7.TabIndex = 22;
			this.lbl_7.Text = "7";
			this.lbl_7.UseVisualStyleBackColor = true;
			this.lbl_7.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_8
			// 
			this.lbl_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_8.Location = new System.Drawing.Point(83, 208);
			this.lbl_8.Name = "lbl_8";
			this.lbl_8.Size = new System.Drawing.Size(65, 75);
			this.lbl_8.TabIndex = 23;
			this.lbl_8.Text = "8";
			this.lbl_8.UseVisualStyleBackColor = true;
			this.lbl_8.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_9
			// 
			this.lbl_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_9.Location = new System.Drawing.Point(154, 208);
			this.lbl_9.Name = "lbl_9";
			this.lbl_9.Size = new System.Drawing.Size(65, 75);
			this.lbl_9.TabIndex = 24;
			this.lbl_9.Text = "9";
			this.lbl_9.UseVisualStyleBackColor = true;
			this.lbl_9.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_multiplicacion
			// 
			this.lbl_multiplicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_multiplicacion.Location = new System.Drawing.Point(225, 208);
			this.lbl_multiplicacion.Name = "lbl_multiplicacion";
			this.lbl_multiplicacion.Size = new System.Drawing.Size(65, 75);
			this.lbl_multiplicacion.TabIndex = 25;
			this.lbl_multiplicacion.Text = "x";
			this.lbl_multiplicacion.UseVisualStyleBackColor = true;
			this.lbl_multiplicacion.Click += new System.EventHandler(this.Lbl_sumaClick);
			// 
			// lbl_resta
			// 
			this.lbl_resta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_resta.Location = new System.Drawing.Point(226, 289);
			this.lbl_resta.Name = "lbl_resta";
			this.lbl_resta.Size = new System.Drawing.Size(65, 75);
			this.lbl_resta.TabIndex = 26;
			this.lbl_resta.Text = "-";
			this.lbl_resta.UseVisualStyleBackColor = true;
			this.lbl_resta.Click += new System.EventHandler(this.Lbl_sumaClick);
			// 
			// lbl_6
			// 
			this.lbl_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_6.Location = new System.Drawing.Point(154, 289);
			this.lbl_6.Name = "lbl_6";
			this.lbl_6.Size = new System.Drawing.Size(65, 75);
			this.lbl_6.TabIndex = 27;
			this.lbl_6.Text = "6";
			this.lbl_6.UseVisualStyleBackColor = true;
			this.lbl_6.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_5
			// 
			this.lbl_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_5.Location = new System.Drawing.Point(83, 289);
			this.lbl_5.Name = "lbl_5";
			this.lbl_5.Size = new System.Drawing.Size(65, 75);
			this.lbl_5.TabIndex = 28;
			this.lbl_5.Text = "5";
			this.lbl_5.UseVisualStyleBackColor = true;
			this.lbl_5.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_4
			// 
			this.lbl_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_4.Location = new System.Drawing.Point(12, 289);
			this.lbl_4.Name = "lbl_4";
			this.lbl_4.Size = new System.Drawing.Size(65, 75);
			this.lbl_4.TabIndex = 29;
			this.lbl_4.Text = "4";
			this.lbl_4.UseVisualStyleBackColor = true;
			this.lbl_4.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_1
			// 
			this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_1.Location = new System.Drawing.Point(12, 370);
			this.lbl_1.Name = "lbl_1";
			this.lbl_1.Size = new System.Drawing.Size(65, 75);
			this.lbl_1.TabIndex = 30;
			this.lbl_1.Text = "1";
			this.lbl_1.UseVisualStyleBackColor = true;
			this.lbl_1.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_2
			// 
			this.lbl_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_2.Location = new System.Drawing.Point(83, 370);
			this.lbl_2.Name = "lbl_2";
			this.lbl_2.Size = new System.Drawing.Size(65, 75);
			this.lbl_2.TabIndex = 31;
			this.lbl_2.Text = "2";
			this.lbl_2.UseVisualStyleBackColor = true;
			this.lbl_2.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_3
			// 
			this.lbl_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_3.Location = new System.Drawing.Point(154, 370);
			this.lbl_3.Name = "lbl_3";
			this.lbl_3.Size = new System.Drawing.Size(65, 75);
			this.lbl_3.TabIndex = 32;
			this.lbl_3.Text = "3";
			this.lbl_3.UseVisualStyleBackColor = true;
			this.lbl_3.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// lbl_suma
			// 
			this.lbl_suma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_suma.Location = new System.Drawing.Point(226, 370);
			this.lbl_suma.Name = "lbl_suma";
			this.lbl_suma.Size = new System.Drawing.Size(65, 75);
			this.lbl_suma.TabIndex = 33;
			this.lbl_suma.Text = "+";
			this.lbl_suma.UseVisualStyleBackColor = true;
			this.lbl_suma.Click += new System.EventHandler(this.Lbl_sumaClick);
			// 
			// lbl_igual
			// 
			this.lbl_igual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_igual.Location = new System.Drawing.Point(154, 451);
			this.lbl_igual.Name = "lbl_igual";
			this.lbl_igual.Size = new System.Drawing.Size(65, 75);
			this.lbl_igual.TabIndex = 37;
			this.lbl_igual.Text = "=";
			this.lbl_igual.UseVisualStyleBackColor = true;
			this.lbl_igual.Click += new System.EventHandler(this.Lbl_igualClick);
			// 
			// lbl_0
			// 
			this.lbl_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
			this.lbl_0.Location = new System.Drawing.Point(83, 451);
			this.lbl_0.Name = "lbl_0";
			this.lbl_0.Size = new System.Drawing.Size(65, 75);
			this.lbl_0.TabIndex = 35;
			this.lbl_0.Text = "0";
			this.lbl_0.UseVisualStyleBackColor = true;
			this.lbl_0.Click += new System.EventHandler(this.Lbl_0Click);
			// 
			// txt_2
			// 
			this.txt_2.Location = new System.Drawing.Point(12, 12);
			this.txt_2.Multiline = true;
			this.txt_2.Name = "txt_2";
			this.txt_2.ReadOnly = true;
			this.txt_2.Size = new System.Drawing.Size(279, 49);
			this.txt_2.TabIndex = 38;
			// 
			// txt_1
			// 
			this.txt_1.Location = new System.Drawing.Point(12, 80);
			this.txt_1.Name = "txt_1";
			this.txt_1.ReadOnly = true;
			this.txt_1.Size = new System.Drawing.Size(278, 20);
			this.txt_1.TabIndex = 39;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(303, 539);
			this.Controls.Add(this.txt_1);
			this.Controls.Add(this.txt_2);
			this.Controls.Add(this.lbl_igual);
			this.Controls.Add(this.lbl_0);
			this.Controls.Add(this.lbl_suma);
			this.Controls.Add(this.lbl_3);
			this.Controls.Add(this.lbl_2);
			this.Controls.Add(this.lbl_1);
			this.Controls.Add(this.lbl_4);
			this.Controls.Add(this.lbl_5);
			this.Controls.Add(this.lbl_6);
			this.Controls.Add(this.lbl_resta);
			this.Controls.Add(this.lbl_multiplicacion);
			this.Controls.Add(this.lbl_9);
			this.Controls.Add(this.lbl_8);
			this.Controls.Add(this.lbl_7);
			this.Controls.Add(this.lbl_division);
			this.Controls.Add(this.lbl_borrar);
			this.Controls.Add(this.lbl_limpiar);
			this.Controls.Add(this.lbl_limpiar_todo);
			this.Name = "MainForm";
			this.Text = "Calculadora";
			this.Click += new System.EventHandler(this.Lbl_0Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
