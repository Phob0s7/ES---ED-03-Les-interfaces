using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
	/// <summary>
	/// Classe qui représente une mine explosive
	/// </summary>
    class MineExplosive : Pièce
    {
		/// <summary>
		/// Constructeur de la classe MineExplosive
		/// </summary>
		/// <param name="posX">Position X</param>
		/// <param name="posY">Position Y</param>
		public MineExplosive(int posX, int posY) : base(posX, posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

		/// <summary>
		/// Permet de dessiner une mine explosive
		/// </summary>
        public override void Dessiner()
        {
			Console.WriteLine("*");
        }
    }
}
