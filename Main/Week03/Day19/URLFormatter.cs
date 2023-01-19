using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Web;

namespace Day19
{
    public class URLFormatter
    {
        public static string URLShortener(string url){
            
            const int bound = 4;
            const string baseStr = "http://urlshort.nr/";
            const int maxLength = 200 - baseStr.Length;

            string HashEncoder(string str) {

                StringBuilder sb = new StringBuilder();
                
                int max = (int) Math.Ceiling((double) url.Length / bound);

                for(int i = 0; i < max; i++)
                {
                    int op = 0;

                    for(int j = i * bound; j < url.Length && j < (i * (bound + 1)); j++)
                        op += (byte) url[j];

                
                    op /= 4;
                    
                    sb.Append(Convert.ToChar(op % 126));
                        
                    op = 0;
                }

                if(sb.Length > maxLength || sb.Length > url.Length / 4)
                    return URLShortener(sb.ToString());
                
                return HttpUtility.UrlEncode(sb.ToString());
            }

            return $"{baseStr}{HashEncoder(url)}";
        }
    }
}