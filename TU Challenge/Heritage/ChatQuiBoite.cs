using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class ChatQuiBoite : Chat
    {
        public ChatQuiBoite(string name) : base(name)
        {
            _pattes = 3;
        }


        public override void ArriveInPetShop(Animalerie master)
        {
            //base.ArriveInPetShop(master);
        }

    }
}
