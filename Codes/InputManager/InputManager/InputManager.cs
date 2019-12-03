using System.Windows.Forms;
using System;

namespace inputmanager
{
    public class InputManager
    {
        public static bool W, S, D, A;

        public static void Press(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    W = true;
                    break;
                case Keys.S:
                    S = true;
                    break;
                case Keys.D:
                    D = true;
                    break;
                case Keys.A:
                    A = true;
                    break;
                default:
                    break;
            }
        }

        public static void Release(KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.W:
                    W = false;
                    break;
                case Keys.S:
                    S = false;
                    break;
                case Keys.D:
                    D = false;
                    break;
                case Keys.A:
                    A = false;
                    break;
                default:
                    break;
            }
        }
    }
}