namespace Lab1_Cesar
{
    using System;
    using System.Text;

    public static class CasarEncryptor
    {
        private const string Dictionary = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijjlmnopqrstuvwxyzабвгґдеєжзиіїйклмнопрстуфхцчшщьюяФБВГҐДЕЄЖЗИІЇКЛМОПРСТУФЧЦЧШЩЬЮЯ 123456789";

        private static readonly bool UseDictionary = false;

        public static readonly int MaxSize = UseDictionary ? Dictionary.Length : Char.MaxValue;

        public static string Encrypt(string text, int key)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var code = GetCodeByIndex(text[i]);
                var newCode = (code + key) % MaxSize;
                sb.Append(GetCahrByIndex(newCode));
            }

            return sb.ToString();
        }

        public static string Encrypt(string text, string key)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var keyCode = GetCodeByIndex(key[i % key.Length]);
                var code = GetCodeByIndex(text[i]);
                var newCode = (code + keyCode) % MaxSize;
                sb.Append(GetCahrByIndex(newCode));
            }

            return sb.ToString();
        }

        public static string Decrypt(string text, int key)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var code = GetCodeByIndex(text[i]);
                var newCode = (code - key);

                if (newCode < 0)
                {
                    newCode = MaxSize - newCode;
                }

                sb.Append(GetCahrByIndex(newCode));
            }

            return sb.ToString();
        }

        public static string Decrypt(string text, string key)
        {
            var sb = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                var keyCode = GetCodeByIndex(key[i % key.Length]);
                var code = GetCodeByIndex(text[i]);
                var newCode = (code - keyCode);

                if (newCode < 0)
                {
                    newCode = MaxSize - newCode;
                }

                sb.Append(GetCahrByIndex(newCode));
            }

            return sb.ToString();
        }

        private static int GetCodeByIndex(char c)
        {
            return UseDictionary
                ? Dictionary.IndexOf(c)
                : (int) c;
        }

        private static char GetCahrByIndex(int i)
        {
            return UseDictionary
                ? Dictionary[i]
                : (char)i;
        }
    }
}