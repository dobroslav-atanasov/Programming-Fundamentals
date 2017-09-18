using System;
using System.Collections.Generic;

namespace _06.DNASequences
{
    public class DNASequences
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            string[] dna = new[] { "A", "C", "G", "T" };
            string dnaCode = "";
            string dnaText = "";
            
            for (int i = 0; i < dna.Length; i++)
            {
                for (int j = 0; j < dna.Length; j++)
                {
                    for (int k = 0; k < dna.Length; k++)
                    {
                        dnaCode = $"{dna[i]}{dna[j]}{dna[k]}";
                        int sum = 0;

                        for (int l = 0; l < dnaCode.Length; l++)
                        {
                            if (dnaCode[l] == 'A')
                            {
                                sum += 1;
                            }
                            else if (dnaCode[l] == 'C')
                            {
                                sum += 2;
                            }
                            else if (dnaCode[l] == 'G')
                            {
                                sum += 3;
                            }
                            else if (dnaCode[l] == 'T')
                            {
                                sum += 4;
                            }
                        }

                        if (sum >= num)
                        {
                            Console.Write("O" + dnaCode + "O ");
                        }
                        else
                        {
                            Console.Write("X" + dnaCode + "X ");
                        }
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
