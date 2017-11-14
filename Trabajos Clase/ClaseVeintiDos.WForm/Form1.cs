using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseVeintiDos.Library;
using System.IO;

namespace ClaseVeintiDos.WForm
{
    public partial class Form1 : Form
    {
        private Calculadora _calculadora;
        

        public Form1()
        {
            InitializeComponent();
            this._calculadora = new Calculadora();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            foreach (Control i in this.panel1.Controls)
            {
                i.Click += new EventHandler(ManejadorClick);
            }       
        }

        public void ManejadorClick(object obj,EventArgs args)
        {
            if (this.panel1.Controls.Contains((Control)obj) && this._calculadora.terminado==false)
            {
                if (obj.Equals(btn0))
                {
                    this.txtDisplay.Text += "0";
                }
                else if (obj.Equals(btn1))
                {
                    this.txtDisplay.Text += "1";
                }
                else if (obj.Equals(btn2))
                {
                    this.txtDisplay.Text += "2";
                }
                else if (obj.Equals(btn3))
                {
                    this.txtDisplay.Text += "3";
                }
                else if (obj.Equals(btn4))
                {
                    this.txtDisplay.Text += "4";
                }
                else if (obj.Equals(btn5))
                {
                    this.txtDisplay.Text += "5";
                }
                else if (obj.Equals(btn6))
                {
                    this.txtDisplay.Text += "6";
                }
                else if (obj.Equals(btn7))
                {
                    this.txtDisplay.Text += "7";
                }
                else if (obj.Equals(btn8))
                {
                    this.txtDisplay.Text += "8";
                }
                else if (obj.Equals(btn9))
                {
                    this.txtDisplay.Text += "9";
                }

                this.btnLimpiar.Click += new EventHandler(ManejadorClick);

                foreach (Control i in this.panel2.Controls)
                {
                    i.Click -= new EventHandler(ManejadorClick);
                    i.Click += new EventHandler(ManejadorClick);
                }
 
            }
            else if (obj.Equals(btnLimpiar))
            {                               
                if (this._calculadora.terminado == true)
                {
                    foreach (Control i in this.panel1.Controls)
                    {
                        i.Click += new EventHandler(ManejadorClick);
                    }
                }
                this.txtDisplay.Clear();

                this._calculadora = new Calculadora();

                foreach (Control i in this.panel2.Controls)
                {
                    i.Click -= new EventHandler(ManejadorClick);
                }

                this.btnLimpiar.Click -= new EventHandler(ManejadorClick);
            }
            else if (panel2.Controls.Contains((Control)obj) && this._calculadora.terminado==false)
            {
                
                this._calculadora.primerNumero = double.Parse(txtDisplay.Text.ToString());
                this.txtDisplay.Clear();

                if(obj.Equals(btnMas))
                {
                    this.txtDisplay.Text += "+";
                }
                else if (obj.Equals(btnMenos))
                {
                    this.txtDisplay.Text += "-";
                }
                else if (obj.Equals(btnMultiplicar))
                {
                    this.txtDisplay.Text += "*";
                }
                else if (obj.Equals(btnDividir))
                {
                    this.txtDisplay.Text += "/";
                }

                this._calculadora.operador = this.txtDisplay.Text;

                foreach (Control i in this.panel2.Controls)
                {
                    i.Click -= new EventHandler(ManejadorClick);
                }

                this.btnResultado.Click += new EventHandler(ManejadorClick);

                this.txtDisplay.Clear();
            }
            else if (obj.Equals(this.btnResultado) && this._calculadora.terminado == false)
            {
                double.TryParse(this.txtDisplay.Text,out this._calculadora.segundoNumero);

                if (this._calculadora.operador == "+")
                {
                    DelOperaciones d = new DelOperaciones(this._calculadora.Sumar);
                    d.Invoke();
                    //this._calculadora.Sumar();
                    
                }
                else if (this._calculadora.operador == "-")
                {
                    this._calculadora.Restar();
                }
                else if (this._calculadora.operador == "*")
                {
                    this._calculadora.Multiplicar();
                }
                else if (this._calculadora.operador == "/")
                {
                    this._calculadora.Dividir();
                }

                foreach (Control i in this.panel1.Controls)
                {
                    i.Click -= new EventHandler(ManejadorClick);
                }

                this.txtDisplay.Text = this._calculadora.resultado.ToString();
                
                this.btnResultado.Click -= ManejadorClick;

                StreamWriter scritor = new StreamWriter("Resultados.txt",true);
                
                scritor.WriteLineAsync("Resultado: " + this._calculadora.resultado+" - Fecha: "+this._calculadora._horaCalculo+"\n");

                scritor.Close();

            }
            
        }

       
    }
}
