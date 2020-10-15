using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_de_Contador
{
    public partial class Contador : Form

    /*Realizar un programa en C# que maneje eventos, debe implementar 2 botones para que realice las siguientes acciones, 
     * cada que se presione el primer botón aparece un número nuevo en pantalla (generado de manera consecutiva) y cada que 
     * presione el segundo botón borre el último número generado. No puede borrar si ya no hay números, máximo va a generar 25 números.*/
    {
        Random rng = new Random();
        ArrayList cadena = new ArrayList();

        public void GenerarNum() {
            if (cadena.Count == 0)
            {
                cadena.Add(rng.Next(1,100));
                Imprimir();
            }
            else if (cadena.Count < 25) {
                cadena.Add((int)cadena[(cadena.Count-1)] + 1);
                Imprimir();
            }
        }

        public void RemoverNum() {
            if (cadena.Count > 0) {
                cadena.RemoveAt((cadena.Count-1));
                Imprimir();
            }
        }

        public void Imprimir() {
            if (cadena.Count > 0)
            {
                Displayeador.Text = cadena[(cadena.Count-1)].ToString();
            }
            else {
                Displayeador.Text = "La cadena esta vacia";
            }
        }

        public Contador()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            GenerarNum();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            RemoverNum();
        }
    }
}
