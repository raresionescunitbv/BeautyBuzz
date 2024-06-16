using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyBuzz
{
    public partial class Suport : UserControl
    {
        private string emailAddress;
        public Suport(string emailAddress)
        {
            InitializeComponent();
            this.emailAddress = emailAddress;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Niciodata nu a fost mai simplu sa-ti faci o programare la cel mai bun salon din zona ta.\r\n\r\n1. Acceseaza platforma BeautyBuzz, selecteaza daca esti interesat/a de servicii pentru femei sau barbati, apoi tipul de serviciu disponibil din lista (tuns/vopsit/pensat etc.). Optional, poti selecta data si ora in care iti doresti o programare. Cu un click pe butonul de “Cautare” vei avea acces instant la cele mai bune rezultate pentru tine. \r\n\r\n2. Alege salonul pe care il preferi, stilistul la care vrei sa mergi, iar apoi “Adauga serviciul” care te intereseaza. Confirma serviciul ales, data si ora prin butonul “Continuare”.\r\n\r\n3. Finalizeaza programarea completand numele si numarul tau de telefon sau, logandu-te in contul tau (cu parola/ prin Facebook). Daca nu ai un cont client, poti creea unul simplu si rapid fara sa parasesti pagina sau poti crea o programare fara a avea cont .Click pe “Confirmare” si programarea ta este gata!  (Daca ai facut o programare fara a-ti crea un cont, trebuie sa introduci numarul tau iar apoi vei primi un sms cu codul de confirmare).");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In functie de modalitatea in care ai facut o programare ai 2 posibilitati sa o anulezi.\r\n\r\n1. Am facut o programare din contul meu BeautyBuzz → Intra in contul tau si anuleaza oricand orice programare.\r\n\r\n2. Am facut o programare fara a crea un cont BeautyBuzz → In momentul in care ai confirmat programarea, ai primit prin sms un link. Acceseaza acel link pentru a anula programarea stabilita.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La finalizarea programarii îți poți selecta singur timpul cand iti vom reaminti prin SMS de programarea ta.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("In cazul in care un stilist ti-a anulat programarea, iti vom trimite un sms prin care te vom anunta acest lucru.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Desigur! Trebuie doar sa te asiguri ca in momentul finalizarii, completezi numarul de telefon a persoanei pentru care faci programarea. In cel mult 2 minute, noi ii vom trimite prietenului tau un cod pe care va trebui sa ti-l transmita. Odata ce ai aflat codul, introdu-l in pagina de confirmare a programarii si gata.\r\n\r\nDaca vei trece numarul tau atunci, tu vei primi acel cod pentru confirmare.");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (!string.IsNullOrEmpty(emailAddress))
            {
                UserControlCont detalii_Cont = new UserControlCont(emailAddress);
                this.Parent.Controls.Add(detalii_Cont);
                detalii_Cont.Show();
            }
            else
            {
                MessageBox.Show("Email address is not available.");
            }
        }
    }
}
