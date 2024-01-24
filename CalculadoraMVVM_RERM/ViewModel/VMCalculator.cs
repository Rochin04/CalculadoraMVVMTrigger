using CalculadoraMVVM_RERM.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace CalculadoraMVVM_RERM.ViewModel
{
    public class VMCalculator:ViewModelBase
    {
        #region Variables
        private string n1 = "";
        private string n2 = "";
        private string operador = "";
        private string mensaje = "";
        private bool activationButton;
        private string backgroundCOlor;
        private string textCOlor;
        #endregion
        #region Objetos
        public string TextCOlor
        {
            get { return textCOlor; }
            set { SetValue(ref textCOlor, value); }
        }
        public string BackgroundCOlor
        {
            get { return backgroundCOlor; }
            set { SetValue(ref backgroundCOlor, value); }
        }
        public bool ActivationButton
        {
            get { return activationButton; }
            set { SetValue(ref activationButton, value); }
        }
        public string N1
        {
            get { return n1; }
            set { SetValue(ref n1, value); }
        }
        public string N2
        {
            get { return n2; }
            set { SetValue(ref n2, value); }
        }
        public string Operador
        {
            get { return operador; }
            set { SetValue(ref operador, value); }
        }
        public string Mensaje
        {
            get { return mensaje; }
            set { SetValue(ref mensaje, value); }
        }
        #endregion
        #region Procesos
        private void ActualizarPantalla()
        {
           Mensaje = N1 + Operador + N2;
        }
        private void Btn_sumar()//object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                CalcularResultado();
            }
            operador = "+";
            ActualizarPantalla();
            //backgroundCOlor = "#ffffff";
            //textCOlor = "#000000";
        }

        private void Btn_restar()//object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                CalcularResultado();
            }
            operador += "-";
            ActualizarPantalla();
            //BackgroundCOlor = "#ffffff";
            //textCOlor = "#000000";
        }

        private void Btn_por()//object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                CalcularResultado();
            }
            operador += "x";
            ActualizarPantalla();
            //BackgroundCOlor = "#ffffff";
            //textCOlor = "#000000";
        }

        private void Btn_dividir()//object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                CalcularResultado();
            }
            operador += "÷";
            ActualizarPantalla();
            ActivationButton = true;
        }
        private void CalcularResultado()
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                double numero1 = double.Parse(n1);
                double numero2 = double.Parse(n2);
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;
                    case "÷":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Mensaje = "Error";
                            return;
                        }
                        break;
                }

                Mensaje = resultado.ToString();
                n1 = resultado.ToString();
                n2 = "";
                operador = "";
            }
        }
        private void Btn_AC()//object sender, EventArgs e)
        {
            n1 = "";
            n2 = "";
            operador = "";
            Mensaje = "0";
        }
        private void Num7()//object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void Num8()//object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void Num9()//object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        private void Num4()//object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void Num5()//object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void Num6()//object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void Num1()//object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void Num2()//object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void Num3()//object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void Num0()//object sender, EventArgs e)
        {

            AgregarNumero("0");
        }

        private void Click_point()//object sender, EventArgs e)//
        {
            if (!Mensaje.Contains("."))
            {
                Mensaje += ".";
                if (string.IsNullOrEmpty(operador))
                {
                    n1 += ".";
                }
                else
                {
                    n2 += ".";
                }
            }
        }

        private void AgregarNumero(string numero)
        {
            if (string.IsNullOrEmpty(operador))
            {
                n1 += numero;
            }
            else
            {
                n2 += numero;
            }

            ActualizarPantalla();
        }

        private void Btn_equals()//object sender, EventArgs e)//
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n1) && !string.IsNullOrEmpty(n2))
            {
                double numero1 = double.Parse(n1);
                double numero2 = double.Parse(n2);
                double resultado = 0;

                switch (operador)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "x":
                        resultado = numero1 * numero2;
                        break;
                    case "÷":
                        if (numero2 != 0)
                        {
                            resultado = numero1 / numero2;
                        }
                        else
                        {
                            Mensaje = "Error";
                            return;
                        }
                        break;
                }

                Mensaje = resultado.ToString();
                n1 = resultado.ToString();
                n2 = "";
                operador = "";
            }
        }
        private void Click_return()//object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(operador) && !string.IsNullOrEmpty(n2))
            {
                n2 = n2.Remove(n2.Length - 1);
            }
            else if (!string.IsNullOrEmpty(n1))
            {
                n1 = n1.Remove(n1.Length - 1);
            }

            ActualizarPantalla();
        }
        public void Selected()
        {
            
        }
        #endregion
        #region Comandos
        public ICommand ActualizarPantallaCommand => new Command(ActualizarPantalla);
        public ICommand SumarCommand => new Command(Btn_sumar);
        public ICommand RestarCommand => new Command(Btn_restar);
        public ICommand MultiplicarCommand => new Command(Btn_por);
        public ICommand DividirCommand => new Command(Btn_dividir);
        public ICommand LimpiarCommand => new Command(Btn_AC);
        public ICommand Num1Command => new Command(Num1);
        public ICommand Num2Command => new Command(Num2);
        public ICommand Num3Command => new Command(Num3);
        public ICommand Num4Command => new Command(Num4);
        public ICommand Num5Command => new Command(Num5);
        public ICommand Num6Command => new Command(Num6);
        public ICommand Num7Command => new Command(Num7);
        public ICommand Num8Command => new Command(Num8);
        public ICommand Num9Command => new Command(Num9);
        public ICommand Num0Command => new Command(Num0);
        public ICommand PointCommand => new Command(Click_point);
        public ICommand EqualsCommand => new Command(Btn_equals);
        public ICommand ReturnCommand => new Command(Click_return);
        #endregion
    }
}