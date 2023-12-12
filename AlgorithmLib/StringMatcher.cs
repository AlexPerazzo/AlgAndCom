using Microsoft.VisualBasic.CompilerServices;

namespace AlgorithmLib;

public static class StringMatcher
{
    private static List<Dictionary<char, int>> BuildTable(string pattern, List<char> inputs)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var table = new List<Dictionary<char, int>>();

        //loop through once for each char in pattern +1 for base case
        for (var k = 0; k < pattern.Length + 1; k++)
        {
            var map = new Dictionary<char, int>();
            foreach (var letter in inputs)
            {
                //check last letters in pattern
                var pkLetter = pattern[..k] + letter;
                var temp = new List<int>();
                temp.Add(k+1);
                temp.Add(pattern.Length);
                var i = temp.Min();
                
                while (!pkLetter.EndsWith(pattern[..i]))
                {
                    i -= 1;
                }

                map[letter] = i;
            }
            table.Add(map);
        }
        
        return table;
    }
    
    public static List<int> Match(string text,  string pattern, List<char> inputs)
    {
        //table is a list of dictionaries
        // ADD CODE HERE AND FIX RETURN STATEMENT
        
        //build own table using other function
        
        var table = BuildTable(pattern, inputs);
        
        var state = 0;
        var match_state = table.Count - 1;
        var results = new List<int>();

        for (var index = 0; index < text.Length; index++)
        {
            state = table[state][text[index]];

            // If we're in the match state, then you're good! So add it to the results
            if (state == match_state)
            {
                results.Add(index);
            }
        }
        
        return results;
    }
    
}