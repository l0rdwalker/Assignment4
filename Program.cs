using System;

class Program
{
    static void Main(string[] args)
    {
        graph myGraph = new graph();
        myGraph.joinNode("A", "B", 6, 30, new List<int> { 11 }, new List<int> { 11 });
        myGraph.joinNode("B", "I", 9, 30, new List<int> { 10 }, new List<int> { 10 });
        myGraph.joinNode("B", "D", 3, 30, new List<int> { 9 }, new List<int> { 9 });
        myGraph.joinNode("I", "D", 4, 30, new List<int> { 8 }, new List<int> { 8 });
        myGraph.joinNode("I", "C", 10, 30, new List<int> { 7 }, new List<int> { 7 });
        myGraph.joinNode("D", "H", 5, 30, new List<int> { 6 }, new List<int> { 6 });
        myGraph.joinNode("C", "H", 7, 30, new List<int> { 5 }, new List<int> { 5 });
        myGraph.joinNode("C", "G", 8, 30, new List<int> { 4 }, new List<int> { 4 });
        myGraph.joinNode("G", "E", 11, 30, new List<int> { 3 }, new List<int> { 3 });
        myGraph.joinNode("G", "F", 2, 30, new List<int> { 2 }, new List<int> { 2 });
        myGraph.joinNode("F", "E", 12, 30, new List<int> { 1 }, new List<int> { 1 });
        
        /*
        myGraph.joinNode("A", "B", 6, 30, new List<int> { 480, 540, 600 }, new List<int> { 510, 570, 630 });
        myGraph.joinNode("B", "I", 9, 30, new List<int> { 630, 720, 810 }, new List<int> { 660, 750, 840 });
        myGraph.joinNode("B", "D", 3, 30, new List<int> { 570, 660, 780 }, new List<int> { 600, 690, 810 });
        myGraph.joinNode("I", "D", 4, 30, new List<int> { 840, 930, 1020 }, new List<int> { 870, 960, 1050 });
        myGraph.joinNode("I", "C", 10, 30, new List<int> { 870, 960, 1080 }, new List<int> { 900, 990, 1110 });
        myGraph.joinNode("D", "H", 5, 30, new List<int> { 690, 810, 930 }, new List<int> { 720, 840, 960 });
        myGraph.joinNode("C", "H", 7, 30, new List<int> { 900, 990, 1110 }, new List<int> { 930, 1020, 1140 });
        myGraph.joinNode("C", "G", 8, 30, new List<int> { 900, 990, 1110 }, new List<int> { 930, 1020, 1140 });
        myGraph.joinNode("G", "E", 11, 30, new List<int> { 1020, 1110, 1170 }, new List<int> { 1050, 1140, 1230 });
        myGraph.joinNode("G", "F", 2, 30, new List<int> { 480, 540, 600 }, new List<int> { 510, 570, 630 });
        myGraph.joinNode("F", "E", 12, 30, new List<int> { 1140, 1200, 1290 }, new List<int> { 1200, 1260, 1350 });
        */
        //myGraph.joinNode("G", "F", 2, 30, new List<int> { 1020, 1110, 1170 }, new List<int> { 1050, 1140, 1230 });
        //myGraph.joinNode("F", "E", 12, 30, new List<int> { 1140, 1200, 1290 }, new List<int> { 1200, 1260, 1350 });
        
        myGraph.planJourney("A","F");
    }


}
