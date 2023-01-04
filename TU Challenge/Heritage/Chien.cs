using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chien : Animal
    {
        public Chien(string name) : base(name)
        {
        }

        public override string Crier()
        {
            switch (Fed)
            {
                case AnimalState.Hungry:
                    return "Ouaf (j'ai faim)";
                    break;
                case AnimalState.Fed:
                    return "Ouaf (viens on joue ?)";
                    break;
                case AnimalState.AteBubulle:
                    return "Ouaf (Bizarre cette croquette)";
                    break;
                default:
                    return "";
                    break;
            }

        }


    }
}
