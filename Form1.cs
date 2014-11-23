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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        { /*Comprobación de datos de ComboBox si son correctos pasar a siguiente pantalla*/
            if ((edad.Text != "") && (genero.Text != "") && (especialidad.Text != "") && (extension.Text != "") && (abdominal.Text != "") && (circuitoAgilidad.Text != "") && (dosMilMetros.Text != ""))
            {
                int puntos1, puntos2, puntos3, puntos4, totalPuntos;
                puntos1 = puntos2 = puntos3 = puntos4 = totalPuntos = 0;

                string edadP = edad.Text;
                string generoP = genero.Text;
                string especialidadP = especialidad.Text;
                int extensionN = Int32.Parse(extension.Text);
                int abdominalN = Int32.Parse(abdominal.Text);
                string circuitoAgilidadP = circuitoAgilidad.Text;
                string dosMilMetrosP = dosMilMetros.Text;

                /* Puntos abdominales*/
                if (abdominalN == 70)
                    puntos1 = 40;
                else if (abdominalN == 69)
                    puntos1 = 39;
                else if (abdominalN == 68)
                    puntos1 = 38;
                else if (abdominalN == 67)
                    puntos1 = 37;
                else if (abdominalN == 66)
                    puntos1 = 36;
                else if (abdominalN == 65)
                    puntos1 = 35;
                else if (abdominalN == 64)
                    puntos1 = 34;
                else if (abdominalN == 63)
                    puntos1 = 33;
                else if (abdominalN == 62)
                    puntos1 = 32;
                else if (abdominalN == 61)
                    puntos1 = 31;
                else if (abdominalN == 60)
                    puntos1 = 30;
                else if (abdominalN == 59)
                    puntos1 = 29;
                else if (abdominalN == 58)
                    puntos1 = 28;
                else if (abdominalN == 57)
                    puntos1 = 27;
                else if (abdominalN == 56)
                    puntos1 = 26;
                else if (abdominalN == 55)
                    puntos1 = 25;
                else if (abdominalN == 54)
                    puntos1 = 24;
                else if (abdominalN == 53)
                    puntos1 = 23;
                else if (abdominalN == 52)
                    puntos1 = 22;
                else if (abdominalN == 51)
                    puntos1 = 21;
                else if (abdominalN == 50)
                    puntos1 = 20;
                else if (abdominalN == 49)
                    puntos1 = 19;
                else if (abdominalN == 47)
                    puntos1 = 18;
                else if (abdominalN == 45)
                    puntos1 = 17;
                else if (abdominalN == 43)
                    puntos1 = 16;
                else if (abdominalN == 41)
                    puntos1 = 15;
                else if (abdominalN == 39)
                    puntos1 = 14;
                else if (abdominalN == 37)
                    puntos1 = 13;
                else if (abdominalN == 35)
                    puntos1 = 12;
                else if (abdominalN == 33)
                    puntos1 = 11;
                else if (abdominalN == 31)
                    puntos1 = 10;
                else if (abdominalN == 29)
                    puntos1 = 9;
                else if (abdominalN == 27)
                    puntos1 = 8;
                else if (abdominalN == 25)
                    puntos1 = 7;
                else if (abdominalN == 23)
                    puntos1 = 6;
                else if (abdominalN == 21)
                    puntos1 = 5;
                else if (abdominalN == 19)
                    puntos1 = 4;
                else if (abdominalN == 17)
                    puntos1 = 3;
                else if (abdominalN == 15)
                    puntos1 = 2;
                else if (abdominalN == 13)
                    puntos1 = 1;

                /* Puntos extensiones*/
                if (extensionN == 40)
                    puntos2 = 40;
                else if (extensionN == 39)
                    puntos2 = 39;
                else if (extensionN == 38)
                    puntos2 = 38;
                else if (extensionN == 37)
                    puntos2 = 37;
                else if (extensionN == 36)
                    puntos2 = 36;
                else if (extensionN == 35)
                    puntos2 = 35;
                else if (extensionN == 34)
                    puntos2 = 34;
                else if (extensionN == 33)
                    puntos2 = 33;
                else if (extensionN == 32)
                    puntos2 = 32;
                else if (extensionN == 31)
                    puntos2 = 31;
                else if (extensionN == 30)
                    puntos2 = 30;
                else if (extensionN == 29)
                    puntos2 = 29;
                else if (extensionN == 28)
                    puntos2 = 28;
                else if (extensionN == 27)
                    puntos2 = 27;
                else if (extensionN == 26)
                    puntos2 = 26;
                else if (extensionN == 25)
                    puntos2 = 25;
                else if (extensionN == 24)
                    puntos2 = 24;
                else if (extensionN == 23)
                    puntos2 = 23;
                else if (extensionN == 22)
                    puntos2 = 22;
                else if (extensionN == 21)
                    puntos2 = 21;
                else if (extensionN == 20)
                    puntos2 = 20;
                else if (extensionN == 19)
                    puntos2 = 19;
                else if (extensionN == 18)
                    puntos2 = 18;
                else if (extensionN == 17)
                    puntos2 = 17;
                else if (extensionN == 16)
                    puntos2 = 16;
                else if (extensionN == 15)
                    puntos2 = 15;
                else if (extensionN == 14)
                    puntos2 = 14;
                else if (extensionN == 13)
                    puntos2 = 13;
                else if (extensionN == 12)
                    puntos2 = 12;
                else if (extensionN == 11)
                    puntos2 = 11;
                else if (extensionN == 10)
                    puntos2 = 10;
                else if (extensionN == 9)
                    puntos2 = 9;
                else if (extensionN == 8)
                    puntos2 = 8;
                else if (extensionN == 7)
                    puntos2 = 7;
                else if (extensionN == 6)
                    puntos2 = 6;
                else if (extensionN == 5)
                    puntos2 = 5;
                else if (extensionN == 4)
                    puntos2 = 4;
                else if (extensionN == 3)
                    puntos2 = 3;
                else if (extensionN == 2)
                    puntos2 = 2;
                else if (extensionN == 1)
                    puntos2 = 1;

                /* Puntos circuito Agilidad*/
                if (circuitoAgilidadP == "12.3")
                    puntos3 = 40;
                else if (circuitoAgilidadP == "12.4")
                    puntos3 = 39;
                else if (circuitoAgilidadP == "12.5")
                    puntos3 = 38;
                else if (circuitoAgilidadP == "12.6")
                    puntos3 = 37;
                else if (circuitoAgilidadP == "12.7")
                    puntos3 = 36;
                else if (circuitoAgilidadP == "12.8")
                    puntos3 = 35;
                else if (circuitoAgilidadP == "12.9")
                    puntos3 = 34;
                else if (circuitoAgilidadP == "13.0")
                    puntos3 = 33;
                else if (circuitoAgilidadP == "13.1")
                    puntos3 = 32;
                else if (circuitoAgilidadP == "13.2")
                    puntos3 = 31;
                else if (circuitoAgilidadP == "13.3")
                    puntos3 = 30;
                else if (circuitoAgilidadP == "13.4")
                    puntos3 = 29;
                else if (circuitoAgilidadP == "13.5")
                    puntos3 = 28;
                else if (circuitoAgilidadP == "13.7")
                    puntos3 = 27;
                else if (circuitoAgilidadP == "13.9")
                    puntos3 = 26;
                else if (circuitoAgilidadP == "14.1")
                    puntos3 = 25;
                else if (circuitoAgilidadP == "14.3")
                    puntos3 = 24;
                else if (circuitoAgilidadP == "14.5")
                    puntos3 = 23;
                else if (circuitoAgilidadP == "14.7")
                    puntos3 = 22;
                else if (circuitoAgilidadP == "14.9")
                    puntos3 = 21;
                else if (circuitoAgilidadP == "15.1")
                    puntos3 = 20;
                else if (circuitoAgilidadP == "15.3")
                    puntos3 = 19;
                else if (circuitoAgilidadP == "15.5")
                    puntos3 = 18;
                else if (circuitoAgilidadP == "15.7")
                    puntos3 = 17;
                else if (circuitoAgilidadP == "15.9")
                    puntos3 = 16;
                else if (circuitoAgilidadP == "16.1")
                    puntos3 = 15;
                else if (circuitoAgilidadP == "16.3")
                    puntos3 = 14;
                else if (circuitoAgilidadP == "16.6")
                    puntos3 = 13;
                else if (circuitoAgilidadP == "16.9")
                    puntos3 = 12;
                else if (circuitoAgilidadP == "17.2")
                    puntos3 = 11;
                else if (circuitoAgilidadP == "17.5")
                    puntos3 = 10;
                else if (circuitoAgilidadP == "17.8")
                    puntos3 = 9;
                else if (circuitoAgilidadP == "18.1")
                    puntos3 = 8;
                else if (circuitoAgilidadP == "18.3")
                    puntos3 = 7;
                else if (circuitoAgilidadP == "18.6")
                    puntos3 = 6;
                else if (circuitoAgilidadP == "18.9")
                    puntos3 = 5;
                else if (circuitoAgilidadP == "19.2")
                    puntos3 = 4;
                else if (circuitoAgilidadP == "19.5")
                    puntos3 = 3;
                else if (circuitoAgilidadP == "19.8")
                    puntos3 = 2;
                else if (circuitoAgilidadP == "20.1")
                    puntos3 = 1;

                /* Puntos 2000 Metros */
                if (dosMilMetrosP == "7.30")
                    puntos4 = 40;
                else if (dosMilMetrosP == "7.35")
                    puntos4 = 39;
                else if (dosMilMetrosP == "7.40")
                    puntos4 = 38;
                else if (dosMilMetrosP == "7.45")
                    puntos4 = 37;
                else if (dosMilMetrosP == "7.50")
                    puntos4 = 36;
                else if (dosMilMetrosP == "8.00")
                    puntos4 = 35;
                else if (dosMilMetrosP == "8.10")
                    puntos4 = 34;
                else if (dosMilMetrosP == "8.20")
                    puntos4 = 33;
                else if (dosMilMetrosP == "8.30")
                    puntos4 = 32;
                else if (dosMilMetrosP == "8.40")
                    puntos4 = 31;
                else if (dosMilMetrosP == "8.50")
                    puntos4 = 30;
                else if (dosMilMetrosP == "9.05")
                    puntos4 = 29;
                else if (dosMilMetrosP == "9.20")
                    puntos4 = 28;
                else if (dosMilMetrosP == "9.35")
                    puntos4 = 27;
                else if (dosMilMetrosP == "9.50")
                    puntos4 = 26;
                else if (dosMilMetrosP == "10.05")
                    puntos4 = 25;
                else if (dosMilMetrosP == "10.25")
                    puntos4 = 24;
                else if (dosMilMetrosP == "10.45")
                    puntos4 = 23;
                else if (dosMilMetrosP == "11.05")
                    puntos4 = 22;
                else if (dosMilMetrosP == "11.25")
                    puntos4 = 21;
                else if (dosMilMetrosP == "11.45")
                    puntos4 = 20;
                else if (dosMilMetrosP == "12.15")
                    puntos4 = 19;
                else if (dosMilMetrosP == "12.45")
                    puntos4 = 18;
                else if (dosMilMetrosP == "13.15")
                    puntos4 = 17;
                else if (dosMilMetrosP == "13.45")
                    puntos4 = 16;
                else if (dosMilMetrosP == "14.15")
                    puntos4 = 15;
                else if (dosMilMetrosP == "14.45")
                    puntos4 = 14;
                else if (dosMilMetrosP == "15.15")
                    puntos4 = 13;
                else if (dosMilMetrosP == "15.45")
                    puntos4 = 12;
                else if (dosMilMetrosP == "16.15")
                    puntos4 = 11;
                else if (dosMilMetrosP == "16.45")
                    puntos4 = 10;
                else if (dosMilMetrosP == "17.15")
                    puntos4 = 9;
                else if (dosMilMetrosP == "17.45")
                    puntos4 = 8;
                else if (dosMilMetrosP == "18.15")
                    puntos4 = 7;
                else if (dosMilMetrosP == "18.45")
                    puntos4 = 6;
                else if (dosMilMetrosP == "19.15")
                    puntos4 = 5;
                else if (dosMilMetrosP == "19.45")
                    puntos4 = 4;
                else if (dosMilMetrosP == "20.15")
                    puntos4 = 3;
                else if (dosMilMetrosP == "21.00")
                    puntos4 = 2;
                else if (dosMilMetrosP == "22.00")
                    puntos4 = 1;

               totalPuntos = puntos1 + puntos2 + puntos3 + puntos4; 
               
                
                FormCalcular FormCalcular = new FormCalcular(puntos1, puntos2, puntos3, puntos4, totalPuntos, extension.Text, abdominal.Text, circuitoAgilidad.Text, dosMilMetros.Text, edadP, generoP, especialidadP);
                FormCalcular.Show();
  
            }
            else
            {
                MessageBox.Show("No hay datos. Para calcular.");
            }
            

        }

        private void ayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("I.G. 60-28 (1º Rev.) 09/03/12"+ System.Environment.NewLine  + "ACADEMIA BÁSICA DEL AIRE" + System.Environment.NewLine + "GRUPO DE ENSEÑANZA"+System.Environment.NewLine +"Esdron. de Alumnos" +System.Environment.NewLine +"Dpto. de Deportes"+ System.Environment.NewLine  +"Satán");
        }

       

      
    }
}
