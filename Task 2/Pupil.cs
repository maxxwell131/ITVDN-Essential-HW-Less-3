using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Pupil
    {
        public virtual void Study()
        {
            Console.WriteLine("Pupil Study");
        }

        public virtual void Read()
        {
            Console.WriteLine("Pupil read");
        }

        public virtual void Write()
        {
            Console.WriteLine("Pupil write");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Pupil relax");
        }
    }
}
