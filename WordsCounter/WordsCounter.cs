namespace WordsCounter
{
    public class WordInfo
    {
        public string Word { get; set; }
        public int Frequency { get; set; }
    }
    public class TextAnalyzer
    {
        private string[] words;
        private WordInfo[] wordInfoArray;

        public TextAnalyzer(string text)
        {
            words = text.Split(new[] { ' ', '.', ',', ';', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
            CountWordInfo();
        }

        private void CountWordInfo()
        {
            int uniqueWordCount = 0;
            string[] uniqueWords = new string[words.Length];
            int[] wordFrequency = new int[words.Length];

            for (int i = 0; i < words.Length; i++)
            {
                string lowercasedWord = words[i].ToLower();

                bool isUnique = true;
                for (int j = 0; j < uniqueWordCount; j++)
                {
                    if (uniqueWords[j] == lowercasedWord)
                    {
                        wordFrequency[j]++;
                        isUnique = false;
                        break;
                    }
                }

                if (isUnique)
                {
                    uniqueWords[uniqueWordCount] = lowercasedWord;
                    wordFrequency[uniqueWordCount] = 1;
                    uniqueWordCount++;
                }
            }

            Array.Resize(ref uniqueWords, uniqueWordCount);
            Array.Resize(ref wordFrequency, uniqueWordCount);

            wordInfoArray = new WordInfo[uniqueWordCount];

            for (int i = 0; i < uniqueWordCount; i++)
            {
                wordInfoArray[i] = new WordInfo
                {
                    Word = uniqueWords[i],
                    Frequency = wordFrequency[i]
                };
            }
        }

        public WordInfo[] GetWords()
        {
            var sortedWords = wordInfoArray.OrderByDescending(wordInfo => wordInfo.Frequency);

            return sortedWords.ToArray();
        }
    }
}
