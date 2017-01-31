using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class Program
	{
		static void Main(string[] args)
		{
			string[,] EcranDeJeux = new string[10, 10];
			int i, j;
		string prenomSaisi = "";
			string personnageSaisi = "";
			int choixMenu=0;
			int choixMenu2=0;
			int comptMauvaiseSaisie = 0;
			string univers = "";
			int age;int nombreDeMauvaiseSaisie=0;
			string verificationSaisi;			

			Console.ForegroundColor = ConsoleColor.Cyan;Console.WriteLine("Combien il(s) y à t'il(s) de joueur(s)?"); Console.ResetColor();
			int nombrDeJoueur = Convert.ToInt32( Console.ReadLine());
			int indice = 0;
			Personne saisieUser = new Personne();//Ne sert qu'a appeller les fonctions de la classe Personne
			while (indice < nombrDeJoueur)
			{
				Console.WriteLine("Bonjour comment tu t'appelles");
				prenomSaisi = Console.ReadLine();
				Personne prenom = new Personne();
				prenom.PrenomPersonne = prenomSaisi;

				while (personnageSaisi != "humain" && personnageSaisi != "robot")
				{
					if (nombreDeMauvaiseSaisie > 0)
					{
						Console.Clear();
					}
					Console.WriteLine("tu es un humain ou un robot");
					personnageSaisi = Console.ReadLine();
					verificationSaisi = saisieUser.humainOuRobot(personnageSaisi);
					if (personnageSaisi != verificationSaisi)
					{
						Console.WriteLine("Tu ne peux choisir que humain ou robot car ils sont en private");
						Console.ReadLine();
					}
					nombreDeMauvaiseSaisie++;
				}
				indice++;
			}
			Console.Clear();
			Console.WriteLine(prenomSaisi);
			Console.WriteLine("---Bienvenue dans le didactitiel---");
			Console.WriteLine("1:Aller en cuisine");
			Console.WriteLine("2:Choisir son animal de compagnie");
			Console.WriteLine("3:Le jour ou la nuit");
			choixMenu=Convert.ToInt32(Console.ReadLine());
			switch(choixMenu)
			{
				case 1:
					while (choixMenu2 != 1 && choixMenu2 != 2 && choixMenu2 != 3 && choixMenu2 != 4)
					{
						if (comptMauvaiseSaisie == 0)
						{					
							Function.afficherLeMenuDuRepas();
						}
						else
						{
							Console.WriteLine();
							Console.WriteLine("                                  _    _    _      _  ");
							Console.WriteLine("Vous ne pouvez Choisir que entre |1|, |2|, |3| ou |4|.");
							Console.WriteLine("                                  _    _    _      _  ");
							Console.WriteLine("Appuyer sur une touche pour saisir de nouveaux votre choix!!!");
							Console.ReadLine();
							Console.Clear();
							Function.afficherLeMenuDuRepas();
						}
						choixMenu2 = Convert.ToInt32(Console.ReadLine());
						comptMauvaiseSaisie++;
					}
					Legume.queVaTonManger(choixMenu2);				
					break;
				case 2:
					Animaux tonAnimal = new Animaux(prenomSaisi, personnageSaisi);
					tonAnimal.NomAnimaux = "Lion";
					tonAnimal.CaractereAnimaux = "Sauvage";
					tonAnimal.creerAnimal();
					break;
				case 3:
					Animaux tonelement = new Animaux(prenomSaisi, personnageSaisi);
					tonelement.NomAnimaux = "appel";
					tonelement.CaractereAnimaux = "appel";
					break;
				
			}
			//Console.WriteLine("wesh wesh va y donne ton âge");
			//age = Convert.ToInt32(Console.ReadLine());
			//Personne toi = new Personne(prenom,personnage,age);
			//Console.WriteLine(toi.PrenomPersonne+" tu n'es pas gros par harsard et tu n'es pas un "+toi.NomPersonnage+" gros Bétâ.");
			//Console.WriteLine("Whats tu as "+age+" ans, c'est noel tu gagner un :");
			
			//indice++;

			//int age = 30;
			//on attribut par le biai des variable ci-dessus
			//Personne moi;
			//moi = new Personne(prenom, personnage, univers, couleur);
			//moi.Couleur = "Rouge";//change la valeur par default jaune par Rouge;		
			//Console.WriteLine(moi.PrenomPersonne + " dans le jeux " + moi.NomUnivers + " son meilleur perso est " + moi.NomPersonnage + " en couleur " + moi.Couleur);

			//Personne chris;
			//chris = new Personne("chris", personnage = "Iron Man", univers, "Bleu");
			//chris.NomUnivers = "Avengers";
			//chris.Couleur = "Bleu";
			//chris.afficher();

			//Personne vona;
			//vona = new Personne();
			//Appel de la fonction toutchanger pour donner les attributs a vona.
			//  vona.ToutChanger("Vona", "Wolverine", "Xmen", 35, "violet");
			//vona.afficher();

			//Personne Droïde;
			//Droïde = new Personne();
			//Droïde.NomPersonnage = "R2D2";
		}
	}
}
