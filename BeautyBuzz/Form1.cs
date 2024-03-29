using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Twilio.Types;


namespace BeautyBuzz
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Visible = false;
            AddRequiredLabels();
      


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.BackColor = Color.Transparent;
            CreateAcName.BackColor = Color.Transparent;
            FirstNameCreateAc.BackColor = Color.Transparent;
            PhoneNumber.BackColor = Color.Transparent;
            Email.BackColor = Color.Transparent;
            Password.BackColor = Color.Transparent;
            showPass.BackColor = Color.Transparent;
            ConfirmPassword.BackColor = Color.Transparent;
            or.BackColor = Color.Transparent;

        }
        private void AddRequiredLabels()
        {
            Label[] requiredLabels = new Label[]
            {
            new Label
            {
                BackColor = Color.Transparent,
                Text = "*",
                ForeColor = Color.Red,
                Location = new Point(textCreateAc1.Location.X + textCreateAc1.Width + 5, textCreateAc1.Location.Y + 3),
                AutoSize = true
            },
            new Label
            {
                BackColor = Color.Transparent,
                Text = "*",
                ForeColor = Color.Red,
                Location = new Point(textBoxCreateAc2.Location.X + textBoxCreateAc2.Width + 5, textBoxCreateAc2.Location.Y + 3),
                AutoSize = true
            },
            new Label
            {
                BackColor = Color.Transparent,
                Text = "*",
                ForeColor = Color.Red,
                Location = new Point(or.Location.X + or.Width + 1, or.Location.Y + 1),
                AutoSize = true
            },
            new Label
            {BackColor = Color.Transparent,
                Text = "*",
                ForeColor = Color.Red,
                Location = new Point(textBox1.Location.X + textBox1.Width + 5, textBox1.Location.Y + 3),
                AutoSize = true
            },
            new Label
            {
                BackColor = Color.Transparent,
                Text = "*",
                ForeColor = Color.Red,
                Location = new Point(textBox2.Location.X + textBox2.Width + 5, textBox2.Location.Y + 3),
                AutoSize = true
            }
            };

            // Adăugăm etichetele în colecția de controale a formularului
            foreach (Label label in requiredLabels)
            {
                label.MouseHover += new EventHandler(requiredLabel_MouseHover);
                label.MouseLeave += new EventHandler(requiredLabel_MouseLeave);
                this.Controls.Add(label);
            }
        }
        private void requiredLabel_MouseHover(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.SetToolTip(label, "Required field");
            }
        }
        private void requiredLabel_MouseLeave(object sender, EventArgs e)
        {
            Label label = sender as Label;
            if (label != null)
            {
                ToolTip toolTip = new ToolTip();
                toolTip.Hide(label);
            }
        }

        private void ConvertFirstLetterToUpperCase(TextBox textBox, KeyEventArgs e)
        {
            if (char.IsLetter((char)e.KeyCode))
            {
                int selectionStart = textBox.SelectionStart;
                string currentText = textBox.Text;

                if (selectionStart == 0 || (selectionStart == 1 && char.IsLower(currentText[0])))
                {
                    string newText = char.ToUpper((char)e.KeyCode).ToString();

                    if (currentText.Length > 1)
                        newText += currentText.Substring(1);

                    textBox.Text = newText;
                    textBox.SelectionStart = 1;
                    textBox.SelectionLength = 0;
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void textCreateAc1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxCreateAc2.Focus();
                e.SuppressKeyPress = true;
            }
            else
            {
                ConvertFirstLetterToUpperCase(textCreateAc1, e);
            }
        }

        private void textBoxCreateAc2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox1.Focus();
                e.SuppressKeyPress = true;
            }
            else
            {
                ConvertFirstLetterToUpperCase(textBoxCreateAc2, e);
            }
        }
        private void CheckForDigits(TextBox textBox, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                MessageBox.Show("Denumirile proprii de persoane nu pot contine cifre!", "Eroare");
                e.Handled = true;
            }
        }
        private void textCreateAc1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForDigits(textCreateAc1, e);
        }
        private void textBoxCreateAc2_KeyPress(object sender, KeyPressEventArgs e)
        {
            CheckForDigits(textBoxCreateAc2, e);
        }






        private void checkBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                checkBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void checkBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxInput.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox1.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                showPass.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void showPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
                e.SuppressKeyPress = true;
            }
        }
        private void textBox2_KeyDown(Object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignUp.Focus();
                e.SuppressKeyPress = true;
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }


        private bool AreAllTextBoxesFilled()
        {
            // Verifică dacă toate textbox-urile sunt completate
            return !string.IsNullOrEmpty(textCreateAc1.Text) &&
                   !string.IsNullOrEmpty(textBoxCreateAc2.Text) &&
                   !string.IsNullOrEmpty(textBoxInput.Text) &&
                   !string.IsNullOrEmpty(textBox1.Text) &&
                   !string.IsNullOrEmpty(textBox2.Text);
        }
        private bool IsStrongPassword(string password)
        {
            if (password.Length < 6)
            {
                return false;
            }
            //Verificam prezenta unei litere mari
            bool containsUpperCase = password.Any(char.IsUpper);
            if (!containsUpperCase)
            {
                return false;
            }
            //Verificam prezenta unui caracter special 
            string specialCharacters = @"%!@#$%^&*()?/>.<,:;'\|}]{[_~`+=-" + "\"";
            bool containesSpecialCharacter = password.Any(specialCharacters.Contains);
            if (!containesSpecialCharacter)
            {
                return false;
            }
            return true;
        }

        int vCode = 1000;
        private void SignUp_Click(object sender, EventArgs e)
        {
            // Verificăm dacă toate câmpurile sunt completate
            if (!AreAllTextBoxesFilled())
            {
                MessageBox.Show("Toate câmpurile trebuie completate pentru a continua!", "Eroare");
                return;
            }

            string lastName = textCreateAc1.Text;
            string firstName = textBoxCreateAc2.Text;
            string contactInfo = "";

            if (checkBox1.Checked)
            {
                contactInfo = textBoxInput.Text;
            }
            else if (checkBox2.Checked)
            {
                contactInfo = textBoxInput.Text;
                if (!IsValidEmail(contactInfo))
                {
                    MessageBox.Show("Adresa de e-mail introdusă nu este validă!", "Eroare");
                    return;
                }
                /*else
                {
                    string verificationCode = GenerateVerificationCode();
                    SendVerificationCode(contactInfo, verificationCode);
                }*/

            }
            string password = textBox1.Text;
            string confirmPassword = textBox2.Text;
            string phoneNumber = textBoxInput.Text;

            // Verificam daca parolele coincid
            if (password != confirmPassword)
            {
                MessageBox.Show("Parolele nu coincid, încercați din nou", "Eroare");
                return;
            }
            //Verificam daca parola respecta criteriile de securitate
            if (!IsStrongPassword(password))
            {
                MessageBox.Show("Parola trebuie sa aiba minim 6 caractere, cel putin o litera de tipar si cel putin un caracter special", "Eroare");
                return;
            }

            // Verificam daca adresa de e-mail este validă
            if (checkBox2.Checked && !IsValidEmail(textBoxInput.Text))
            {
                MessageBox.Show("Adresa de e-mail introdusă nu este valida!", "Eroare");
                return;
            }

            // Daca totul este in ordine, afisam un mesaj de succes
            if (checkBox1.Checked)
            {
                SmsVerificationApp smsVerification = new SmsVerificationApp(lastName, firstName, phoneNumber,password, confirmPassword);
                smsVerification.ShowDialog();

                this.Hide();

            }
            else if (checkBox2.Checked)
            {
                VerificationMail verificationMail = new VerificationMail(lastName, firstName, password, contactInfo, confirmPassword);
                verificationMail.ShowDialog();

                this.Hide();
            }


        }


        // Functie pentru validarea formatului adresei de e-mail
        private bool IsValidEmail(string email)
        {
            // Verificam daca adresa de e-mail conține caractere valide și urmeaza un format corect
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.(com|ro)$");
        }


        /*private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
        }*/
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == checkBox1 && checkBox1.Checked)
            {
                checkBox2.Checked = false;
            }
            else if (sender == checkBox2 && checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
            if (checkBox1.Checked)
            {
                textBoxInput.Visible = true;
                textBoxInput.Clear();
                textBoxInput.Tag = "PhoneNumber";
            }
            else if (checkBox2.Checked)
            {
                textBoxInput.Visible = true;
                textBoxInput.Clear();
                textBoxInput.Tag = "Email";
            }
            else
            {
                textBoxInput.Visible = false;
            }


        }

        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBoxInput.Tag != null && textBoxInput.Tag.ToString() == "PhoneNumber")
            {
                // Verificam daca se apasa tasta Backspace pentru a permite stergerea
                if (e.KeyChar == '\b')
                {
                    return;
                }

                // Verificam daca caracterul introdus este o cifra și daca nu depaseste lungimea maxima
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) || textBoxInput.Text.Length >= 10)
                {
                    e.Handled = true; // Blocam introducerea caracterului
                }

                // Verificam dacă numarul incepe cu "07", iar primul caracter este "0"
                if (textBoxInput.Text.Length == 0 && e.KeyChar != '0')
                {
                    e.Handled = true; // Blocam introducerea caracterului
                }
                // Verificam dacă al doilea caracter este "7"
                else if (textBoxInput.Text.Length == 1 && e.KeyChar != '7')
                {
                    e.Handled = true; // Blocam introducerea caracterului
                }
                else if (textBoxInput.TextLength == 2 && e.KeyChar == '0')
                {
                    e.Handled = true;
                }//Verificam ca nu mai mult de 3 cifre sa fie identice in numarul de telefon
                else if (textBoxInput.TextLength >= 3)
                {
                    string lastThreeDigits = textBoxInput.Text.Substring(textBoxInput.Text.Length - 2); //luam ultimele 3 cifre
                    if (lastThreeDigits[0] == e.KeyChar && lastThreeDigits[1] == e.KeyChar)
                    {
                        e.Handled = true; //Blocam introducerea caracterului
                    }

                }

            }
            else if (textBoxInput.Tag != null && textBoxInput.Tag.ToString() == "Email")
            {
                // Validăm input-ul pentru adresa de e-mail
                ValidateEmail(e);
            }
        }
        private void ValidateEmail(KeyPressEventArgs e)
        {
            // Se verifică numai la introducerea caracterului "@" dacă adresa este validă sau nu
            if (e.KeyChar == '@' && textBoxInput.Text.Contains("@"))
            {
                string[] parts = textBoxInput.Text.Split('@');
                if (parts.Length != 2 || parts[1].Length == 0)
                {
                    e.Handled = true;
                }
            }
        }




        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            textBox1.PasswordChar = '•';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '•';
        }

        private void showPass_CheckedChanged(object sender, EventArgs e)
        {
            if (showPass.Checked)
            {
                textBox1.PasswordChar = '\0'; //indica faptul ca nu se foloseste niciun caracter de ascundere
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox1.PasswordChar = '•';
                textBox2.PasswordChar = '•';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BeautyBuzz back    = new BeautyBuzz();
            back.Show();
            this.Hide();
        }
    }
}