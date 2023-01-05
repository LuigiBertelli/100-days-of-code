using System;

namespace Day5 {

    public class Sock {
        static void Main(string[] args)
        {
            
        }

        public static int SockPairs(string socks) {

            int countPairs = 0;
            char[] socksChars = socks.ToCharArray();
            
            while(socksChars.Length > 0)
            {
                char actualChar = socksChars[0];
                countPairs += (int) Math.Floor(socks.Count(x => x == actualChar)  / 2.0d);
                socksChars = socksChars.Where(x => x != actualChar).ToArray();
            }

            return countPairs;
        }
    } 
}