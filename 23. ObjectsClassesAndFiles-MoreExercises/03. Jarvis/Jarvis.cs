using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Jarvis
{
    public class Jarvis
    {
        public static void Main()
        {
            List<Head> heads = new List<Head>();
            List<Torso> torsos = new List<Torso>();
            List<Arms> arms = new List<Arms>();
            List<Legs> legs = new List<Legs>();
            long maxHealth = long.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "Assemble!")
            {
                string[] robotParts = input.Split(' ').ToArray();
                string component = robotParts[0];
                long energyConsumption = long.Parse(robotParts[1]);
                string property1 = robotParts[2];
                string property2 = robotParts[3];
                if (component == "Head")
                {
                    Head head = new Head()
                    {
                        Energy = energyConsumption,
                        IQ = int.Parse(property1),
                        Skin = property2
                    };
                    if (heads.Count == 0)
                    {
                        heads.Add(head);
                    }
                    else
                    {
                        Head currentHead = heads.First();
                        if (head.Energy < currentHead.Energy)
                        {
                            heads.Remove(currentHead);
                            heads.Add(head);
                        }
                    }
                }
                else if (component == "Torso")
                {
                    Torso torso = new Torso()
                    {
                        Energy = energyConsumption,
                        ProcessorSize = double.Parse(property1),
                        Material = property2
                    };
                    if (torsos.Count == 0)
                    {
                        torsos.Add(torso);
                    }
                    else
                    {
                        Torso currentTorso = torsos.First();
                        if (torso.Energy < currentTorso.Energy)
                        {
                            torsos.Remove(currentTorso);
                            torsos.Add(torso);
                        }
                    }
                }
                else if (component == "Arm")
                {
                    Arms arm = new Arms()
                    {
                        Energy = energyConsumption,
                        Distance = int.Parse(property1),
                        CountOfFingers = int.Parse(property2)
                    };
                    if (arms.Count < 2)
                    {
                        arms.Add(arm);
                    }
                    else
                    {
                        for (int i = 0; i < arms.Count; i++)
                        {
                            if (arms[i].Energy > arm.Energy)
                            {
                                arms.RemoveAt(i);
                                arms.Add(arm);
                            }
                        }
                    }
                }
                else if (component == "Leg")
                {
                    Legs leg = new Legs()
                    {
                        Energy = energyConsumption,
                        Strength = int.Parse(property1),
                        Speed = int.Parse(property2)
                    };
                    if (legs.Count < 2)
                    {
                        legs.Add(leg);
                    }
                    else
                    {
                        for (int i = 0; i < legs.Count; i++)
                        {
                            if (legs[i].Energy > leg.Energy)
                            {
                                legs.RemoveAt(i);
                                legs.Add(leg);
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            long totalEnergy = 0l;
            totalEnergy += heads.Select(x => x.Energy).Sum();
            totalEnergy += torsos.Select(x => x.Energy).Sum();
            totalEnergy += arms.Select(x => x.Energy).Sum();
            totalEnergy += legs.Select(x => x.Energy).Sum();

            if (heads.Count == 0 || torsos.Count == 0 || arms.Count < 2 || legs.Count < 2)
            {
                Console.WriteLine("We need more parts!");
            }
            else if (totalEnergy > maxHealth)
            {
                Console.WriteLine("We need more power!");
            }
            else
            {
                Console.WriteLine("Jarvis:");
                Console.WriteLine("#Head:");
                Console.WriteLine($"###Energy consumption: {heads[0].Energy}");
                Console.WriteLine($"###IQ: {heads[0].IQ}");
                Console.WriteLine($"###Skin material: {heads[0].Skin}");
                Console.WriteLine("#Torso:");
                Console.WriteLine($"###Energy consumption: {torsos[0].Energy}");
                Console.WriteLine($"###Processor size: {torsos[0].ProcessorSize:F1}");
                Console.WriteLine($"###Corpus material: {torsos[0].Material}");
                foreach (var arm in arms.OrderBy(x => x.Energy))
                {
                    Console.WriteLine("#Arm:");
                    Console.WriteLine($"###Energy consumption: {arm.Energy}");
                    Console.WriteLine($"###Reach: {arm.Distance}");
                    Console.WriteLine($"###Fingers: {arm.CountOfFingers}");
                }
                foreach (var leg in legs.OrderBy(x => x.Energy))
                {
                    Console.WriteLine("#Leg:");
                    Console.WriteLine($"###Energy consumption: {leg.Energy}");
                    Console.WriteLine($"###Strength: {leg.Strength}");
                    Console.WriteLine($"###Speed: {leg.Speed}");
                }
            }
        }
    }

    public class Arms
    {
        public long Energy { get; set; }
        public int Distance { get; set; }
        public int CountOfFingers { get; set; }
    }

    public class Legs
    {
        public long Energy { get; set; }
        public int Strength { get; set; }
        public int Speed { get; set; }
    }

    public class Torso
    {
        public long Energy { get; set; }
        public double ProcessorSize { get; set; }
        public string Material { get; set; }
    }

    public class Head
    {
        public long Energy { get; set; }
        public int IQ { get; set; }
        public string Skin { get; set; }
    }
}
