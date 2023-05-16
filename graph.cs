using System;

public class graph {
    private Dictionary<string, node> visited = new Dictionary<string, node>();
    private Dictionary<string, node> unvisited = new Dictionary<string, node>();
    private int size = 0;
    private int discovery = 0;
    private Dictionary<string, node> tempDist = new Dictionary<string, node>();
    public node addNode(string id) {
        node newNode = new node(id);
        unvisited.Add(id,newNode);
        this.size++;
        return newNode;
    }

    public void joinNode(string id1, string id2,int cost, int duration, List<int> id1Departures, List<int> id2Departures) {
        node Node1 = getNode(id1);
        node Node2 = getNode(id2);

        Node1.addAdjacenct(Node2,cost,duration,id1Departures,id2Departures);
    }

    private node getNode(string id) {
        if (unvisited.ContainsKey(id)) {
            return unvisited[id];
        } else {
            return this.addNode(id);
        }
    }

    public node Get(string id) {
        if (unvisited.ContainsKey(id)) {
            return unvisited[id];
        } else {
            return null;
        }
    }

    public List<node> planJourney(string sourse, string dest){ 
        node startNode = getNode(sourse);
        startNode.setNodeCost(0);
        node endNode = iterateGraph(startNode,dest);

        List<node> shortestPath = new List<node>(0);

        while (endNode != startNode) {
            shortestPath.Insert(0,endNode);
            endNode = endNode.getPathParent();
        }
        shortestPath.Insert(0,startNode);

        return shortestPath;
    }

    public node iterateGraph(node current, string dest, int arrivalTime = 0){
        if (current.getId() == dest | current.getId() == "null") {
            return current;
        }

        List<path> adajacentList = current.getAdjacent();

        for (int index = 0; index < adajacentList.Count(); index++) {
            path route = adajacentList[index];
            node destination = route.getDestination();

            int newCost = route.getFee() + current.getNodeCost();
            if (newCost < destination.getNodeCost()) {
                if (route.busAvailable(arrivalTime)) {
                    destination.setNodeCost(newCost);
                    destination.setPathParent(current);
                    destination.setArrivalTime(route.getArrivalTime(arrivalTime));
                }
            }
        }

        visited.Add(current.getId(),current);
        unvisited.Remove(current.getId()); 
        node nextNode = dummyQueue(); //This is 0(destination)

        if (nextNode == null) {
            return null;
        }

        return iterateGraph(nextNode,dest,nextNode.getArrivalTime());
    }

    public node dummyQueue() {
        int smallest = int.MaxValue;
        node thang = null;
        foreach (KeyValuePair<string, node> pair in unvisited)
        {
            if (pair.Value.getNodeCost() < smallest) {
                smallest = pair.Value.getNodeCost();
                thang = pair.Value;
            }
        }

        return thang;
    }

}