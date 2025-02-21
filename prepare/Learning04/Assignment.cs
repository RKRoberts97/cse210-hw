
using System.Runtime.CompilerServices;

public class Assignment
    {
        private protected string _studentName;
        private string _topic;

        public Assignment()
        {
            _studentName = "";
            _topic = "";
        }

        public Assignment(string name)
        {
            _studentName = name;
            _topic = "";
        }

        public Assignment(string name, string topic)
        {
            _studentName = name;
            _topic = topic;
        }

        public string GetSummary()
        {
            return _studentName + " - " + _topic;
        }

        
    }