using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
    /// <summary>
    /// Classe qui repérsente une pièce
    /// </summary>
    abstract class Pièce : IDessinable
	{
		protected int posX = 0;
		protected int posY = 0;
		/// <summary>
		/// Constructeur de la classe Pièce
		/// </summary>
		/// <param name="posX">Position X</param>
		/// <param name="posY">Position Y</param>
		public Pièce(int posX, int posY)
		{
			this.posX = posX;
			this.posY = posY;
		}

        public abstract void Dessiner();
    }
}
