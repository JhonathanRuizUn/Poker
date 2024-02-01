using GalaSoft.MvvmLight.Views;
using Microsoft.Extensions.DependencyInjection;
using Poker.View;
using Poker.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Poker
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly IServiceProvider _serviceProvider;
        public App()
        {
            IServiceCollection services = new ServiceCollection();

            services.AddSingleton<MainWindow>(provider => new MainWindow
            {
                DataContext = provider.GetRequiredService<MainWindowViewModel>()
            });

            services.AddSingleton<GameViewModel>();

            _serviceProvider = services.BuildServiceProvider();

            _serviceProvider = services.BuildServiceProvider();
            //InitializeComponent();

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {
            _serviceProvider.GetService<MainWindow>().Show();
        }
    }
}
