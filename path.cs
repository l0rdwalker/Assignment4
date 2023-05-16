using System;


public class path {
    private node destination; 
    private int fee; 
    private List<int> departures;
    private int duration;
    public path(node newKey, int fee, int duration, List<int> departures) {
        this.destination = newKey;
        this.fee = fee;
        this.departures = new List<int>(departures);
        this.duration = duration;
    }

    public node getDestination() {
        return this.destination;
    }

    public int getFee() {
        return this.fee;
    }

    public int getDuration() {
        return this.duration;
    }

    public int getArrivalTime(int departureTime) {
        for (int i = 0; i < this.departures.Count(); i++) {
            if (departureTime <= this.departures[i]) {
                return this.departures[i] + duration;
            }
        }
        return -1;
    }

    public bool busAvailable(int departureTime) {
        for (int i = 0; i < this.departures.Count(); i++) {
            if (departureTime <= this.departures[i]) {
                return true;
            }
        }
        return false;
    }
}