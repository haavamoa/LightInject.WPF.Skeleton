using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Client.Annotations;
using Client.Helpers;

namespace Client.ViewModels
{
    public class ShellViewModel : ObservableObject, IShellViewModel
    {
        private string m_statusMessage;

        public Task Initialize()
        {
            StatusMessage = "ShellViewModel was initialized";
            return Task.CompletedTask;
        }

        public string StatusMessage
        {
            get => m_statusMessage;
            set => SetProperty(ref m_statusMessage, value);
        }
    }
}