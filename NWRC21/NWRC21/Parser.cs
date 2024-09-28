using System;

namespace NWRC21
{
    public class Parser
    {
        public Work Parse(string[] separatedLine)
        {
            if (separatedLine == null || separatedLine.Length < 3)
                throw new ArgumentException("Invalid input data");

            string service = separatedLine[0].Trim();

            string reqTime = separatedLine[1].Trim();

            string matCosts = separatedLine[2].Trim();


            return new Work(service, reqTime, matCosts);
        }
    }
}
//Hello, Professor for security reasons I added a text sanitization you'll find along the code for the Loading function
//Try to load any other text file (I wanted to make the input of files robust a bit secure)