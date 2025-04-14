using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AbuBank.Gestori.GestioreUtente;
using AbuBank.Gestori.GestoreBanka;
using AbuBank.Gestori.GestoreStaff;

namespace AbuBank
{
    public partial class Form1 : Form
    {
        GestoreBanka bank;
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
            fillTransactionList();
        }

        private void start()
        {
            utente.start();
            staff.start();
        }

        private void fillUserList()
        {
            lUserList.Items.Clear();
            var utenti = utente.allUsers();

            foreach (var user in utenti)
            {
                ListViewItem item = new ListViewItem(user.Value.ID.ToString());
                item.SubItems.Add(user.Key._nome + " " + user.Key._cognome);
                item.SubItems.Add(bank.getSaldo(user.Value.ID).ToString());
                lUserList.Items.Add(item);
            }
        }

        private void fillTransactionList()
        {
            if (AdminsButton.Checked)
            {
                tTrans.Items.Clear();
                return;
            }

            tTrans.Items.Clear(); // Clear the tTrans listview
            List<Tuple<string, int, double, DateTime>> transactions = bank.GetAllTransactions();
            if (tAll.Checked)
            {
                foreach (var transaction in transactions)
                {
                    if (transaction.Item1 == "E0" || transaction.Item1 == "U0")
                    {
                        continue;
                    }


                    // Add transaction to tTrans listview
                    ListViewItem item = new ListViewItem(transaction.Item1);
                    item.SubItems.Add(transaction.Item2.ToString());
                    item.SubItems.Add(transaction.Item3.ToString());
                    item.SubItems.Add(transaction.Item4.ToString());
                    tTrans.Items.Add(item);
                }
            }
            else
            {
                int id;
                if (lUserList.CheckedItems.Count == 0) { return; }
                id = int.Parse(lUserList.CheckedItems[0].Text);
                foreach (var transaction in transactions)
                {
                    if (transaction.Item2 == id)
                    {


                        // Add transaction to tTrans listview
                        ListViewItem item = new ListViewItem(transaction.Item1);
                        item.SubItems.Add(transaction.Item2.ToString());
                        item.SubItems.Add(transaction.Item3.ToString());
                        item.SubItems.Add(transaction.Item4.ToString());
                        tTrans.Items.Add(item);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome;
            string cognome;
            DateTime born;
            string indirizzo;
            string citta;
            int cap;
            string telefono;
            string email;
            try
            {
                nome = gName.Text;
                cognome = gSurn.Text;
                born = gBorn.Value;
                indirizzo = gIndir.Text;
                citta = gCitt.Text;
                cap = int.Parse(gCap.Text);
                telefono = gTel.Text;
                email = gEmail.Text;

                if (!IsValidPhoneNumber(telefono))
                {
                    throw new Exception("Numero di telefono non valido");
                }

                if (!IsValidEmail(email))
                {
                    throw new Exception("Email non valida");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore nei campi: " + ex.Message);
                return;
            }

            User s = new User(nome, cognome, born, indirizzo, citta, cap, telefono, email);
            utente.CreateUser(s);
            fillUserList();
            bank = new GestoreBanka();

        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\d{10}$");
        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

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
            if (AdminsButton.Checked)
            {
                var staffs = staff.allStaff();
                lUserList.Items.Clear();
                foreach (var staff in staffs)
                {
                    ListViewItem item = new ListViewItem(staff.Value.type);
                    item.SubItems.Add(staff.Key._nome + " " + staff.Key._cognome);
                    item.SubItems.Add("N/A");
                    lUserList.Items.Add(item);
                }
            }
        }

        private void UsersButton_CheckedChanged(object sender, EventArgs e)
        {
            if (UsersButton.Checked)
            {
                fillUserList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }
            int id;
            if (lUserList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleziona un utente nella listbox accanto!!");
                return;
            }
            id = int.Parse(lUserList.CheckedItems[0].Text);

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

        private void Preleva_Click(object sender, EventArgs e)
        {
            if (AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }

            int id;
            if (lUserList.CheckedItems.Count == 0)
            {
                MessageBox.Show("Seleziona un utente nella listbox accanto!!");
                return;
            }
            id = int.Parse(lUserList.CheckedItems[0].Text);
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

        private void Transerisci_Click(object sender, EventArgs e)
        {
            if (AdminsButton.Checked)
            {
                MessageBox.Show("Non puoi modificare gli admin");
            }
            int da;
            int a;
            try
            {
                da = int.Parse(DaId.Text);
                a = int.Parse(AId.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Errore nei campi ID");
                return;
            }

            if (da == a)
            {
                MessageBox.Show("Non puoi trasferire a te stesso");
                return;
            }

            if (bank.Trasferisci(da, a, double.Parse(dAmount.Text)))
            {
                MessageBox.Show("Trasferimento effettuato");
                listboxreload(sender, e);
            }
            else
            {
                MessageBox.Show("Errore trasferimento");
            }

        }

        private void tAll_CheckedChanged(object sender, EventArgs e)
        {
            fillTransactionList();
        }

        private void Id_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillTransactionList();
        }


        private void lUserList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.NewValue == CheckState.Checked)
            {
                foreach (ListViewItem item in lUserList.Items)
                {
                    if (item != lUserList.Items[e.Index])
                    {
                        item.Checked = false;
                    }
                }
            }
            fillTransactionList();
        }

        private void lUserList_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            fillTransactionList();
        }
    }
}
