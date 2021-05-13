using System.Windows;

namespace EdycjaOkienka.Common
{
    public static class MessageController
    {
        public static void ShowError(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        
        public static void ShowInfo(string message)
        {
            MessageBox.Show(message, "Powiadomienie", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}