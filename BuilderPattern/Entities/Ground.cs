using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Entities
{
    class Ground
    {
        private List<String> _constitutes = new List<string>();

        private String _GroundAppearance;
        public Ground(String GroundAppearance)
        {
            _GroundAppearance = GroundAppearance;
        }

        public void AddConstitute(String constituePart)
        {
            _constitutes.Add(constituePart);
        }

        public void Representaion()
        {
            Console.WriteLine($"Ground Appearance is {_GroundAppearance} and constitutes ----:\n");

            foreach (String constituePart in _constitutes)
            {
                Console.WriteLine(constituePart);
            }
        }
    }
}
