package Labo1.tvprog;

import java.util.ArrayList;

public class Channel {
    private String channelName;
    private ArrayList<TVprogram> channelList = new ArrayList<>();

    public Channel(String channelName, ArrayList<TVprogram> channelList) {
        this.channelName = channelName;
        this.channelList = channelList;
    }
}
