using System.Text.RegularExpressions;
namespace TypographZhoskyStyle
{
    public static class ClassOfRules
    {
        /// <summary>
        /// метод для 2го правила("Нельзя писать подряд более одного пробела")
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SecondRule(string text)
        {
            while (text.Contains("  "))
            {
                text = text.Replace("  ", " ");
            }
            return text;
        }
        /// <summary>
        /// метод для 1го правила("Все знаки препинания пишутся слева слитно со словом, а справа отбиваются пробелом.
        /// Тире отбивается пробелами с двух сторон.Скобки и кавычки пишутся слитно со словами, которые находятся внутри них.")
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string FirstRule(string text)
        {
            string[] chars = new string[] { ",", ".", ":", ";", "!", "?" };
            string[] openChars = new string[] { "(", "«" };
            string[] closeChars = new string[] { ")", "»" };
            if (text.Contains("—"))
            {
                text = text.Replace("—", " — ");
                return text;
            }
            foreach (string c in openChars)
            {
                if (text.Contains(c))
                {
                    text = text.Replace(c, " " + c);
                    return text;
                }
                if (text.Contains(c + " "))
                {
                    text = text.Replace(c + " ", c);
                    return text;
                }
            }
            foreach (string c in closeChars)
            {
                if (text.Contains(" " + c))
                {
                    text = text.Replace(" " + c, c);
                    return text;
                }
                if (text.Contains(c))
                {
                    text = text.Replace(c, c + " ");
                    return text;
                }
            }
            foreach (string c in chars)
            {
                if (text.Contains(" " + c))
                {
                    text = text.Replace(" " + c, c);
                    return text;
                }
                if (text.Contains(c))
                {
                    text = text.Replace(c, c + " ");
                    return text;
                }
            }
            return text;
        }
        /// <summary>
        /// метод для 9го правила("Символ «плюс-минус» задаётся так: ± не нужно использовать конструкции типа «(+,−)».")
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string NinthRule(string text)
        {
            while (text.Contains("(+,−)"))
            {
                text = text.Replace("(+,−)", "±");
                return text;
            }
            return text;
        }
        /// <summary>
        /// метод для 13го правила("Везде где имеется троеточие, его следует писать не тремя точками, а знаком... 
        /// Например: чтобы получить «Молчат...нет ответа...» нужно писать «Молчат...нет ответа...»")
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string ThirteenthRule(string text)
        {
            Regex ThreeDots = new Regex(@"\.{3}", RegexOptions.Compiled);
            string threeDots = "…";
            text = ThreeDots.Replace(text, threeDots);
            return text;
        }
        /// <summary>
        /// метод для правила "Салам": "Привет", "привет", "Здравствуйте" и "здравствуйте" должны исправляться на "салам, брат"
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string SalamRule(string text)
        {
            string[] hi = new string[] { "Привет", "привет", "Здравствуйте", "здравствуйте" };
            foreach (string c in hi)
            {
                if (text.Contains(c))
                {
                    text = text.Replace(c, "салам, брат");
                    return text;
                }
            }
            return text;
        }
        /// <summary>
        /// метод для правила "Лучшая": для напоминания истины пользователям
        /// в конце каждого предложения должно быть ", а и камиля лучше всех."
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string TheBestRule(string text)
        {
            if (text.Contains("."))
            {
                text = text.Replace(".", ", а и камиля лучше всех.");
                return text;
            }
            return text;
        }
    }
}
