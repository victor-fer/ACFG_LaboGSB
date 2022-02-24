using ACFG_LaboGSB.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ACFG_LaboGSB
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly MyContext _context = new MyContext();

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Algo pour hasher le mdp
            string mdppropre = "sebaub273";
            Byte[] inputBytes = Encoding.UTF8.GetBytes(mdppropre);
            SHA512 shaM = new SHA512Managed();
            Byte[] hashedBytes = shaM.ComputeHash(inputBytes);
            string mdpHasher = Convert.ToBase64String(hashedBytes);

            string mdppropre2 = "sebaub273";
            using (SHA512 sha512Hash = SHA512.Create())
            {
                //From String to byte array
                byte[] sourceBytes = Encoding.UTF8.GetBytes(mdppropre2);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes);
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                Console.WriteLine("The SHA512 hash of " + mdppropre2 + " is: " + hash);
            }

            MessageBox.Show(hashedBytes.ToString());


            string mdpHasherSQL = "½BU*™Œ’.ÓÏÉJ—N¢~)ÚßÐÍÐgH¾žŸßo®AÂ2.'ô0nô7y¤z—˜mLÓcôíù";
            


            _context.Add(new Visiteur() { VIS_LOGIN = this.TextboxIdentifiant.Text , VIS_MDP = mdpHasher });
            _context.SaveChanges();


            Medicament Medicament = new Medicament();
            Medicament.ShowDialog();
        }

        private void TextboxIdentifiant_MouseEnter(object sender, MouseEventArgs e)
        {
            if (this.TextboxIdentifiant.Text == "Identifiant")
            {
                this.TextboxIdentifiant.Text = "";
            }
        }

        private void TextboxIdentifiant_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.TextboxIdentifiant.Text == "")
            {
                this.TextboxIdentifiant.Text = "Identifiant";
            }
        }

        private void TextboxIdentifiant_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxMdp_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextboxMdp_MouseEnter(object sender, MouseEventArgs e)
        {
            if (this.TextboxMdp.Text == "Mot de passe")
            {
                this.TextboxMdp.Text = "";
            }
        }

        private void TextboxMdp_MouseLeave(object sender, MouseEventArgs e)
        {
            if (this.TextboxMdp.Text == "")
            {
                this.TextboxMdp.Text = "Mot de passe";
            }
        }
    }
}
