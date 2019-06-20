using Avalonia;
using Avalonia.Markup.Xaml;

namespace CarAuto
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
