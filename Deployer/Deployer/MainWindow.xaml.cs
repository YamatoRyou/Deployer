using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace Deployer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			DeployButton.Click += DeployButton_Click;
		}

		private void DeployButton_Click(object sender, RoutedEventArgs e)
		{
			RegistryKey key = Registry.CurrentUser.OpenSubKey("Software", true);
			key = key?.OpenSubKey("Image-Line", true);
			key = key?.OpenSubKey("Shared", true);
			key = key?.OpenSubKey("Paths", true);

			key?.SetValue("Shared DLLs", $"{Environment.CurrentDirectory}\\Misc\\Shared");
		}
	}
}
