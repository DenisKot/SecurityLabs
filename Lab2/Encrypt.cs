namespace Lab2
{
    using System.Collections.Generic;
    using System.Text;

    public class Encrypt
    {
        private const string Dictionary = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijjlmnopqrstuvwxyzабвгґдеєжзиіїйклмнопрстуфхцчшщьюяФБВГҐДЕЄЖЗИІЇКЛМОПРСТУФЧЦЧШЩЬЮЯ 123456789";
        private static readonly int DictionaryLenght = Dictionary.Length;

        public string EncrypteByLineralMethod(string text, int a, int b, int x, int m, ref List<int> list)
        {
            var cryptedArray = new List<int>();
            var cryptKeys = this.GetCryptKeys(x, a, b, m);
            list.AddRange(cryptKeys);
            var textIndexes = this.StringToIntArray(text);

            for (int i = 0; i < textIndexes.Count; i++)
            {
                var cryptKeyIndex = i % cryptKeys.Count;
                var offset = cryptKeys[cryptKeyIndex];
                var newVal = (textIndexes[i] + offset) % DictionaryLenght;
                cryptedArray.Add(newVal);
            }

            return this.IntToStringArray(cryptedArray);
        }

        public string DecryptByLineralMethod(string text, int a, int b, int x, int m)
        {
            var cryptedArray = new List<int>();
            var cryptKeys = this.GetCryptKeys(x, a, b, m);
            var textIndexes = this.StringToIntArray(text);

            for (int i = 0; i < textIndexes.Count; i++)
            {
                var cryptKeyIndex = i % cryptKeys.Count;
                var offset = cryptKeys[cryptKeyIndex];
                var newVal = textIndexes[i] - offset;
                if (newVal < 0)
                    newVal = DictionaryLenght + newVal;
                cryptedArray.Add(newVal);
            }

            return this.IntToStringArray(cryptedArray);
        }

        public int GetIndex(char c)
        {
            return Dictionary.IndexOf(c);
        }

        private IList<int> StringToIntArray(string text)
        {
            var arr = new List<int>();
            foreach (var c in text)
            {
                arr.Add(Dictionary.IndexOf(c));
            }
            return arr;
        }

        private string IntToStringArray(IEnumerable<int> charIndexes)
        {
            var sb = new StringBuilder();
            foreach (var index in charIndexes)
            {
                sb.Append(Dictionary[index]);
            }

            return sb.ToString();
        }

        private List<int> GetCryptKeys(int x, int a, int b, int m)
        {
            var crypKey = new List<int>() { x };
            
            while (true)
            {
                x = (a * x + b) % m;
                if(crypKey.Contains(x)) break;
                crypKey.Add(x);
            }

            return crypKey;
        }
    }
}