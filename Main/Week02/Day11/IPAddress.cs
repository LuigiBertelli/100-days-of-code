using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day11
{
    public class IPAddress
    {
        /// <param name="ipNotFormatted">string ip not formatted</param>
        /// <returns>all possible valid IP addresses that can be obtained from ipNotFormatted</returns>
        ///  A valid IP address consists of exactly four integers, each integer is between 0 and 255, separated by single dots and cannot have leading zeros. 
        /// For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses 
        /// and "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
        public static string[] AllValidIPs(string ipNotFormatted)
        {   
            ipNotFormatted = ipNotFormatted.Trim();
            bool isValid(string n) => n != string.Empty && Convert.ToInt32(n) <= 255 && 
                !(n.Length >= 2 && n[0] == '0');

            int len = ipNotFormatted.Length;
            bool isInteger = Int64.TryParse(ipNotFormatted, out long n);
            List<string> IPs = new List<string>();
            
            if(isInteger && n >= 0 && len >= 4 && len <= 12) {
                for(int i = 1; i <= 3; i++) {
                    string[] parts = new string[4];
                    parts.SetValue(ipNotFormatted.Substring(0, i), 0);

                    if(isValid(parts[0])){
                        for(int j = 1; j <= 3; j++) {
                            parts.SetValue((len >= i + j ? 
                                ipNotFormatted.Substring(i, j) : 
                                string.Empty), 1);

                            if(isValid(parts[1])) {
                                for(int k = 1; k <= 3; k++) {
                                    parts.SetValue((len >= i + j + k ? 
                                        ipNotFormatted.Substring(i + j, k) : 
                                        string.Empty), 2);

                                    if(isValid(parts[2])) {
                                        for(int l = 1; l <= 3; l++) {
                                            int total = i + j + k + l;
                                            parts.SetValue((len >=  total? 
                                                ipNotFormatted.Substring(i + j + k, l) : 
                                                string.Empty), 3);

                                            if(isValid(parts[3]) && total == len)
                                                IPs.Add(String.Join(".", parts));
                                        }
                                    }
                                }
                            }

                        }
                    }
                }
            }

            return IPs.ToArray();
        }
    }
}