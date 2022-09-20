using System;
using System.Collections.Generic;
using System.Reflection;

namespace structVoter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Rinkejas[] rinkejas = new Rinkejas[50];
            for (int i = 0; i < 50; i++)
            {
                string rinkejasID = "";
                for(int j = 0; j < 10; j++)
                {
                    rinkejasID += Convert.ToChar(rnd.Next(65, 91));
                }
                rinkejas[i].ID = rinkejasID;

                int votedInt = rnd.Next(0, 2);
                rinkejas[i].Voted = (votedInt == 0);
            }

            List<Rinkejas> rndList = new List<Rinkejas>();
            int rndStart = rnd.Next(0, 40);
            for(int k = rndStart; k < rndStart + 10; k++)
            {
                rndList.Add(rinkejas[k]);
            }
            Console.WriteLine("Randomly selected voters:");
            foreach (Rinkejas voter in rndList)
            {
                Console.WriteLine(voter.ID);
            }
            Console.WriteLine();

            int[] stat = statistika(rndList);
            Console.WriteLine("Voting statistics:");
            Console.WriteLine("Already voted: " + stat[0] + " out of " + rndList.Count);
            Console.WriteLine("Did not vote: " + stat[1] + " out of " + rndList.Count);
            Console.ReadLine();

        }
        struct Rinkejas
        {
            public string ID;
            public bool Voted;
            public Rinkejas (string id, bool voted)
            {
                ID = id;
                Voted = voted;
            }
        }
        static int[] statistika(List<Rinkejas> rndList)
        {
            int[] stat = new int[] {0,0};
            foreach(Rinkejas vote in rndList)
            {
                if(vote.Voted == true)
                {
                    stat[0]++;
                }
                else
                {
                    stat[1]++;
                }
            }
            return stat;
        }
    }
}
