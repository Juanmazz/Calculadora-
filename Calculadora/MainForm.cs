/*
 * Created by SharpDevelop.
 * User: LAB03
 * Date: 08/11/2021
 * Time: 19:51
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Calculadora
{
	
	
	public partial class MainForm : Form
	{
		double calculo;
		double calculo2;
		string operador;
		
		calculadora objcalculadora = new calculadora();
		
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Lbl_sumaClick(object sender, EventArgs e)
		{
	
			Button boton = (Button)sender;
			operador=boton.Text;
			calculo = Convert.ToDouble(txt_2.Text);
			txt_1.Text = Convert.ToString(calculo)+operador;
			txt_2.Text = "0";
		}
		void Lbl_0Click(object sender, EventArgs e)
		{
	
			Button boton = (Button)sender;
			if (txt_2.Text == "0") {
				
				txt_2.Text = " ";
				
			}
			
			txt_2.Text = txt_2.Text+boton.Text;
			
		}
		void Lbl_igualClick(object sender, EventArgs e)
		{
	
			calculo2 = Convert.ToDouble (txt_2.Text);
			switch (operador) {
				
				case "+":
					
					txt_2.Text = Convert.ToString(objcalculadora.suma(calculo, calculo2));
					
					break;
					
				case"-":
					
					txt_2.Text = Convert.ToString(objcalculadora.resta(calculo, calculo2));
					
					break;
				
				case"x":
					
					txt_2.Text = Convert.ToString(objcalculadora.multiplicacion(calculo, calculo2));
					
					break;
					
				case"/":
					
					txt_2.Text = Convert.ToString(objcalculadora.divison(calculo, calculo2));
					
					break;
					
			}
		}
	}
	
	class calculadora{
	
		public double suma(double num1, double num2){
		
			return (num1+num2);
			
		}
		
		public double resta(double num1, double num2){
		
			return (num1-num2);
			
		}
		
		public double multiplicacion(double num1, double num2){
		
			return (num1*num2);
			
		}
		
		public double divison(double num1, double num2){
		
			return (num1/num2);
			
		}
		
	}
}
