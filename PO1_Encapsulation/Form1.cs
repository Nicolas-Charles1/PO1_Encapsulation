namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur;
        Personnage monstre;
        
        public Form1()

        {
            InitializeComponent();
           
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointsDeVie = monstre.PointsDeVie - joueur.PuissanceAttaque;
            joueur.PointsDeVie = joueur.PointsDeVie - monstre.PuissanceAttaque;
            Actualiseraffichage();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointsDeVie += 5;
            joueur.PointsDeVie = joueur.PointsDeVie - monstre.PuissanceAttaque;
            Actualiseraffichage();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PuissanceAttaque += 4;
            joueur.PointsDeVie = joueur.PointsDeVie - monstre.PuissanceAttaque;
            Actualiseraffichage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            joueur = new Personnage();
            joueur.PuissanceAttaque = 1;
            joueur.PointsDeVie = 10;
            monstre = new Personnage();
            monstre.PuissanceAttaque = 3;
            monstre.PointsDeVie = 30;

            lbl_pointsVieJoueur.Text = "Points de vie " + joueur.PointsDeVie;
            lbl_pointsVieDragon.Text = "Points de vie " + monstre.PointsDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Puissance attaque " + joueur.PuissanceAttaque;
            lbl_puissanceAttaqueDragon.Text = "Puissance attaque " + monstre.PuissanceAttaque;
        }

        private void lbl_pointsVieJoueur_Click(object sender, EventArgs e)
        {

        }
        private void Actualiseraffichage()
        {
            lbl_pointsVieJoueur.Text = "Points de vie " + joueur.PointsDeVie;
            lbl_pointsVieDragon.Text = "Points de vie " + monstre.PointsDeVie;
            lbl_puissanceAttaqueJoueur.Text = "Puissance attaque " + joueur.PuissanceAttaque;
            lbl_puissanceAttaqueDragon.Text = "Puissance attaque " + monstre.PuissanceAttaque;

            
        }
        
    }

}