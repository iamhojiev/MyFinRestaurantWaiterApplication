﻿using System;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MyFinCassa.Helper;
using System.Collections.Generic;

namespace MyFinCassa.Database
{
    public static class DataSQL
    {
        public static string URL = string.Format("http://{0}/android/php", OnMyConfig().ip);

        public static string ConvertDouble(double text)
        {
            return text.ToString().Replace(",", ".");
        }

        public static SettingsJson OnMyConfig()
        {
            var path = Environment.CurrentDirectory + @"\Config.json";
            var json = File.ReadAllText(path, Encoding.GetEncoding(1251));
            SettingsJson config = JsonConvert.DeserializeObject<SettingsJson>(json);

            return config;
        }

        public static List<T> Deserialize<T>(this string SerializedJSONString)
        {
            var result = SerializedJSONString.Replace(@"\\u", @"\u");

            try
            {
                result = UnicodeToUTF8(result);

                result = result.Replace("\\\"", "");
                result = result.Remove(0, 1);
                result = result.Substring(0, result.Length - 1);

                var stuff = JsonConvert.DeserializeObject<List<T>>(result);
                return stuff;
            }
            catch (Exception ex)
            {
                Dialog.Error(ex.Message.ToString());
                return null;
            }
        }

        static string UnicodeToUTF8(string from)
        {
            var bytes = Encoding.UTF8.GetBytes(from);
            return new string(bytes.Select(b => (char)b).ToArray());
        }
    }
}
