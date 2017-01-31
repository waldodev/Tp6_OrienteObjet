using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class Legume : Couleurs
	{
		//Attribut
		private string _nomLegume;
		private string _varieteLegume;

		//constructeur
		public Legume()
		{
				
		}

		//Methode
		static public string queVaTonManger(int choixDuRepas)
		{
			string repas ="";
			switch (choixDuRepas)
			{
			case 1:
			//Legume tonLegume = new Legume { NomLegume = "tomate", VarieteLegume = "fruit" };
			Legume tomate = new Legume();
			tomate.NomLegume = "tomate";
			tomate.NomCouleur = "Rouge";
					Console.WriteLine("Votre "+ tomate.NomLegume + " est en cours de préparation");
					break;
			case 2:
			Legume riz = new Legume();
			riz.NomLegume = "riz";
			riz.NomCouleur = "Blanc";
					Console.WriteLine("Votre " + riz.NomLegume + " est en cours de préparation");
					break;
			case 3:
			Legume pate = new Legume();
			pate.NomLegume = "pate";
			pate.NomCouleur = "Yelow";
					Console.WriteLine("Votre " + pate.NomLegume + " est en cours de préparation");
					break;

			case 4:
			Legume semoule = new Legume();
			semoule.NomLegume = "semoule";
			semoule.NomCouleur = "Yelow";
					Console.WriteLine("Votre " + semoule.NomLegume + " est en cours de préparation");
					break;

			}
			return repas;
		}
		//Accesseur et mutateur
		public string NomLegume
		{
			get
			{
				return _nomLegume;
			}

			set
			{
				_nomLegume = value;
			}
		}

		public string VarieteLegume
		{
			get
			{
				return _varieteLegume;
			}

			set
			{
				_varieteLegume = value;
			}
		}
	}
}
