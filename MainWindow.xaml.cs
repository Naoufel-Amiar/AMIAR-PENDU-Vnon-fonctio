using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace AMIAR_HangingMan_Game
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //variable binaire de conditions
        bool Lettre_dedans = false;
        bool gagne = false;
        bool perdu = false;
        bool continuer = false;
        //chaines de caractere
        string mot_devine = "";
        string mot_affiche = "";
        string Mot = "";
        string[] ListMot = { "PATATE", "OLIVE", "MUR", "VILLE", "ECRAN", "BOULETTE", "VOITURE", "CAMION", "PASTORALE", "LOURD", "INSTRUIT", "POLLEN", "GYMNASTE", "CAGES", "RAPIDE", "MOTEUR", };
        //definitions de random + valeur de depart de nb de vie
        Random random = new Random();
        int NB_Vie = 7;
        //def des variables pour le Launch
        int indexAleatoire;
        string MotAleatoire;
        string MotEtoile;
        string Lettre = "";

        //private DispatcherTimer dispatcherTimer;
        private TimeSpan tempsRestant = TimeSpan.FromMinutes(5); // Par exemple, 5 minutes

        int Pourcent_Vie = 0;

        public void Analyse()
        {//fonction qui analyse pour voir si la lettre proposé est dans le mot, !!!!!!! CA NE MARCHE PAS, ENLEVE UNE VIE MEME SI CEST LA BONNE LETTRE QUI EST PROPOSE
            for (int i = 0; i < mot_devine.Length; i++)
            {
                if (Lettre == mot_devine[i].ToString())
                {
                    Lettre_dedans = true;
                    TB_Display.Text = mot_affiche.Substring(0, i) + Lettre + mot_affiche.Substring(i + 1);
                }
            }
            if (Lettre_dedans == false)
            {
                NB_Vie -= 1;
                TB_Life.Text = NB_Vie.ToString();
            }
            Lettre_dedans = false;
        }

        public void Launch()
        {//fonction pour le lancement, choisi un mot dans la liste, affiche avec nb de * correspondant et remet nb de vie a 7 + affiche le mot relle (pour les test)
            NB_Vie = 7;
            indexAleatoire = random.Next(0, ListMot.Length);
            MotAleatoire = ListMot[indexAleatoire];
            MotEtoile = new string('*', MotAleatoire.Length);
            TB_Display.Text = MotEtoile;
            TB_Life.Text = NB_Vie.ToString();

        }

        public void Start()
        {//fonction pour verifier le nb de vie restant et coupet ou continuer le jeux en fonction du nb de vie restante

            for (int i = 0; i < Mot.Length; i++)
            {

                while (gagne == false && perdu == false)
                {
                    TB_Display.Text = MotEtoile;
                    if (NB_Vie == 0)
                    {
                        perdu = true;
                    }
                    if (mot_affiche == mot_devine)
                    {
                        gagne = true;
                    }
                }
                if (perdu == true)
                {
                    TB_Display.Text = mot_devine + ", vous avez perdu.";
                }
                if (gagne == true)
                {
                    TB_Display.Text = mot_devine + ", vous avez gagné.";
                }

            }
        }

        public MainWindow()
        {
            InitializeComponent();

            Launch();

        }

        private void TB_RESTART_Click(object sender, RoutedEventArgs e)
        {
            Launch();

        }

        private void TB_STOP_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }


        //JAI PAS ENCORE DECLARER TT LES BUTTON COTER .CS

        private void A_Click(object sender, RoutedEventArgs e)
        {
            Lettre = "A";
            Analyse();

        }

        private void B_Click(object sender, RoutedEventArgs e)
        {
            Lettre = "B";
            Analyse();

        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            Lettre = "C";
            Analyse();

        }

        private void D_Click(object sender, RoutedEventArgs e)
        {
            Lettre = "D";
            Analyse();
        }

        private void E_Click(object sender, RoutedEventArgs e)
        {

        }

        private void F_Click(object sender, RoutedEventArgs e)
        {

        }

        private void G_Click(object sender, RoutedEventArgs e)
        {

        }

        private void H_Click(object sender, RoutedEventArgs e)
        {

        }

        private void I_Click(object sender, RoutedEventArgs e)
        {

        }

        private void J_Click(object sender, RoutedEventArgs e)
        {

        }

        private void K_Click(object sender, RoutedEventArgs e)
        {

        }

        private void L_Click(object sender, RoutedEventArgs e)
        {

        }

        private void M_Click(object sender, RoutedEventArgs e)
        {

        }

        private void N_Click(object sender, RoutedEventArgs e)
        {

        }

        private void O_Click(object sender, RoutedEventArgs e)
        {

        }

        private void P_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Q_Click(object sender, RoutedEventArgs e)
        {

        }

        private void R_Click(object sender, RoutedEventArgs e)
        {

        }

        private void S_Click(object sender, RoutedEventArgs e)
        {

        }

        private void T_Click(object sender, RoutedEventArgs e)
        {

        }

        private void U_Click(object sender, RoutedEventArgs e)
        {

        }

        private void V_Click(object sender, RoutedEventArgs e)
        {

        }

        private void W_Click(object sender, RoutedEventArgs e)
        {

        }

        private void X_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Y_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Z_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}

