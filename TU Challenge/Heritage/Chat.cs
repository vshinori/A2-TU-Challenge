using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chat : Animal
    {


        public Chat(string name) : base(name)
        {
            _pattes = 4;
        }

        public override string Crier()
        {
            switch (Fed)
            {
                case AnimalState.Hungry:
                    return "Miaou (j'ai faim)";
                    break;
                case AnimalState.Fed:
                    return "Miaou (c'est bon laisse moi tranquille humain)";
                    break;
                case AnimalState.AteBubulle:
                    return "Miaou (Le poisson etait bon)";
                    break;
                default:
                    return "";
                    break;
            }

            //return base.Crier();
        }

        public override void ArriveInPetShop(Animalerie master)
        {
            master.OnAddAnimal += FaireUnCarnage;

            //foreach (Animal a in master.Zoo
            //    .Where(i => i is Chat)
            //    .Where(i => i.Pattes == 4)
            //    .Where( i => i.Fed == AnimalState.Hungry))
            foreach (Animal a in master.Zoo)
            {
                FaireUnCarnage(a);
            }
        }

        private void FaireUnCarnage(Animal a)
        {
            if (a is Poisson)
            {
                a.Die();
                Fed = AnimalState.AteBubulle;
            }
        }
    }
}
