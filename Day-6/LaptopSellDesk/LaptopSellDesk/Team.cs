using System;
using Azure = CoforgeTech.Azure;
using Java = CoforgeTech.Java;
using DotNet = CoforgeTech.DotNet;
using Testing = CoforgeTech.Testing;

namespace CoforgeTech
{
    class BusinessTeam
    {
        static void Main()
        {
            Azure.Participant obj1 = new Azure.Participant();
            Console.WriteLine("Number Of participants in Azure = " + obj1.Numberofparti);

            Java.Participant obj2 = new Java.Participant();
            Console.WriteLine("Number Of participants in Java = " + obj2.Numberofparti);

            DotNet.Participant obj3 = new DotNet.Participant();
            Console.WriteLine("Number Of participants in DotNet = " + obj3.Numberofparti);

            Testing.Participant obj4 = new Testing.Participant();
            Console.WriteLine("Number Of participants in Testing = " + obj4.Numberofparti);

            Console.ReadKey();


        }
    }

    namespace Azure
    {
        class Participant
        {
            int nop;
            public Participant()
            {
                nop = 12;
            }

            public int Numberofparti { get { return nop; } }
        }
    }
    namespace Java
    {
        class Participant
        {
            int nop;
            public Participant()
            {
                nop = 20;
            }

            public int Numberofparti { get { return nop; } }
        }
    }
    namespace DotNet
    {
        class Participant
        {
            int nop;
            public Participant()
            {
                nop = 17;
            }

            public int Numberofparti { get { return nop; } }
        }
    }
    namespace Testing
    {
        class Participant
        {
            int nop;
            public Participant()
            {
                nop = 7;
            }

            public int Numberofparti { get { return nop; } }
        }
    }
}
