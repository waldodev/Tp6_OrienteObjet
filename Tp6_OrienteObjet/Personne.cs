using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class Personne
	{
		//Attribut
		private string _nomPersonne;
	    private string _prenomPersonne;
		private string _nomPersonnage;
		private string _nomUnivers;
		private int _age;
		private string _couleur;
		private string typeDePersonne;

		//Constructeur sans paramètre
			
		public Personne()
		{
		
		}
		//Constructeur avec paramètre		
		public Personne(string _prenomPersonne, string _nomPersonnage, int _age)
		{	
			this._prenomPersonne = _prenomPersonne;
			this.NomPersonnage = _nomPersonnage;
			this.Age = _age;		
			this._couleur = "Jaune";
		}
		public Personne(string _nomPersonne, string _prenomPersonne, string _nomPersonnage, string _nomUnivers, int _age, string _couleur)
		{
			this._nomPersonne = _nomPersonne;
			this._prenomPersonne = _prenomPersonne;
			this.NomPersonnage = _nomPersonnage;
			this.NomUnivers = _nomUnivers;
			this._age = _age;
			this._couleur = "Jaune";
		}

		//Methode

		public void ToutChanger(string _prenomPersonne, string _nomPersonnage , string nomUnivers , int age, string couleur)
		{
			this.PrenomPersonne = _prenomPersonne;
			this.NomPersonnage = _nomPersonnage;
			this.NomUnivers = nomUnivers;
			this.Couleur = couleur;
		}
		public void afficher()
		{
			Console.WriteLine(this.PrenomPersonne+" dans le jeux " + this.NomUnivers + " son meilleur perso est " + this.NomPersonnage + " en couleur " + this.Couleur);
		}

		public string humainOuRobot(string reponseUser)//Verifie si la saisie utilisateur correspond a l'un des objets instancié "Humain" ou "Personne"
		{
			string libelle = "";
			Personne humain = new Personne();
			humain.TypeDePersonne = "humain";			
			Personne robot = new Personne();
			robot.TypeDePersonne = "robot";
			if (reponseUser == humain.TypeDePersonne)
			{
				libelle = humain.TypeDePersonne;
			}
			else if (reponseUser == robot.TypeDePersonne)
			{
				libelle = robot.TypeDePersonne;
			}
			return libelle;
		}
		//Accesseur Mutateur
		public string NomPersonne
		{
			get
			{
				return _nomPersonne;
			}

			set
			{
				_nomPersonne = value;
			}
		}

		public string PrenomPersonne
		{
			get
			{
				return _prenomPersonne;
			}

			set
			{
				_prenomPersonne = value;
			}
		}

		public int Age
		{
			get
			{
				return _age;
			}

			set
			{
				_age = value;
			}
		}

		public string Couleur
		{
			get
			{
				return _couleur;
			}

			set
			{
				_couleur = value;
			}
		}

		public string NomUnivers
		{
			get
			{
				return _nomUnivers;
			}

			set
			{
				_nomUnivers = value;
			}
		}

		public string NomPersonnage
		{
			get
			{
				return _nomPersonnage;
			}

			set
			{
				_nomPersonnage = value;
			}
		}

		public string TypeDePersonne
		{
			get
			{
				return typeDePersonne;
			}

			set
			{
				typeDePersonne = value;
			}
		}
	}
}
