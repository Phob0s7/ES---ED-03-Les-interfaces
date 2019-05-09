using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
	/// <summary>
	/// Classe qui représente un éclaireur
	/// </summary>
	class Eclaireur : Pièce, IDéplaçable
	{
		/// <summary>
		/// Constructeur de la classe Eclaireur
		/// </summary>
		/// <param name="posX">Position X</param>
		/// <param name="posY">Position Y</param>
		public Eclaireur(int posX, int posY) : base(posX, posY)
		{
			this.posX = posX;
			this.posY = posY;
		}

		/// <summary>
		/// Permet de dessiner l'éclaireur
		/// </summary>
		public override void Dessiner()
		{
			Console.WriteLine(" o");
			Console.WriteLine("-+-");
			Console.WriteLine(" |");
			Console.WriteLine("/ \\");
		}

		/// <summary>
		/// Permet de déplacer l'éclaireur
		/// </summary>
		public void SeDéplacer()
		{
			Console.WriteLine("Je me déplace de 3 cases");
		}
	}
}
