using System;

public class node {
    private List<path> adjacencyList = new List<path>();
    private string id;
    private int cost = int.MaxValue;
    private node parent = null; 
    private int arrival = 0;
    
    public node(string id) {
        this.id = id;
    }

    public node() {
        this.id = "null";
    }

    public node getPathParent() {
        return this.parent;
    }

    public void setPathParent(node newParent) {
        this.parent = newParent;
    }

    public void setArrivalTime(int time) {
        this.arrival = time;
    }

    public int getArrivalTime() {
        return this.arrival;
    }

    public void setNodeCost(int newCost) {
        this.cost = newCost;
    }

    public int getNodeCost() {
        return this.cost;
    }

    public string getId() {
        return this.id;
    }

    public List<path> getAdjacent() {
        return this.adjacencyList;
    }

    public void addAdjacenct(node Node,int cost,int duration,List<int> id1Departures,List<int> id2Departures, bool origin = true) {
        if (origin) {
            this.adjacencyList.Add(new path(Node,cost,duration,id1Departures));
        } else {
            this.adjacencyList.Add(new path(Node,cost,duration,id2Departures));
        }
    
        if (origin) {
            Node.addAdjacenct(this,cost,duration,id2Departures,id2Departures,false);
        }
    }
}