using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOCDay1
{
    public class AOCDay3
    {
        //calculate gamma rate which is the most common number for each column of bits
        //calculate epsilon rate which is least common in each position then multiply together
        //Need to split into an array of chars? so I can count each column
        //split the array by lines so then I can count each index of each line?

        public void PartOne()
        {
            int zero = 0;
            int one = 0;
            string[] text = File.ReadAllLines(@"C:\Users\cwkam\development\AdventofCode\AOCDay1\AOCDay1\AOCDay3.txt");
            foreach (string line in text)
            {
                var LineArray = line.ToCharArray();
                for (int i = 0; i < LineArray.Length; i++)
                {
                    if (LineArray[i] == '0')
                    {
                        zero++;
                    }
                    else if (LineArray[i] == '1')
                    {
                        one++;
                    }
                }
            }
        }

    }
}
