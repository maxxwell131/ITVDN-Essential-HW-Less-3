using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ExcelentPupil : Pupil
    {
        public override void Study()
        {
            Console.WriteLine("ExcelentPupil Study");
        }

        public override void Read()
        {
            Console.WriteLine("ExcelentPupil read");
        }

        public override void Write()
        {
            Console.WriteLine("ExcelentPupil write");
        }

        public override void Relax()
        {
            Console.WriteLine("ExcelentPupil relax");
        }
    }
}
