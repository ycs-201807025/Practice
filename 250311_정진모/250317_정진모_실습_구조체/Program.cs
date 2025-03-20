using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _250317_정진모_실습_구조체
{
    class Program
    {
        struct Item
        {
            public string Name;
            public string UniqueId;
        }
        struct Inventory
        {
            public string[] Item;
        }
        
        static void Main(string[] args)
        {
            Item item = new Item();
            Console.WriteLine("아이템 이름 입력 : ");
            item.Name = Console.ReadLine();

            Console.WriteLine("아이템 고유아이디 입력 : ");
            item.UniqueId = Console.ReadLine();

            Console.WriteLine("아이템 이름 : {0}",item.Name);
            Console.WriteLine("아이템 고유아이디 : {0}",item.UniqueId);

            Inventory inventory = new Inventory();
            int inven = int.Parse(Console.ReadLine());
            Item[] arrInventory = new Item[inven];
            for (int i = 0; i < inven; i++)
            {
                Console.WriteLine("{0}. 아이템 이름 : {1} 아이템 고유아이디 : {2}",i,item.Name,item.UniqueId);
            }
            


        }
    }
}
