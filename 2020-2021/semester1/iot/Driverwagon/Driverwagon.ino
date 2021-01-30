// Necessary Libraries
#include <LiquidCrystal_I2C.h> // https://github.com/johnrickman/LiquidCrystal_I2C (install as zip)
#include <WiFi.h>              // Standard ESP32 Library
#include <PubSubClient.h>      // https://github.com/knolleary/pubsubclient (intall with library Manager)
#include<Servo.h>


// WIFI Credentials 
// Connect to Hotspot on mobile phone 
const char* WIFI_SSID = "Car1"; // Fill wifi SSID between quotes
const char* WIFI_PASS = "auto1234"; // Fill wifi pass between quotes

//MQTT Information 
const char* MQTT_SERVER = "mqtt.luytsm.be"; // DO NOT CHANGE!
const char* TOPIC = "car/1"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/2"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/3"; //Uncomment corresponding line to car number
//const char* TOPIC = "car/4"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/5"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/6"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/7"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/8"; //Uncomment corresponding line to car number

// WIFI and MQTT class instances - DO NOT CHANGE
WiFiClient espClient;
PubSubClient client(espClient);

// Buffer to store MQTT messages - DO NOT CHANGE
char msg[32];

// PWM Settings - DO NOT CHANGE
const int PWM_FREQUENCY = 500;
const int PWM_RESOLUTION = 8;
const  int PWM_MAX_DC = 255;

// Motor PWM Pin declarations - DO NOT CHANGE
const int PWM_CHANNEL_COUNT = 4;
const int MOTOR_COUNT = 2;

int MOTOR_PINS[PWM_CHANNEL_COUNT] = {18, 5, 2, 15};
int MOTOR_CHANNELS[PWM_CHANNEL_COUNT] = {0, 1, 2, 3};

// LED PWM Pin declarations - DO NOT CHANGE
const int LED_CHANNEL_COUNT = 4;
const int LED_COUNT = 4;

int LED_PINS[LED_COUNT] = {13, 12, 14, 27};
int LED_CHANNELS[LED_CHANNEL_COUNT] = {4, 5, 6, 7};
int LED_STATE[] = {0, 0, 0, 0};

// Phototransitor Pin Declaration - DO NOT CHANGE 
const int PL_PIN = 25;
const int TRIG_PIN = 19;
const int ECHO_PIN = 23;

// I2C LCD Initialisation 
int LCD_COLUMNS = 16;
int LCD_ROWS = 2;
LiquidCrystal_I2C lcd(0x27, LCD_COLUMNS, LCD_ROWS);

// Enum declaration for commands 
// This is done to ensure that the right value is assigned  to the correct 
// variable and easy usage in switch statement
enum COMMANDS {
  LEFT_TURN_FORWARD,      // 0
  FORWARD,                // 1
  RIGHT_TURN_FORWARD,     // ... 
  RIGHT,
  RIGHT_TURN_BACKWARDS,
  BACKWARDS,
  LEFT_TURN_BACKWARDS,
  LEFT,
  STOP,
  BARRIER_ONE_UP,
  BARRIER_ONE_DOWN,
  PRIOR_VEHICLE,
  BARRIER_TWO_UP,
  BARRIER_TWO_DOWN,     //13
};

// Enum declaration for driving direction  
// This is done to ensure that the right value is assigned  to the correct 
// variable and easy usage in switch statement
enum MOTOR_DIRECTION {
  MOTOR_BACKWARDS = -1,
  MOTOR_STOP = 0,
  MOTOR_FORWARD = 1
};

//variables to store commands and information 
int command, lastCommand;

