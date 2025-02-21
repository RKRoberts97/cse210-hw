
using System.Runtime.CompilerServices;

public class MathAssignment : Assignment
    {
        private string _textbookSection;
        private string _problems;

        public MathAssignment(string name, string topic, string sections, string problems) : base(name, topic) 
        {
            _textbookSection = sections;
            _problems = problems;

        }

        public string GetHomeworkList()
        {
            return GetSummary() + "\n" + _textbookSection + " " + _problems;
        }

        
    }