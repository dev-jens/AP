package labo1.TVzender;

import java.util.ArrayList;

public class TVchannel {

    private String channelName;
    private ArrayList<TVprogram> channelList = new ArrayList<>();

    public TVchannel(String channelName, ArrayList<TVprogram> channelList) {
        this.channelName = channelName;
        this.channelList = channelList;
    }
}
