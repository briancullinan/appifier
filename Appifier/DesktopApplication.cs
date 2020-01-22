using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Appifier
{
    public class DesktopApplication : Application
    {
        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            var window = Windows.UI.Xaml.Window.Current;
            var shellView = new Windows.UI.Xaml.Controls.Page();

            window.Content = shellView;

            window.Activate();
        }
    }
}
