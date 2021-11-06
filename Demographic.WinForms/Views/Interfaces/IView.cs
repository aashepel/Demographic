using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demographic.WinForms.Views.Interfaces
{
    internal interface IView
    {
        void ShowErrorMessage(string message);

        void ShowInfoMessage(string message);

        void ShowDialogYesNo(string message);

        KeyValuePair<DialogResult, string> ShowFileSelector();

        void Show();

        void Close();

    }
}
