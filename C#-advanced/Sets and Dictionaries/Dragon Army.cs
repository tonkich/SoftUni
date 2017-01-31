using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TowerOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<Tuple<string, string>, int[]> dragons = new SortedDictionary<Tuple<string, string>, int[]>();
            Dictionary<string,double[]> types = new Dictionary<string, double[]>();

            int numberOfDragons = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfDragons; i++)
            {
                string[] dragonInfo = Console.ReadLine().Split();
                string dragonType = dragonInfo[0];
                char[] dragonFirst = dragonType.ToCharArray();
                if (!char.IsUpper(dragonFirst[0]))
                {
                    continue;
                }
                string dragonName = dragonInfo[1];
                char[] dragonNameFirst = dragonName.ToCharArray();
                if (!char.IsUpper(dragonNameFirst[0]))
                {
                    continue;
                }
                int dragonDamage;
                try
                {
                     dragonDamage = int.Parse(dragonInfo[2]);
                }
                catch (Exception)
                {
                    dragonDamage = 45;
                }
                int dragonHealth;
                try
                {
                    dragonHealth = int.Parse(dragonInfo[3]);
                }
                catch (Exception)
                {
                    dragonHealth = 250;
                }
                int dragonArmor;
                try
                {
                    dragonArmor = int.Parse(dragonInfo[4]);
                }
                catch (Exception)
                {
                    dragonArmor = 10;
                }
                
                Tuple<string, string> dragon = new Tuple<string, string>(dragonName, dragonType);
                if (dragons.ContainsKey(dragon))
                {
                    dragons[dragon][0] = dragonDamage;
                    dragons[dragon][1] = dragonHealth;
                    dragons[dragon][2] = dragonArmor;

                }
                else
                {
                    dragons.Add(dragon, new int[3] { dragonDamage, dragonHealth, dragonArmor });
                }
                if (!types.ContainsKey(dragonType))
                {
                    types.Add(dragonType, new double[4]);
                }
            }
            var sortedDragons = dragons.OrderBy(x => x.Key.Item1);
            foreach (var dragon in sortedDragons)
            {
                foreach (var type in types)
                {
                    if (dragon.Key.Item2==type.Key)
                    {
                        type.Value[0] += dragon.Value[0];
                        type.Value[1] += dragon.Value[1];
                        type.Value[2] += dragon.Value[2];
                        type.Value[3] += 1;
                    }
                }
            }
            foreach (KeyValuePair<string,double[]> type in types)
            {
                type.Value[0] = type.Value[0] / type.Value[3];
                type.Value[1] = type.Value[1] / type.Value[3];
                type.Value[2] = type.Value[2] / type.Value[3];
                Console.WriteLine($"{type.Key.ToString()}::({type.Value[0].ToString("0.00")}/{type.Value[1].ToString("0.00")}/{type.Value[2].ToString("0.00")})");
                foreach (var dragon in sortedDragons)
                {
                    if (dragon.Key.Item2==type.Key)
                    {
                        Console.WriteLine($"-{dragon.Key.Item1} -> damage: {dragon.Value[0]}, health: {dragon.Value[1]}, armor: {dragon.Value[2]}");
                    }
                    
                }
            }
            
            
        }
    }
}

