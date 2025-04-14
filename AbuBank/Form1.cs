using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbuBank.Gestori.GestioreUtente;
using AbuBank.Gestori.GestioreUtente.Classi;
using AbuBank.Gestori.GestoreBanka;
using AbuBank.Gestori.GestoreStaff;

namespace AbuBank
{
    public partial class Form1 : Form
    {
        GestoreBanka bank ;
        GestoreUtente utente;
        GestoreStaff staff;

        Staff loggedUser = null;

        public Form1()
        {
            InitializeComponent();
            bank = new GestoreBanka();
            utente = new GestoreUtente();
            staff = new GestoreStaff();

            start();
            fillUserList();
        }

        private void start()
        {
            utente.start();
            staff.start();
        }

        private void fillUserList()
        {
            Id.Items.Clear();
            Nome.Items.Clear();
            Saldo.Items.Clear();
            var utenti = utente.allUsers();

            foreach ( var user in utenti )
            {
                Id.Items.Add(user.Value.ID);
                Nome.Items.Add(user.Key._nome + " " + user.Key._cognome);
                Saldo.Items.Add(bank.getSaldo(user.Value.ID));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = gName.Text;
            string cognome = gSurn.Text;
            DateTime born = gBorn.Value;
            string indirizzo = gIndir.Text;
            string citta = gCitt.Text;
            int cap = int.Parse(gCap.Text);
            string telefono = gTel.Text;
            string email = gEmail.Text;

            User s = new User(nome, cognome, born, indirizzo, citta, cap, telefono, email);
            utente.CreateUser(s);
            fillUserList();
            bank = new GestoreBanka();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = sName.Text;
            string cognome = sSurn.Text;
            DateTime born = sBorn.Value;
            string indirizzo = sIndir.Text;
            string citta = sCitt.Text;
            int cap = int.Parse(sCap.Text);
            string telefono = sTel.Text;
            string email = sEmail.Text;
            string type = sType.GetItemText(sType.SelectedItem);

            Staff s = new Staff(nome, cognome, born, indirizzo, citta, cap, telefono, email, type);
            string password = staff.CreateStaff(s);

            if (password != null)
            {
                MessageBox.Show("Password: " + password);
            }
            else
            {
                MessageBox.Show("Utente già esistente");
            }

            listboxreload(sender, e);

        }

        private void listboxreload(object sender, EventArgs e)
        {
            if (AdminsButton.Checked)
            {
                AdminsButton_CheckedChanged(sender, e);
            }
            else
            {
                UsersButton_CheckedChanged(sender, e);
            }
        }

        private void AdminsButton_CheckedChanged(object sender, EventArgs e)
        {
            if(AdminsButton.Checked)
            {
                var staffs = staff.allStaff();
                Id.Items.Clear();
                Nome.Items.Clear();
                Saldo.Items.Clear();
                foreach (var staff in staffs)
                {
                    Id.Items.Add(staff.Value.type);
                    Nome.Items.Add(staff.Key._nome + " " + staff.Key._cognome);
                    Saldo.Items.Add("N/A");
                }
            }
        }

        private void UsersButton_CheckedChanged(object sender, EventArgs e)
        {
            if(UsersButton.Checked)
            {
                fillUserList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }
            if(Id.SelectedItem != null)
            {
                int id = (int)Id.SelectedItem;
                if (bank.Deposita(id, double.Parse(Importo.Text)))
                {
                    MessageBox.Show("Deposito effettuato");
                    listboxreload(sender, e);
                }
                else
                {
                    MessageBox.Show("Errore deposito");
                }
            }
            else
            {
                MessageBox.Show("Seleziona un utente nella listbox accanto!!");
            }
        }

        private void Preleva_Click(object sender, EventArgs e)
        {
            if (AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }
            if (Id.SelectedItem != null)
            {
                int id = (int)Id.SelectedItem;
                if (bank.Preleva(id, double.Parse(Importo.Text)))
                {
                    MessageBox.Show("Prelievo effettuato");
                    listboxreload(sender, e);
                }
                else
                {
                    MessageBox.Show("Errore prelievo");
                }
            }
            else
            {
                MessageBox.Show("Seleziona un utente nella listbox accanto!!");
            }
        }

        private void Transerisci_Click(object sender, EventArgs e)
        {
            if(AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }
            int da;
            int a;
            try
            {
                da = int.Parse(DaId.Text);
                a = int.Parse(AId.Text);
            }catch(Exception)
            {
                MessageBox.Show("Errore nei campi ID");
                return;
            }

            if (da == a)
            {
                MessageBox.Show("Non puoi trasferire a te stesso");
                return;
            }

            if(bank.Trasferisci(da, a, double.Parse(dAmount.Text)))
            {
                MessageBox.Show("Trasferimento effettuato");
                listboxreload(sender, e);
            }
            else
            {
                MessageBox.Show("Errore trasferimento");
            }

        }
    }
}
