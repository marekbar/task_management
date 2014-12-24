using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskLibrary;

namespace TaskManager
{
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.adres = address.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano adresu bazy.";
            }
        }

        private void database_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.baza = database.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano nazwy bazy.";
            }
        }

        private void login_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.login = login.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano loginu do bazy.";
            }
        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.haslo = password.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano hasła do bazy.";
            }
        }

        private void userName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.imie_uzytkownika = userName.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano imienia użytkownika.";
            }
        }

        private void userSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.nazwisko_uzytkownika = userSurname.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano nazwiska użytkownika.";
            }
        }

        private void userLogin_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.login_uzytkownika = userLogin.Text;
                Properties.Settings.Default.Save();
            }
            catch
            {
                status.Text = "Nie zapisano loginu użytkownika.";
            }
        }

        private void testConnectionButton_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DB.Connect(address.Text, database.Text, login.Text, password.Text);
                var list = db.status_list.ToList();
                if (list.Count() >= 0)
                {
                    status.Text = "Nawiązano połączenie z bazą.";
                }
                else throw new Exception("");
            }
            catch (Exception)
            {
                status.Text = "Nie nawiązano połączenia z bazą.";
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            try
            {
                var db = DB.Connect(address.Text, database.Text, login.Text, password.Text);
                int total = db.users.Where(q => q.login == userLogin.Text).Count();
                if (total == 0)//create
                {                    
                    users usr = new users();
                    usr.login = userLogin.Text;
                    usr.name = userName.Text;
                    usr.surname = userSurname.Text;
                    db.users.Add(usr);
                    db.SaveChanges();
                }
                else if (total == 1)//update
                {
                    db.users.Where(q => q.login == userLogin.Text).First().name = userName.Text;
                    db.SaveChanges();
                    db.users.Where(q => q.login == userLogin.Text).First().surname = userSurname.Text;
                    db.SaveChanges();
                }
            }
            catch
            {
            }
            Close();
        }

        private void SettingsWindow_Load(object sender, EventArgs e)
        {
            var p = Properties.Settings.Default;
            address.Text = p.adres;
            database.Text = p.baza;
            login.Text = p.login;
            password.Text = p.haslo;
            userLogin.Text = p.login_uzytkownika;
            userName.Text = p.imie_uzytkownika;
            userSurname.Text = p.nazwisko_uzytkownika;
        }
    }
}
