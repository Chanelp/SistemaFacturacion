using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contolesusuario
{
    public partial class ErrorTxtBox : TextBox
    {
        public ErrorTxtBox()
        {
            InitializeComponent();
        }

        public Boolean Validar { get; set; }
        public Boolean SoloNumeros { get; set; }

        public static Boolean ValidarForm(Control Objeto, ErrorProvider ErrorP)
        {
            bool HayErrores = false;

            foreach(Control Item in Objeto.Controls)
            {
                if(Item is ErrorTxtBox)
                {
                    ErrorTxtBox Obj = (ErrorTxtBox)Item;

                    if(Obj.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Obj.Text.Trim()))
                        {
                            ErrorP.SetError(Obj, "No puede estar vacío");
                            HayErrores = true;
                        }
                    }
                    
                    if(Obj.SoloNumeros == true)
                    {
                        int cont = 0, LetrasEncontradas = 0;

                        foreach(char letra in Obj.Text.Trim())
                        {
                            if(char.IsLetter(Obj.Text.Trim(), cont))
                            {
                                LetrasEncontradas++;
                            }

                            cont++;
                        }

                        if(LetrasEncontradas != 0)
                        {
                            HayErrores = true;
                            ErrorP.SetError(Obj, "Solo números");
                        }
                    }
                }
            }

            return HayErrores;
        }


    }
}
