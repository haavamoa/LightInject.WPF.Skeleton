using Client.ViewModels;
using LightInject;

namespace Client
{
    public class CompositionRoot : ICompositionRoot
    {
        public void Compose(IServiceRegistry serviceRegistry)
        {
            serviceRegistry.Register<IShellViewModel, ShellViewModel>();
            serviceRegistry.Register<MainWindow>();
        }
    }
}