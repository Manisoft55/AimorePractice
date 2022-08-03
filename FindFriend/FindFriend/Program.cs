using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFriend
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plase Enter your friend Name:");
            string name = Console.ReadLine();
            var objFind = new FindFriendProgram();
            string result = objFind.FindFriend(name);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
