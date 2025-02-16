
using System.Dynamic;
using System.Runtime.CompilerServices;

public class Scripture
    {
        private string _reference;
        private Verse _verse;

        public Scripture()
        {
            _verse = new Verse();
            _reference = "";
        }
        public Scripture(string verse)
        {
            _verse = new Verse(verse);
            _reference = "";
        }
        public Scripture(string refrence, string verse)
        {
            _verse = new Verse(verse);
            _reference = refrence;
        }
        public string GetScripture()
        {
            string _scripture = _reference + " - " + _verse.GetVerse();
            return _scripture;
        }
        public void HideWords(int numberofwords)
        {
            int i = 0;
            while (i < numberofwords)
            {
                if (_verse.CheckAllHidden() == false)
                {
                    _verse.HideRandomWord();
                    i++;
                }
                else 
                {
                    i = numberofwords;
                }
            }
        }
        public bool CheckDone()
        {
            return _verse.CheckAllHidden();
        }
    }