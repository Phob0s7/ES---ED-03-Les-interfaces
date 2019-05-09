using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
	/// <summary>
	/// Classe qui représente une jeep
	/// </summary>
	class Jeep : Pièce, IDéplaçable
	{
		/// <summary>
		/// Constructeur de la classe Jeep
		/// </summary>
		/// <param name="posX">Position X</param>
		/// <param name="posY">Position Y</param>
		public Jeep(int posX, int posY) : base(posX, posY)
		{
			this.posX = posX;
			this.posY = posY;
		}
		/// <summary>
		/// Permet de dessiner une jeep
		/// </summary>
		public override void Dessiner()
		{
			Console.WriteLine("____");
			Console.WriteLine("|  |_");
			Console.WriteLine("'O-O-'");
		}
		/// <summary>
		/// Permet de déplacer une jeep
		/// </summary>
		public void SeDéplacer()
		{
			Console.WriteLine("Je roule de 5 cases");
		}
	}
}
