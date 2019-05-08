using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
	/// <summary>
	/// Classe qui représente un fantassin
	/// </summary>
	class Fantassin : Pièce, IDéplaçable, IDessinable
	{   /// <summary>
		/// Constructeur de la classe Fantassin
		/// </summary>
		/// <param name="posX">Position X</param>
		/// <param name="posY">Position Y</param>
		public Fantassin(int posX, int posY) : base(posX, posY)
		{
			this.posX = posX;
			this.posY = posY;
		}

		/// <summary>
		/// Permet de dessiner un fantassin
		/// </summary>
		public void Dessinable()
		{
			Console.WriteLine(" o  |");
			Console.WriteLine("-+- |");
			Console.WriteLine(" |  \\");
			Console.WriteLine("/ \\");
		}

		/// <summary>
		/// Permet de déplacer un fantassin
		/// </summary>
		public void SeDéplacer()
		{
			Console.WriteLine("Je me déplace de 1 cases");
		}
	}
}
