using System;
using System.Windows.Forms;

namespace Application
{
    public class MsgBoxOutputService : IOutputService
    {
        public void WriteMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}