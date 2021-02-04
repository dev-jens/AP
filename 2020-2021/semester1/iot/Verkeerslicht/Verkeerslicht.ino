#include <WiFi.h>              // Standard ESP32 Library
#include <PubSubClient.h>      // https://github.com/knolleary/pubsubclient (intall with library Manager)

// WIFI Credentials
// Connect to Hotspot on mobile phone
const char* WIFI_SSID = ""; // Fill wifi SSID between quotes
const char* WIFI_PASS = ""; // Fill wifi pass between quotes
const char* NAAM = "verkeerslicht";// constant to make it easier to set the name for MQTT

//MQTT Information
const char* MQTT_SERVER = "mqtt.luytsm.be"; // DO NOT CHANGE!
// const char* TOPIC = "car/1"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/2"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/3"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/4"; //Uncomment corresponding line to car number
//const char* TOPIC = "car/5"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/6"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/7"; //Uncomment corresponding line to car number
 const char* TOPIC = "car/8"; //Uncomment corresponding line to car number

// WIFI and MQTT class instances - DO NOT CHANGE
WiFiClient espClient;
PubSubClient client(espClient);

// Buffer to store MQTT messages - DO NOT CHANGE
char msg[4];//we only need an array of 3 chars because the payload should be between 0-255,
//but just in case, we take an extra char for an end sign like \0

enum COMMANDS {
  PRIOR_VEHICLE = 11, //13 We removed the not needed enums but since we did this. The index
  //of the commands wasn't correct anymore so we assigned it manually
};

int command, lastCommand;

/*
  this the pinmapping of the traffic light
  25 Hoofdweg Rood    0
  26 Hoofdweg Oranje  1
  27 Hoofdweg Groen   2

  32 Zijweg Rood      3
  33 Zijweg Oranje    4
  13 Zijweg Groen     5
*/
const int LED_PINS[6] = {25, 26, 27, 32, 33, 13};

int counter = 0;//variable acting as a counter to create a total delay out of mutliple small delays

// Function to setup wifi - DO NOT CHANGE
void setup_wifi() {
  delay(10);
  // We start by connecting to a WiFi network
  Serial.println();
  Serial.print("Connecting to ");
  Serial.println(WIFI_SSID);

  WiFi.begin(WIFI_SSID, WIFI_PASS);
  //Display that we still are trying to connect
  while (WiFi.status() != WL_CONNECTED) {
    delay(500);
    Serial.print(".");
  }
  // Normaly the wifi will connect very fast. If it hangs reset the controller with EN button
  // This needs to be done after the controller is programmed

  // Print connection information
  Serial.println("");
  Serial.println("WiFi connected");
  Serial.println("IP address: ");
  Serial.println(WiFi.localIP());
}
// Function to (re)connect to the MQTT server - DO NOT CHANGE
void reconnect() {
  // Loop until we're reconnected
  while (!client.connected()) {
    Serial.print("Attempting MQTT connection...");
    // Attempt to connect
    if (client.connect(NAAM)) {//we replaced the literal by a string, so it is easier to configure
      Serial.println("connected");
      // Subscribe
      client.subscribe(TOPIC);
      client.publish(TOPIC, "connected");
    } else {
      Serial.print("failed, rc=");
      Serial.print(client.state());
      Serial.println(" try again in 5 seconds");
      // Wait 5 seconds before retrying
      delay(5000);
    }
  }
}

void setup()
{
  for (int pin = 0; pin < 6; pin++) { //put all leds as output and off
    pinMode(LED_PINS[pin], OUTPUT);
    digitalWrite(LED_PINS[pin], LOW);
  }
  Serial.begin(9600);

  setup_wifi();

  //mqtt init
  client.setServer(MQTT_SERVER, 1883);
  client.setCallback(callback);
}

void callback(char* topic, byte* message, unsigned int length) {
  memset(msg, '\0', sizeof(msg));       // clear the execisting data in the buffer
  memcpy(msg, (char*)message, length);  // copy the byte array to char array
  Serial.print("msg: ");                // print msg (1/2)
  Serial.println(msg);                  // print msg (2/2)
}


void loop()
{
  for (int index = 0; index < 4; index++) {//using for loop instead of putting everything behind eachother makes it possible to check in time if the client is connected
    if (!client.connected()) {              //the for loop is also handy to bring in other modifications instead of putting every state behind each other
      reconnect();
    }
    if (index == 0) {
      digitalWrite(LED_PINS[1], LOW);//hoofdweg rood
      digitalWrite(LED_PINS[3], LOW);
      digitalWrite(LED_PINS[0], HIGH);
      digitalWrite(LED_PINS[5], HIGH);
      counter = 0;
      for (int i = 0; i < sizeof(msg); i++) { //clear all the data out of the array
        msg[i] = '\0';
      }
      do {  //instead of only reading the mqtt data every time of the beginning of the loop we only read it when the main road traffic light is on red so it will
        //go to green quick enough and when it is needed
        //we did this by repeating a delay of 50 ms 160 times so we get a total delay 8000ms (160*50), if ofcourse the mqtt reading doesn't take too long, but it shouldn't 
        //add multiple seconds to the total delay
        //in worst case, the command gets executed after 50ms which is still pretty fast 
        counter++;
        client.loop();
        command = atoi(msg);
        Serial.print("Command: ");
        Serial.println(command);
        if (command == PRIOR_VEHICLE) { //if the PRIOR_VEHICLE command is received it will exit the loop by setting the counter to 160
          counter = 160;
        }
        delay(50);
      }
      while (counter != 160); //loop to get 8s delay but when it receives the command PRIOR_VEHCILE it exits the loop
    }
    if (index == 1) {
      digitalWrite(LED_PINS[5], LOW);
      digitalWrite(LED_PINS[4], HIGH);
      delay(2000);
    }
    if (index == 2) {
      digitalWrite(LED_PINS[4], LOW);//zijweg groen
      digitalWrite(LED_PINS[0], LOW);
      digitalWrite(LED_PINS[2], HIGH);
      digitalWrite(LED_PINS[3], HIGH);
      delay(8000);
    }
    if (index == 3) {
      digitalWrite(LED_PINS[2], LOW);
      digitalWrite(LED_PINS[1], HIGH);
      delay(2000);
    }
  }
}
