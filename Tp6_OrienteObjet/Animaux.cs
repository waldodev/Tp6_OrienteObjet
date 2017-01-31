using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class Animaux : Couleurs
	{
		private string _nomAnimaux;
		private string _caractereAnimaux;

		//Constructeur

		//	public Animaux()
		//{

		//}

		public Animaux(string _nomAnimaux, string _caractereAnimaux)
		{
			this._nomAnimaux = _nomAnimaux;
			this._caractereAnimaux = _caractereAnimaux;
			this.NomCouleur = "yelow";
		}

		//Methode
		public void creerAnimal()
		{
			Random nombre = new Random();
			int min = 0;int max = 3;int choix;
			choix = nombre.Next(min,max);

			switch(choix)
			{
				case 0:
					Animaux chien = new Animaux(_nomAnimaux, _caractereAnimaux);
					chien.NomAnimaux = "PitBull";
					//chien.CaractereAnimaux = "Domestique";
					chien.CaractereAnimaux = "Mordu 4 personne.Bonne Chance";
					Console.ForegroundColor = ConsoleColor.Green; Console.Write("Chien un " + chien.NomAnimaux + " Plus précisément,"); Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine("il a déja" + chien.CaractereAnimaux); Console.ResetColor();
					break;
				case 1:
					Animaux chat = new Animaux(_nomAnimaux, _caractereAnimaux);
					chat.NomAnimaux = "Minou pour toi ";
					//chat.CaractereAnimaux = "Domestique";
					chat.CaractereAnimaux = "choppé 9 chattes dans le quartier!! Tu as les boules";
					Console.ForegroundColor = ConsoleColor.Green; Console.Write("chat dommage c'est un mal donc pas de " + chat.NomAnimaux + "Plus précisément,"); Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("il a déja" + chat.CaractereAnimaux); Console.ResetColor();
					break;
				case 2:
					Animaux crocodile = new Animaux(_nomAnimaux, _caractereAnimaux);
					crocodile.NomAnimaux = "TicTac";
					//crocodile.CaractereAnimaux = "Sauvage";
					crocodile.CaractereAnimaux = "Comme capitaine crochet il va te bouffer pas le bras mais la Queue LOOOL";
					Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Crocodile celui dans peter Pan \"" + crocodile.NomAnimaux + "\"Plus précisément."); Console.ResetColor();
					Console.ForegroundColor = ConsoleColor.Cyan; Console.WriteLine(crocodile.CaractereAnimaux); Console.ResetColor();
					break;
			}


		}

		//Accesseur Mutateur
		public string NomAnimaux
		{
			get
			{
				return _nomAnimaux;
			}

			set
			{
				_nomAnimaux = value;
			}
		}

		public string CaractereAnimaux
		{
			get
			{
				return _caractereAnimaux;
			}

			set
			{
				_caractereAnimaux = value;
			}
		}
	}
}
