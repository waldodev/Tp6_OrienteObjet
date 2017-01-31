using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class ForceDeLaNature
	{
		private string _nomElement;
		private string _actionElement;
		private int _degreElement;

		//Constructeur
		public ForceDeLaNature(string _nomElement, string _actionElement)
		{
			this._nomElement = _nomElement;
			this._actionElement = _actionElement;
			this._degreElement = _degreElement;
		}

		//Methode
		public void SoirOuNuit()
		{
			Random nombre2 = new Random();
			int mini = 0; int maxi = 1; int choix2;
			choix2 = nombre2.Next(mini, maxi);

			switch (choix2)
			{
				case 0:
					ForceDeLaNature soleil = new ForceDeLaNature(_nomElement, _actionElement);
					soleil.NomElement = "Jours";
					soleil.ActionElement = "Rével toi c'est l'heure";
					break;
				case 1:
					ForceDeLaNature lune = new ForceDeLaNature(_nomElement, _actionElement);
					lune.NomElement = "Nuit";
					lune.ActionElement = "Va dormir il est tard";
					break;			
			}
		}
	//Accesseur Mutateur
	public string NomElement
		{
			get
			{
				return _nomElement;
			}

			set
			{
				_nomElement = value;
			}
		}

		public string ActionElement
		{
			get
			{
				return _actionElement;
			}

			set
			{
				_actionElement = value;
			}
		}

		public int DegreElement
		{
			get
			{
				return _degreElement;
			}

			set
			{
				_degreElement = value;
			}
		}
	}
}
