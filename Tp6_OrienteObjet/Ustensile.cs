using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp6_OrienteObjet
{
	class Ustensile
	{
		private string _nomUstensile;
		private string _actionUstensile;
		private int _quantiteUstebsile;

		
		//Constructeur

		public Ustensile(string _nomUstensile, string _actionUstensile, int _quantiteUstebsile)
		{
			this.NomUstensile = _nomUstensile;
			this.ActionUstensile = _actionUstensile;
			this.QuantiteUstebsile = _quantiteUstebsile;
		}

		//Methode
		//Accesseur Mutateur
		public string NomUstensile
		{
			get
			{
				return _nomUstensile;
			}

			set
			{
				_nomUstensile = value;
			}
		}

		public string ActionUstensile
		{
			get
			{
				return _actionUstensile;
			}

			set
			{
				_actionUstensile = value;
			}
		}

		public int QuantiteUstebsile
		{
			get
			{
				return _quantiteUstebsile;
			}

			set
			{
				_quantiteUstebsile = value;
			}
		}

	}
}
