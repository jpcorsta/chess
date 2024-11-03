using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var friends = new List<string> { "Frank", "Joe", "Michelle", "Andy", "Maria", "Carlos", "Angeliqa" };
            var friends = new List<string>();
            var partyFriends = GetPartyFriends(null, 3);

            foreach (var name in partyFriends)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if(list == null)
                throw new ArgumentNullException("list", "the list ist empty");
            if (count > list.Count || count <= 0)
                throw new ArgumentOutOfRangeException("Count", "Count cannot be greater then elements in the list");

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while (partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(list);
                partyFriends.Add(currentFriend);
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
      
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for (var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}

