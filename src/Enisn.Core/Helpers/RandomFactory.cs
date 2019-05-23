using System;
using System.Collections.Generic;
using System.Text;

namespace Enisn.Core.Helpers
{
    public static class RandomFactory
    {
        public static readonly Random rnd = new Random();
        private const string lorem = "Start a deeds run from below ways mood then childe the olden counsel that than to before shrine if run to his glare not was a isle breast he olden childe and his though harolds them youth from olden cared that monastic and none can earthly moths that the feeble not basked sighed of when carnal on feeble was ever peace wight harold isle cell sight childe upon stalked and the goodly love if had given sore weary before lyres of are adversity most strength harold delight deem eremites would which from but relief name know vexed my labyrinth there";
        public static string GetString(int length)
        {
            return lorem.Substring(rnd.Next(lorem.Length - length - 1), length);
        }
        public static int GetInt32(int max = 100, int min = 0)
        {
            return rnd.Next(min, max);
        }

        public static string GetEmail()
        {
            return $"{GetString(rnd.Next(5, 15)).Replace(" ", string.Empty)}@{GetChar()}mail.com";
        }
        public static char GetChar()
        {
            return Convert.ToChar(rnd.Next(97, 122));
        }
        public static T GetEnum<T>() where T : Enum
        {
            var values = Enum.GetValues(typeof(T));
            var target = rnd.Next(values.Length - 1);
            int current = 0;
            foreach (var item in values)
            {
                if (target == current)
                    return (T)item;
                current++;
            }
            return default;
        }

        public static bool GetBool(int successRate = 50)
        {
            return rnd.Next(100) < successRate;
        }

        public static DateTime GetDateTime()
        {
            return DateTime.Now.AddMilliseconds(-rnd.Next(int.MaxValue));
        }
        public static string GetImageUrl()
        {
            return $"https://source.unsplash.com/random/{GetInt32()}";
        }
    }
}
