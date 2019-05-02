using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
    class Fantassin : Pièce, IDéplaçable, IDessinable
    {
        public Fantassin(int posX, int posY):base(posX,posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void Dessinable()
        {
            posX = 4;
            posY = 6;
        }

        public void SeDéplacer()
        {
            Console.WriteLine("Je me déplace de 1 cases");
        }
    }
}
