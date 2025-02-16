
using System.Runtime.CompilerServices;

public class Verse
    {
        private List<Word> _words;
        
        public Verse()
        {
            _words = new List<Word>();
        }
        public Verse(string text)
        {
            _words = new List<Word>(); // Add this line
            string[] words = text.Split(' ');
            foreach (var word in words)
            {
                _words.Add(new Word(word));
            }
        }

        public string GetVerse()
        {
            string verse = "";
            foreach (var word in _words)
            {
                verse = verse + word.GetWord() + " ";
            }
            return verse;
        }
        public void HideRandomWord()
        {
            int i = 0;
            Random rnd = new Random();
            while (i < 1){
                
                int index = rnd.Next(_words.Count);
                if ( _words[index].CheckHidden() == false)
                {
                    _words[index].HideWord();
                    i++;
                }

            }
            
        }
        public bool CheckAllHidden()
        {
            foreach (var word in _words)
            {
                if (!word.CheckHidden()) 
                {
                    return false; 
                }
            }
            return true;
        }

    }