int drivingSpeed = 128;

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
    if (client.connect("54313351")) {
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


void setup() {
  // Set up serial connection
  // When developing the code necessary for the project, you will need to able to test it. 
  // Do this, you can raise the chassis so the tracks dont connect with the ground but 
  // still are able to roll freely. This was you can test everything in places and have 
  // the wagon driver connected to the PC 
  Serial.begin(115200);

  // init of the PWM Pins 
  for (int i = 0; i < PWM_CHANNEL_COUNT; i++) {
    ledcSetup(MOTOR_CHANNELS[i], PWM_FREQUENCY, PWM_RESOLUTION);
    ledcAttachPin(MOTOR_PINS[i], MOTOR_CHANNELS[i]);
  }
  //init of the LED Pins 
  for (int i = 0; i < LED_COUNT; i++) {
    ledcSetup(LED_CHANNELS[i], PWM_FREQUENCY, PWM_RESOLUTION);
    ledcAttachPin(LED_PINS[i], LED_CHANNELS[i]);
    ledcWrite(LED_CHANNELS[i], 128);
  }
  // init ultrasonic distance sensor
  pinMode(TRIG_PIN, OUTPUT); 
  pinMode(ECHO_PIN, INPUT); 
  pinMode(16,OUTPUT);

  // lcd init 
  lcd.init();
  lcd.backlight();

  // wifi init 
  setup_wifi();

  //mqtt init 
  client.setServer(MQTT_SERVER, 1883);
  client.setCallback(callback);
}

//This function is called when MQTT receives a message 
void callback(char* topic, byte* message, unsigned int length) {
  memset(msg, '\0', sizeof(msg));       // clear the execisting data in the buffer 
  memcpy(msg, (char*)message, length);  // copy the byte array to char array 
  Serial.print("msg: ");                // print msg (1/2)
  Serial.println(msg);                  // print msg (2/2)
}


void loop() {
  // every loop checks if there is a connection with the MQTT server if not
  // reconnect 
  if (!client.connected()) {
    reconnect();
  }

  // every loop we will run the MQTT loop and trigger the callback function if neccesary 
  client.loop();

  //convert the msg Array TO Integer 
  //why this is necesarry will be a bonus  question for the assignment 
  command = atoi(msg);

  // This is the main control structure to handle the incoming statements from MQTT
  // This part doesn't need to be altered if you want to make changes in the 
  // following lines, consult dhr Luyts first 

  if (command != lastCommand) { //The need of this if statement will be a question on the assignment
    Serial.print("Command: ");
    Serial.println(command);
    switch (command) {
      
      case LEFT_TURN_FORWARD:  // Curved turn forward to the left
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_FORWARD, drivingSpeed/2);
        break;
      case FORWARD: // Drive forward
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_FORWARD, drivingSpeed);
        break;
      case RIGHT_TURN_FORWARD: // Curved turn forward to the right
        driveMotors(MOTOR_FORWARD, drivingSpeed/2, MOTOR_FORWARD, drivingSpeed);
        break;
      case RIGHT: // Turn right around center point chassis
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_FORWARD, drivingSpeed);
        break;
      case RIGHT_TURN_BACKWARDS: // Curved turn backwards to the right
        driveMotors(MOTOR_BACKWARDS, drivingSpeed/2, MOTOR_BACKWARDS, drivingSpeed);
        break;
      case BACKWARDS: // Drive backwards
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed);
        break;
      case LEFT_TURN_BACKWARDS: // Curved turn backwards to the right 
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed/2);
        break;
      case LEFT: // Turn left around center point chassis
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed);
        break;
      case STOP: // Stop driving
        driveMotors(MOTOR_STOP, 0, MOTOR_STOP, 0);
        break;
      case BARRIER_ONE_UP: //Raise barrier 1 up
        barrierControl(0, true);
        break;
      case BARRIER_ONE_DOWN: //Lower barrier 1 down
        barrierControl(0, false);
        break;
      case PRIOR_VEHICLE: //Start the priority vehicle protocol 
        priorVehicle();
        break;
      case BARRIER_TWO_UP: //Raise barrier 2 up
        barrierControl(1, true);
        break;
      case BARRIER_TWO_DOWN: //Lower barrier 2 down
        barrierControl(1, false);
        break;
      default: //Set the driving speed 
        drivingSpeed = command;
        break;
    }
    lastCommand = command; //Another question on the assignment, why is this statement necessary 
    lcd.print(lastCommand); // print het laatste command  om het lcd scherm
  }
}

