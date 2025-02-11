namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {

        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Personnage joueur = new Personnage();
            joueur.PuissanceAttaque = 1;
            joueur.PointsDeVie = 10;
            Personnage monstre = new Personnage();
            monstre.PuissanceAttaque = 3;
            monstre.PointsDeVie = 30;
        }

        private void lbl_pointsVieJoueur_Click(object sender, EventArgs e)
        {

        }
    }
}