
using System.Runtime.CompilerServices;

public class Word
    {
        private string _word;
        private bool _hidden;

        public Word()
        {
            _word = "";
            _hidden = false;
        }
        public Word(string word)
        {
            _word = word;
            _hidden = false;
        }
        public Word(string word, bool hide)
        {
            _word = word;
            _hidden = hide;
        }
        public string GetWord()
        {
            return _word;
        }
        public bool CheckHidden()
        {
            return _hidden;
        }
        public void HideWord()
        {
            int length = _word.Length;
            string blanked = "";
            int i = 0;
            while ( i < length)
            {
                blanked = blanked + "_";
                i++;
            }
            _word = blanked;
            _hidden = true;
        }
    }