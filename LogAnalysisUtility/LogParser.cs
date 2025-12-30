using System;
using System.Text.RegularExpressions;
namespace LogProcessing{
    class LogParser{
        private readonly string validLineRegexPattern =
            @"^\[(TRC|DBG|INF|WRN|ERR|FTL)\]";

        private readonly string splitLineRegexPattern =
            @"<\*\*\*>|<====>|<\^\*>";

        private readonly string quotedPasswordRegexPattern =
            "(?i)\".*?password.*?\"";

        private readonly string endOfLineRegexPattern =
            @"end-of-line\d+$";

        private readonly string weakPasswordRegexPattern =
            @"(?i)\b(password[a-z0-9]+)\b";
       
        public bool IsValidLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return false;

            return Regex.IsMatch(text, validLineRegexPattern);
        }

        
        public string[] SplitLogLine(string text)
        {
            if (string.IsNullOrEmpty(text))
                return new string[0];

            return Regex.Split(text, splitLineRegexPattern);
        }

        
        public int CountQuotedPasswords(string lines)
        {
            if (string.IsNullOrEmpty(lines))
                return 0;

            MatchCollection matches =
                Regex.Matches(lines, quotedPasswordRegexPattern);

            return matches.Count;
        }

       
        public string RemoveEndOfLineText(string line)
        {
            if (string.IsNullOrEmpty(line))
                return line;

            return Regex.Replace(line, endOfLineRegexPattern, "");
        }

        
        public string[] ListLinesWithPasswords(string[] lines)
        {
            string[] result = new string[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                Match m = Regex.Match(lines[i], weakPasswordRegexPattern);

                if (m.Success)
                    result[i] = m.Groups[1].Value + ": " + lines[i];
                else
                    result[i] = "--------: " + lines[i];
            }

            return result;
        }
        
    }
}