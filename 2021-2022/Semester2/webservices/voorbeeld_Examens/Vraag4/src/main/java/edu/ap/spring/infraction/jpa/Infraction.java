package edu.ap.spring.infraction.jpa;

public class Infraction implements Comparable<Infraction> {
    public int id;

    public String year;

    public String month;

    public String date;

    public String street;

    public String driving_direction;

    public String speed_limit;

    public String passersby;

    public String infractions_speed;

    public String infractions_red_light;

    public int compareTo(Infraction ov){
        try{
            if (Integer.parseInt(this.infractions_speed) == Integer.parseInt(ov.infractions_speed))
            return 0;
            else if(Integer.parseInt(this.infractions_speed) > Integer.parseInt(ov.infractions_speed))
            return 1;
            else 
            return -1;
        }
        catch(Exception ex){
            return -1;
        }
    }
}
