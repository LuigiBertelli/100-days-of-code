using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day69
{
    public class GarageDoorOpener
    {
        private static string[] DOOR_STATES = new string[] {"CLOSED", "OPENING", "STOPPED_WHILE_OPENING", "OPEN", "CLOSING", "STOPED_WHILE_CLOSING" };

        public static string Button(string[] clicks)
        {
            var curState = 0;

            var nextState = (bool isClicked) => {
                switch(curState)
                {
                    case 0:
                        if (isClicked)
                            curState = 1;
                        break;
                    case 1:
                        if (isClicked)
                            curState = 2;
                        else
                            curState = 3;
                        break;
                    case 2:
                        if (isClicked)
                            curState = 4;
                        else
                            curState = 3;
                        break;
                    case 3:
                        if (isClicked)
                            curState = 4;
                        break;
                    case 4:
                        if (isClicked)
                            curState = 5;
                        else
                            curState = 0;
                        break;
                    case 5:
                        if (isClicked)
                            curState = 1;
                        else
                            curState = 0;
                        break;
                }
            };

            foreach (var click in clicks)
            {
                Console.WriteLine($"DOOR: {DOOR_STATES[curState]}");
                nextState(click == "button_clicked");
                Console.WriteLine($" > {click}");
            }

            Console.WriteLine($"DOOR: {DOOR_STATES[curState]}");

            return DOOR_STATES[curState];
        }
    }
}
