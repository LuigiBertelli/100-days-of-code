namespace Day69 
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var array = new string[8] {"button_clicked", "cycle_complete", "button_clicked", "button_clicked",
            "button_clicked", "button_clicked", "button_clicked", "cycle_complete" };

            GarageDoorOpener.Button(array);
        }
    }
}
