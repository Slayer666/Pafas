using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pafas
{
    public partial class FormCalcular : Form
    {
        public FormCalcular(int puntos1,int puntos2,int puntos3,int puntos4,int totalPuntos,string extension, string abdominal, string circuitoAgilidad, string dosMilMetros, string edadP, string generoP, string especialidadP)
        {
            InitializeComponent();

            label11.Text = Convert.ToString(puntos1);
            label12.Text = Convert.ToString(puntos2);
            label13.Text = Convert.ToString(puntos3);
            label14.Text = Convert.ToString(puntos4);
            label7.Text = abdominal;
            label8.Text = extension;
            label9.Text = circuitoAgilidad;
            label10.Text = dosMilMetros;
            label16.Text = Convert.ToString(totalPuntos);



            switch (generoP+edadP)
            {
// Mujer
                case "Mujer" + "Mas de 52":

                    if ((totalPuntos >= 32) & (puntos1 >= 4) & (puntos2 >= 4) & (puntos3 >= 4) & (puntos4 >= 4))
                        label18.Text = "NFA";
                    else if ((totalPuntos >= 22) & (puntos1 >= 2) & (puntos2 >= 2) & (puntos3 >= 2) & (puntos4 >= 2) & (especialidadP == "OTRAS"))
                        label18.Text = "NFB";
                    else if ((totalPuntos >= 14) & (puntos1 >= 1) & (puntos2 >= 1) & (puntos3 >= 1) & (puntos4 >= 1) & (especialidadP == "OTRAS"))
                        label18.Text = "NFC";
                    else
                        label18.Text = "Sin nivel";
                    break;

                case "Mujer" + "De 44 a 51":

                    if ((totalPuntos >= 46) & (puntos1 >= 5) & (puntos2 >= 5) & (puntos3 >= 5) & (puntos4 >= 5))
                        label18.Text = "NFA";
                    else if ((totalPuntos >= 34) & (puntos1 >= 5) & (puntos2 >= 5) & (puntos3 >= 5) & (puntos4 >= 5) & (especialidadP == "OTRAS"))
                        label18.Text = "NFB";
                    else
                        label18.Text = "Sin nivel";

                    break;

                case "Mujer" + "De 36 a 43":
                    if ((totalPuntos >= 70) & (puntos1 >= 8) & (puntos2 >= 8) & (puntos3 >= 8) & (puntos4 >= 8))
                        label18.Text = "NFA";
                    else if ((totalPuntos >= 46) & (puntos1 >= 6) & (puntos2 >= 6) & (puntos3 >= 6) & (puntos4 >= 6) & (especialidadP == "OTRAS"))
                        label18.Text = "NFB";
                    else
                        label18.Text = "Sin nivel";

                    break;


                case "Mujer" + "Hasta 35":
                    if ((totalPuntos >= 82) & (puntos1 >= 10) & (puntos2 >= 10) & (puntos3 >= 10) & (puntos4 >= 10))
                        label18.Text = "NFA";
                    else if ((totalPuntos >= 58) & (puntos1 >= 7) & (puntos2 >= 7) & (puntos3 >= 7) & (puntos4 >= 7) & (especialidadP == "OTRAS"))
                        label18.Text = "NFB";
                    else
                        label18.Text = "Sin nivel";
                    break;

                
// Hombre
                    

                   case "Hombre" + "Mas de 52":
                            if ((totalPuntos >= 40) & (puntos1 >= 5) & (puntos2 >= 5) & (puntos3 >= 5) & (puntos4 >= 5))
                                label18.Text = "NFA";
                            else if ((totalPuntos >= 22) & (puntos1 >= 2) & (puntos2 >= 2) & (puntos3 >= 2) & (puntos4 >= 2) & (especialidadP == "OTRAS"))
                                label18.Text = "NFB";
                            else if ((totalPuntos >= 18) & (puntos1 >= 2) & (puntos2 >= 2) & (puntos3 >= 2) & (puntos4 >= 2) & (especialidadP == "OTRAS"))
                                label18.Text = "NFC";
                            else
                                label18.Text = "Sin nivel";
                            
                            break;

                    case "Hombre" + "De 44 a 51":
                            if ((totalPuntos >= 46) & (puntos1 >= 5) & (puntos2 >= 5) & (puntos3 >= 5) & (puntos4 >= 5))
                                label18.Text = "NFA";
                            else if ((totalPuntos >= 34) & (puntos1 >= 5) & (puntos2 >= 5) & (puntos3 >= 5) & (puntos4 >= 5) & (especialidadP == "OTRAS"))
                                label18.Text = "NFB";
                            else
                                label18.Text = "Sin nivel";

                            break;

                     case "Hombre" + "De 36 a 43":
                            if ((totalPuntos >= 80) & (puntos1 >= 10) & (puntos2 >= 10) & (puntos3 >= 10) & (puntos4 >= 10))
                                label18.Text = "NFA";
                            else if ((totalPuntos >= 60) & (puntos1 >= 8) & (puntos2 >= 8) & (puntos3 >= 8) & (puntos4 >= 8) & (especialidadP == "OTRAS"))
                                label18.Text = "NFB";
                            else
                                label18.Text = "Sin nivel";

                            break;

                      case "Hombre" + "Hasta 35":
                            
                            if ((totalPuntos >= 98) & (puntos1 >= 15) & (puntos2 >= 15) & (puntos3 >= 15) & (puntos4 >= 15))
                                label18.Text = "NFA";
                            else if ((totalPuntos >= 75) & (puntos1 >= 10) & (puntos2 >= 10) & (puntos3 >= 10) & (puntos4 >= 10) & (especialidadP == "OTRAS"))
                                label18.Text = "NFB";
                            else
                                label18.Text = "Sin nivel";
                            break;










            }


        }
        
    }
}
