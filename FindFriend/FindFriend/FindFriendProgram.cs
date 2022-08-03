using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindFriend
{
    internal class FindFriendProgram
    {
        public string FindFriend(string friendName)
        {
            string[] friendsName = { "Suresh", "Rajesh", "Amal", "Muthu", "Arun" };
            bool isMyFriend = false;

            foreach(var name in friendsName)
            {
                if(friendName == name)
                {
                    isMyFriend = true;
                    //break;
                    continue;
                    isMyFriend = false;
                }
            }

            if (isMyFriend)
                return "He's my friend";
            else
                return "He's not my friend";
        }
    }
}
