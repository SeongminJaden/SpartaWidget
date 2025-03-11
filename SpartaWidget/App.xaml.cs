using System;
using System.Windows;  // ← WPF의 Application을 사용

namespace SpartaWidget
{
    public partial class App : System.Windows.Application  // ← 명확히 지정
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
        }
    }
}
