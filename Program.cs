using System;
using System.Text;

namespace NetSystemConfigurationExample
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = new StringBuilder();
            message.AppendFormat("Top level Configuration.settings- User setting: {0}",
                                 Configuration.Default.UserSetting);
            message.AppendLine();
            message.AppendFormat("Top level Configuration.settings- Application setting: {0}",
                                 Configuration.Default.ApplicationSetting);
            message.AppendLine();
            message.AppendFormat("Settings\\MoreSettings.settings- User setting: {0}",
                                             Settings.MoreSettings.Default.MoreSettingsUserSetting);
            message.AppendLine();
            message.AppendFormat("Settings\\MoreSettings.settings- Application setting: {0}",
                                 Settings.MoreSettings.Default.MoreSettingsApplicationSetting);
            message.AppendLine();
            message.AppendLine();

            Console.Write(message);
            Console.WriteLine("Press a key to continue");
            var result = Console.ReadKey();
        }
    }
}
