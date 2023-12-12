namespace AlgorithmLib;

public static class HuffmanTree
{
    public class Node
    {
        public char Letter { get; set; }
        public float Count { get; set; }
        
        public Node? Left;
        public Node? Right;
    }

    public static Dictionary<char,int> Profile(String text)
    {
        
        var profile = new Dictionary<char, int>();
        //figure out count of each character in text
        foreach (char letter in text)
        {
            // if it's already in there, add 1 to its count
            if (profile.ContainsKey(letter))
            {
                profile[letter] += 1;
            }
            // otherwise initialize it
            else
            {
                profile[letter] = 1;
            }
        }
        return profile;
    }
    public static Node BuildTree(Dictionary<char, int> profile)
    {
        
        var q = new PriorityQueue<Node>();

        foreach (var letter in profile.Keys)
        {
            //make nodes using our profile dictionary
            var node = new Node();
            node.Letter = letter;
            node.Count = profile[letter];
            //insert them into a priority queue so they're ordered
            q.Insert(node, node.Count);
        }

        //join all nodes into one big tree
        while (q.Size() > 1)
        {
            //get two most infrequent nodes left
            var first = q.Dequeue();
            var second = q.Dequeue();
            var joinNode = new Node();
            //join them through a node
            joinNode.Count = first.Count + second.Count;
            joinNode.Left = first;
            joinNode.Right = second;
            //add that node back into the queue
            q.Insert(joinNode, joinNode.Count);
        }

        //last thing left over is all the nodes connected
        return q.Dequeue();
    }

    public static Dictionary<char, string> CreateEncodingMap(Node root)
    {
        var map = new Dictionary<char, string>();
        //call recursive function
        CreateEncodingMapHelper(root, "", map);
        return map;
    }
    public static void CreateEncodingMapHelper(Node node, string code, Dictionary<char, string> map)
    {
        if (node is null)
        {
            return;
        }

        // if it's a leaf, add it the map
        if (node.Left is null && node.Right is null)
        {
            if (code.Length == 0)
            {
                map[node.Letter] = "1";
            }
            else
            {
                map[node.Letter] = code;
            }
        }
        else
        {
            //recursively go down the left and the right paths
            CreateEncodingMapHelper(node.Left, code + "0", map);
            CreateEncodingMapHelper(node.Right, code + "1", map);
        }
        
    }

    public static string Encode(string text, Dictionary<char, string> map)
    {
        
        var result = "";
        //look up letter and add it to the result
        foreach (var letter in text)
        {
            var encLetter = map[letter];
            result += encLetter;
        }
        return result;
    }

    public static string Decode(string text, Node tree)
    {
        // ADD CODE HERE AND FIX RETURN STATEMENT
        var result = "";
        var currNode = tree;
        foreach (var letter in text)
        {
            //Traverse tree
                if (letter == '0')
                {
                    currNode = currNode.Left;
                }
                else
                {
                    currNode = currNode.Right;
                }

                //once you get to a leaf, add letter and reset
                if (currNode.Left == null && currNode.Right == null)
                {
                    result += currNode.Letter;
                    currNode = tree;
                }
        }
        return result;
    }
}