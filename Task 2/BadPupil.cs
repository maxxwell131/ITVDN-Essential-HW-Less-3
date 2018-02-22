using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class BadPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("BadPupil Study");
        }

        public override void Read()
        {
            Console.WriteLine("BadPupil read");
        }

        public override void Write()
        {
            Console.WriteLine("BadPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine("BadPupil relax");
        }
    }
}
