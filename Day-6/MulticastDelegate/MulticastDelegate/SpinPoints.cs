using System;
namespace MulticastDelegate
{
    public class SpinPoints
    {
        int eLevel = 0;
        int wProb = 0;
       
        public SpinPoints()
        {
            eLevel = 1;
            wProb = 100;
            
            Console.WriteLine("Initial Energy Level = " + eLevel);
            Console.WriteLine("Initial Winning Probability = " + wProb);
            
        }

        public void InitialSpin()
        {
            eLevel += 0;
            wProb += 0;
           
        }

        public void FirstSpin()
        {
            eLevel += 1;
            wProb += 10;
            
        }

        public void SecondSpin()
        {
            eLevel += 2;
            wProb += 20;
            
        }

        public void ThirdSpin()
        {
            eLevel -= 3;
            wProb -= 30;
            
        }

        public void FourthSpin()
        {
            eLevel += 4;
            wProb += 40;
           
        }

        public void FifthSpin()
        {
            eLevel += 5;
            wProb += 50;
           
        }

        public void SixthSpin()
        {
            eLevel -= 1;
            wProb -= 60;
          
            
        }

        public void SeventhSpin()
        {
            eLevel += 1;
            wProb += 70;
            
        }

        public void EighthSpin()
        {
            eLevel -= 2;
            wProb -= 20;
            

        }

        public void NinthSpin()
        {
            eLevel -= 3;
            wProb -= 30;
            

        }

        public void TenthSpin()
        {
            eLevel += 10;
            wProb += 100;

        }

        public void Display()
        {
            Console.WriteLine("--------------------Final Score----------------------- ");
            Console.WriteLine("Energy Level = " + eLevel);
            Console.WriteLine("Winning Probability = " + wProb);
            if (eLevel >= 4 && wProb > 60)
            {
                Console.WriteLine("*************WINNER****************");
            }
            else if (eLevel >= 1 && eLevel<4 && wProb > 50)
            {
                Console.WriteLine("**************RUNNER UP*****************");
            }
            else
            {
                Console.WriteLine("************LOOSER*****************");
            }
        }
    }
}
