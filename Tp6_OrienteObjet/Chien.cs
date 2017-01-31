using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	//Chien herite d'Animaux
	 class Chien : Animaux 
	{
		private string _pedigreChien;
		//Pour que chien hérite de animaux il faut créer un constructeur chien avec les même attribut que le constructeur parent animaux.
		//les attributs peuvent avoir n'importe quel nom pour chien mais doivent avoir le même nombre minimum d'attribut par rapport au constructeur parent Animaux
		// si constructeur animaux a 2 Attribut. constructeur chien aura 2 attribut minimum.
		//Ensuite on rajoute les attributs de la class chien "pedigre"
		//contructeur                                      Constructeur Parent Animaux
		//                                                  ▼▼▼▼▼▼▼▼▼▼▼▼▼
		public Chien(string nom,string car, string pedig) : base(nom,car)
		{

		}
		//public Chien(string _pedigreChien:base())
		//{
		//Console.WriteLine();
		//}
	}
}
