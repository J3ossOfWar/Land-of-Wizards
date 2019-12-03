using System.Windows.Forms;

namespace Game
{
    class Luncher
    {
        public static StartForm StartGame;

        static void Main(string[] args)
        {
            StartGame = new StartForm();
            Application.Run(StartGame);
        }
    }
}
