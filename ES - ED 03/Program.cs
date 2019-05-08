using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
	/// <summary>
	/// Classe qui représente Program
	/// </summary>
	class Program
	{
		/// <summary>
		/// Point d'entrée du programme
		/// </summary>
		/// <param name="args"></param>
		static void Main(string[] args)
		{
			Eclaireur éclaireur = new Eclaireur(7, 8);
			Fantassin fantassin = new Fantassin(12, 5);
			Jeep jeep = new Jeep(13, 56);
			MineExplosive mineExplosive = new MineExplosive(23, 30);

			List<Pièce> Pièces = new List<Pièce>
			{
				éclaireur,
				fantassin,
				jeep,
				mineExplosive
			};

			foreach (Pièce pièce in Pièces)
			{
				éclaireur.Dessinable();
				fantassin.Dessinable();
				jeep.Dessinable();
				mineExplosive.Dessinable();
				éclaireur.SeDéplacer();
				fantassin.SeDéplacer();
				jeep.SeDéplacer();
			}
		}
	}
}
