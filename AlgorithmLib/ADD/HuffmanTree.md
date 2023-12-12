# Algorithm Description Document

Author: Alexander Perazzo

Date: 11/13/23

## 1. Name
Huffman Tree Compression

## 2. Abstract
The base idea is to know the frequency of each letter in the text. We want the most frequent letters to have the shortest path to them in order to save data. You make a big tree using a priority queue so their frequency is in order. With this big tree, you can assign the codes to each path.

## 3. Methodology
Start off by cycling through the text and determining how many of each letter appears in the text.
We take this information and insert them into Nodes. Then you insert all of these Nodes into a priority queue.
The priority queue will allow us to return them in order of least frequent to most frequent.
We connect the two smallest nodes with a join_node (a node that has its left and right set to the two smaller nodes and value with a combined value of the two nodes). We reinsert this back into the priority queue which allows us join nodes over and over into one big tree.
We repeat that process until you have one tree.

With this tree, we can make an encoding map. Each time we travel left through the tree, we add a 0 to that letter's code. Each time we travel right, we add a 1.

With this encoding map, we can encode by going through the letters in the text and we simply add it's encoded version to a result string instead.

To decode, we loop through the encoded text and use the tree. If the letter is 0 we go to the left of the tree, if it's 1 we go to the right of the tree. Once you hit a leaf, you add that leaf's letter to a result string.


## 4. Pseudocode

```
PROFILE(text)
SET profile to new DICTIONARY (also known as hashset)
FOR letter IN text:
    IF letter IN profile:
        profile[letter] = profile[letter] + 1
    OTHERWISE:
        profile[letter] = 1
RETURN profile
        


BUILD-TREE(profile)

INITIALIZE p_queue <- PriorityQueue

FOR letter in profile.keys:
    INITIALIZE node <- Node
    node.letter <- letter
    node.count <- profile[letter]
    p_queue.insert(node, node.count) (Add new node into the priority queue)
    
(cycle until there's just one tree)
WHILE p_queue.size > 1:
    (Get first two nodes from priority queue)
    INITIALIZE first <- p_queue.dequeue()
    INITIALIZE second <- p_queue.dequeue()
    
    (make a bigger node that connects the two nodes)
    INITIALIZE join_node <- Node
    join_node.count <- first.count + second.count
    join_node.left <- first
    join_node.right <- second

    (reinsert bigger node into priority queue)
    p_queue.insert(join_node, join_node.count)
    
(return tree)
return p_queue.dequeue()


CREATE-ENCODING-MAP(node, code, map)
RECURSIVE, SO YOU NEED BASE CASES.
BASE CASE 1:
IF node is null:
    RETURN
    
BASE CASE 2:
IF node is leaf:
    IF only node:
        map[node.letter] = "1"
    OTHERWISE:
        map[node.letter] = code
OTHERWISE:
    (Recursively call down the left and right sides, except add a 0 to the code if you go left and a 1 if you go right)
    CREATE-ENCODING-MAP(node, code + "0", map)
    CREATE-ENCODING-MAP(node, code + "1", map)



ENCODE(text, map)
INITIALIZE string result <- ""
FOR letter IN text:
    result <- result + map[letter]
    
RETURN result


DECODE(text, tree)
INITIALIZE string result <- ""
current_path <- tree (Make duplicate of tree to use)

FOR letter IN text:
    IF letter is 0:
        current_path <- current_path.Left (Go down left path of tree)
    IF letter is 1:
        current_path <- current_path.Right (Go down right path of tree)
    
    IF node is leaf:
        result <- result + tree.Letter (add letter to result)
        current_path <- tree (reset current_path to root node in tree)

RETURN result
```

## 5. Inputs & Outputs

List only inputs and outputs for Encode and Decode functions.

Inputs:
    Encode:
        Map: Dictionary. This dictionary has keys of each letter that appears in the text -- the values of those keys is the number of times that letter appears in the text.
        Text: String. This is a string of the information you want to compress
    Decode:
        Tree: Node. This is a class where each node can have a node connected to its right and left. It also has a value and a letter (the letter is the letter (as expected) and the value is the amount of times that letter appears in the text.)
        Text: String. This is the string of the compressed information you want to decompress.

Outputs:
    Encode:
        Result: String that is the original text but now represented in 1's and 0's according to the HuffmanTree that was built.
    Decode:
        Result: String which is identical to the original text.


## 6. Analysis Results

Encode Function:
* Worst Case: $O(n)$

* Best Case: $\Omega(n)$


Decode Function:
* Worst Case: $O(n)$

* Best Case: $\Omega(n)$


