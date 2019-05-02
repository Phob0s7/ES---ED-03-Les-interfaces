using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
    class MineExplosive : Pièce, IDessinable
    {
        public MineExplosive(int posX, int posY) : base(posX, posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void Dessinable()
        {
           posX = 6;
           posY = 8;
        }
    }
}
