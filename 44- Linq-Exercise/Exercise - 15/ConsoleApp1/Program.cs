using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ItemMust
    {
        public int ItemID { get; set; }
        public string ItemDes { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ItemMust> tempList = new List<ItemMust>();
            tempList.Add(new ItemMust { ItemID = 1 , ItemDes = "Biscuit"});
            tempList.Add(new ItemMust { ItemID = 2 , ItemDes = "Honey"});
            tempList.Add(new ItemMust { ItemID = 3 , ItemDes = "Butter"});
            tempList.Add(new ItemMust { ItemID = 4 , ItemDes = "Brade"});
            tempList.Add(new ItemMust { ItemID = 5 , ItemDes = "Honey"});
            tempList.Add(new ItemMust { ItemID = 6 , ItemDes = "Biscuit"});

            var reult = (from s in tempList select s.ItemDes).Distinct().OrderBy(x => x);
            //var reult2 = (from s in tempList select s.ItemDes);
            foreach (var item in reult)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
