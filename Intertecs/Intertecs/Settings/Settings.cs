using Intertecs.Modelos;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intertecs.Settings
{
    class Settings
    {
        private static ISettings AppSettings =>
            CrossSettings.Current;

        public static string UserName
        {
            get => AppSettings.GetValueOrDefault(nameof(UserName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(UserName), value);
        }
        public static String token
        {
            get => AppSettings.GetValueOrDefault(nameof(token), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(token), value);
        }
        public static String institucionName
        {
            get => AppSettings.GetValueOrDefault(nameof(institucionName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(institucionName), value);
        }
        public static String institucionShortName
        {
            get => AppSettings.GetValueOrDefault(nameof(institucionShortName), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(institucionShortName), value);
        }
        public static String institucionLogo
        {
            get => AppSettings.GetValueOrDefault(nameof(institucionLogo), string.Empty);
            set => AppSettings.AddOrUpdateValue(nameof(institucionLogo), value);
        }
    }
}