// This function you need to develop as part of the assignment
// This function is called in the switch statement in the main loop. The goals
// of this function is to control the motors. Try to write a function that can 
// handle the parameters. Subfunctions are allowed, hardcoded statements are
// frowned upon 

void driveMotors(int leftMotorDirection, int leftMotorSpeed, int rightMotorDirection, int rightMotorSpeed) {
    switch(leftMotorDirection){
    case MOTOR_BACKWARDS: // enum waarde
      // stuurt leftmotorspeed naar de (1A) input op de hbrug. Dit zorgt er voor dat de auto achteruit kan rijden.
      ledcWrite(MOTOR_CHANNELS[0], leftMotorSpeed);
      ledcWrite(MOTOR_CHANNELS[1], 0);
      break;
    case MOTOR_STOP: // enum
      // stuurt 0 naar beide inputs waardoor de motor stopt
      ledcWrite(MOTOR_CHANNELS[0], 0);
      ledcWrite(MOTOR_CHANNELS[1], 0);
      break;
    case MOTOR_FORWARD: // enum
      //stuurt leftMotorSpeed naar de (1B) input op de hbrug. Dit zorgt er voor dat de auto vooruit kan rijden
      ledcWrite(MOTOR_CHANNELS[0], 0);
      ledcWrite(MOTOR_CHANNELS[1], leftMotorSpeed);
      break;
  }

  // RIGHT MOTOR
  switch(rightMotorDirection){
    case MOTOR_BACKWARDS: // enum
      // stuurt rightmotorspeed naar de (2A) input op de hbrug. Dit zorgt er voor dat de auto achteruit kan rijden.
      ledcWrite(MOTOR_CHANNELS[2], rightMotorSpeed);
      ledcWrite(MOTOR_CHANNELS[3], 0);
      break;
    case MOTOR_STOP: // enum
      ledcWrite(MOTOR_CHANNELS[2], 0);
      ledcWrite(MOTOR_CHANNELS[3], 0);
      break;
    case MOTOR_FORWARD: // enum
      // stuurt rightmotorspeed naar de (2B) input op de hbrug. Dit zorgt er voor dat de auto vooruit kan rijden.
      ledcWrite(MOTOR_CHANNELS[2], 0);
      ledcWrite(MOTOR_CHANNELS[3], rightMotorSpeed);
      break;
  }
}


// This function you need to develop as part of the assignment
// this function will handle the barrier control. The goal of this function is
// control both barriers based on the parameters. Subfunctions are allowed,
// hardcoded statements are frowned upon 
// You give the ID of the barrier (0,1) and a true or false as parameters with the barrierControl function
Servo barrier; 

void barrierControl(int barrierID, bool setBarrier) {
  // The first switch checks if the ID is 0 or 1, the second switch checks if the setBarrier parameters has true or false
    switch (barrierID) {
      // In case that barrierID is 0, the first barrier will go up if true, if false the barrier will go down  
    case 0:
    switch (setBarrier) {

      case true:
        barrier.attach(34);
        barrier.write(90);
        Serial.print("omhoog");
      break;
      case false:
        barrier.attach(10);
        barrier.write(0);
        Serial.print("omalaag");
      break;
    }
    break;
    // In case that barrierID is 1, the second barrier will go up if true, if false the barrier will go down
    case 1:
    switch (setBarrier) {

       case true:
        barrier.attach(11);
        barrier.write(90);
        Serial.print("omhoog");
      break;
      case false:
        barrier.attach(11);
        barrier.write(0);
        Serial.print("omalaag");
      break;
    }
    break;
  }
}



// This function you need to develop as part of the assignment
// this function will handle the priority vehicle protocol. Subfunctions are 
// allowed, hardcoded statements are frowned upon 
void priorVehicle() {
  
}
