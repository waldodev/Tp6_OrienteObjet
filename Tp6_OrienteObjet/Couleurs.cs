using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	public class Couleurs
	{
		//Attribut
		private string nomCouleur;

		//Constructeur
		public Couleurs()
		{
			
		}

		//Methodes
		public void ChangerCouleur(string saisiCouleur)
		{
			Couleurs maCouleur = new Couleurs();
			maCouleur.NomCouleur = saisiCouleur;		
		}
		//Accesseur
		public string NomCouleur
		{
			get
			{
				return nomCouleur;
			}

			set
			{
				nomCouleur = value;
			}
		}

		//Structur
		enum colorier
		{
			yelow=1 ,
			Green,
			blue,
			red,
			pink
		}
	}
}
