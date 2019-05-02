using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES___ED_03
{
    class Eclaireur : Pièce, IDéplaçable, IDessinable
    {
        public Eclaireur(int posX, int posY) : base(posX, posY)
        {
            this.posX = posX;
            this.posY = posY;
        }

        public void Dessinable()
        {
            Console.WriteLine("o");
            Console.writeLine("- +-");
                |
               / \
        }

        public void SeDéplacer()
        {
           Console.WriteLine("Je me déplace de 3 cases");
        }
    }
}
