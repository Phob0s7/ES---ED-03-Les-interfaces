using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
    class Jeep :Pièce, IDéplaçable, IDessinable
    {
        public Jeep(int posX, int posY):base(posX,posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void Dessinable()
        {
            posX = 9;
            posY = 2;
        }

        public void SeDéplacer()
        {
            Console.WriteLine("Je me déplace de 5 cases");
        }
    }
}
