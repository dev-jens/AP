package edu.ap.jbaeten;

import java.util.ArrayList;

public class TVChannel {
    String name;
    ArrayList<TVShows> list = new ArrayList<TVShows>();

    public TVChannel(String name, ArrayList<TVShows> list) {
        this.name = name;
        this.list = list;
    }
}
