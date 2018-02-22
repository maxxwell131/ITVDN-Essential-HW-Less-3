using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class GoodPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("GoodPupil Study");
        }

        public override void Read()
        {
            Console.WriteLine("GoodPupil read");
        }

        public override void Write()
        {
            Console.WriteLine("GoodPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine("GoodPupil relax");
        }
    }
}
