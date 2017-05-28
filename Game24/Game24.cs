using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game24
{
    [Serializable]
    public class Game24 
    {
        public Dictionary<String,String> combinations; //Dictionary of all solvable combinations with one possible solution
        public int Card1 {get ;set;} //Value of first card
        public int Card2 {get ;set;} //Value of second card
        public int Card3 {get ;set;} //Value of third card
        public int Card4 {get; set;} //Value of fourth card
        public Random rand; //Random used to generate digits
        public string combination; //String with the chosen combination (digits ordered in ascending order) 

        public Game24() {
            rand = new Random();
            combinations = new Dictionary<string,string>();
            combination = null;
            loadSolutions();

        }

        // Read the <Key,Value> pair for all solvable puzzles of Game24 where Key is the combination solution , Value is the solution
        private void loadSolutions() {
            string line;
            System.IO.StreamReader file =
                    new System.IO.StreamReader("combinations.txt");
            while ((line = file.ReadLine()) != null)
            {
                string[] parts = line.Split("\t".ToCharArray());
                if (combinations.ContainsKey(parts[0]) == false)
                    combinations.Add(parts[0], parts[1]);

            }

            file.Close();
        }

        //Generate a new solvable puzzle
        public void Generate() {
            do
            {
                Card1 = rand.Next(1, 10);
                Card2 = rand.Next(1, 10);
                Card3 = rand.Next(1, 10);
                Card4 = rand.Next(1, 10);

                List<int> lis = new List<int>();
                lis.Add(Card2);
                lis.Add(Card1);
                lis.Add(Card3);
                lis.Add(Card4);
                lis.Sort();
                combination = ""+lis.ElementAt(0) + lis.ElementAt(1) + lis.ElementAt(2) + lis.ElementAt(3);

            } while (!combinations.ContainsKey(combination));
            
        }

        //Override of ToString method
        public override string ToString()
        {
            return String.Format("{0} {1} {2} {3}", Card1, Card2, Card3, Card4);
        }

        //Solution for given combination
        public string getSolution()
        {
            return combinations[combination];
        }
    }
}
