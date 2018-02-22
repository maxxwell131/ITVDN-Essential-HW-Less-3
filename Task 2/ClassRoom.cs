using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class ClassRoom
    {
        Pupil[] pupils = new Pupil[4];
        Random random = new Random();

       public ClassRoom(Pupil pupil_1, Pupil pupil_2)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = pupil_3;
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil pupil_1, Pupil pupil_2, Pupil pupil_3, Pupil pupil_4)
        {
            pupils[0] = pupil_1;
            pupils[1] = pupil_2;
            pupils[2] = pupil_3;
            pupils[3] = pupil_4;
        }

        public void Study()
        {
            foreach (Pupil currentPupil in pupils)
            {
                currentPupil.Study();
            }
        }

        public void Read()
        {
            foreach (Pupil currentPupil in pupils)
            {
                currentPupil.Read();
            }
        }

        public void Write()
        {
            foreach (Pupil currentPupil in pupils)
            {
                currentPupil.Write();
            }
        }

        public void Relax()
        {
            foreach (Pupil currentPupil in pupils)
            {
                currentPupil.Relax();
            }
        }

        private Pupil GeneratePupil()
        {
            switch(random.Next(1,4))
            {
                case 1: return new BadPupil();
                case 2: return new GoodPupil();

                default: return new ExcelentPupil();
            }

        }
    }
}
