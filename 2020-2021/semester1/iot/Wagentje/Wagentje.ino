#include <LiquidCrystal_I2C.h> // https://github.com/johnrickman/LiquidCrystal_I2C (install as zip)
#include <WiFi.h>              // Standard ESP32 Library
#include <PubSubClient.h>      // https://github.com/knolleary/pubsubclient (intall with library Manager)

// WIFI Credentials
// Connect to Hotspot on mobile phone
const char* WIFI_SSID = ""; // Fill wifi SSID between quotes
const char* WIFI_PASS = ""; // Fill wifi pass between quotes
const char* NAAM = "auto";  // constant to make it easier to set the name for MQTT

//MQTT Information
const char* MQTT_SERVER = "mqtt.luytsm.be"; // DO NOT CHANGE!
// const char* TOPIC = "car/1"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/2"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/3"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/4"; //Uncomment corresponding line to car number
const char* TOPIC = "car/5"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/6"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/7"; //Uncomment corresponding line to car number
// const char* TOPIC = "car/8"; //Uncomment corresponding line to car number

// WIFI and MQTT class instances - DO NOT CHANGE
WiFiClient espClient;
PubSubClient client(espClient);

// Buffer to store MQTT messages - DO NOT CHANGE
char msg[4];//we only need an array of 3 chars because the payload should be between 0-255,
//but just in case, we take an extra char for an end sign like \0

const int PWM_FREQUENCY = 500;
const int PWM_RESOLUTION = 8;
const int PWM_MAX_DC = 255;

// Motor PWM Pin declarations - DO NOT CHANGE
const int PWM_CHANNEL_COUNT = 4;
const int MOTOR_COUNT = 2;

int MOTOR_PINS[PWM_CHANNEL_COUNT] = {18, 5, 2, 15}; //we use pin 2 and 5 as direction pin and pin 18 and 15 as speed pin
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
  LEFT_TURN_FORWARD,      // 0 We removed the not needed enums but since we did this
  FORWARD,                // 1
  RIGHT_TURN_FORWARD,     // ...
  RIGHT,
  RIGHT_TURN_BACKWARDS,
  BACKWARDS,
  LEFT_TURN_BACKWARDS,
  LEFT,
  STOP,
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
  driveMotors(MOTOR_STOP, 0, MOTOR_STOP, 0); //put every motor off since when the ESP starts up, the motors start spinning
  //init of the LED Pins
  for (int i = 0; i < LED_COUNT; i++) {
    ledcSetup(LED_CHANNELS[i], PWM_FREQUENCY, PWM_RESOLUTION);
    ledcAttachPin(LED_PINS[i], LED_CHANNELS[i]);
  }
  // init ultrasonic distance sensor
  pinMode(TRIG_PIN, OUTPUT);
  pinMode(ECHO_PIN, INPUT);

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
  //why this is necesarry will be a bonus  question for the assignment -> the data received will be an array,
  //but since we need an integer to compare to, we need to change the variable type, that's where atio comes into play
  command = atoi(msg);

  // This is the main control structure to handle the incoming statements from MQTT
  // This part doesn't need to be altered if you want to make changes in the
  // following lines, consult dhr Luyts first

  if (command != lastCommand) { //The need of this if statement will be a question on the assignment
    //->this statement will check if we received new data from MQTT
    //if we don't do this, the last command received will every time get executed
    Serial.print("Command: ");
    Serial.println(command);
    lcd.clear();
    switch (command) {
      case LEFT_TURN_FORWARD:  // Curved turn forward to the left
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_FORWARD, drivingSpeed / 2);
        lcd.print("forward left");
        break;
      case FORWARD: // Drive forward
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_FORWARD, drivingSpeed);
        lcd.print("forward");
        break;
      case RIGHT_TURN_FORWARD: // Curved turn forward to the right
        driveMotors(MOTOR_FORWARD, drivingSpeed / 2, MOTOR_FORWARD, drivingSpeed);
        lcd.print("forward right");
        break;
      case RIGHT: // Turn right around center point chassis
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_FORWARD, drivingSpeed);
        lcd.print("right");
        break;
      case RIGHT_TURN_BACKWARDS: // Curved turn backwards to the right
        driveMotors(MOTOR_BACKWARDS, drivingSpeed / 2, MOTOR_BACKWARDS, drivingSpeed);
        lcd.print("backwards right");
        break;
      case BACKWARDS: // Drive backwards
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed);
        lcd.print("backwards");
        break;
      case LEFT_TURN_BACKWARDS: // Curved turn backwards to the right
        driveMotors(MOTOR_BACKWARDS, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed / 2);
        lcd.print("backwards left");
        break;
      case LEFT: // Turn left around center point chassis
        driveMotors(MOTOR_FORWARD, drivingSpeed, MOTOR_BACKWARDS, drivingSpeed);
        lcd.print("left");
        break;
      case STOP: // Stop driving
        driveMotors(MOTOR_STOP, 0, MOTOR_STOP, 0);
        lcd.print("stop");
        break;
      default: //Set the driving speed
        drivingSpeed = command;
        lcd.print(drivingSpeed);
        break;
    }
    lastCommand = command; //Another question on the assignment, why is this statement necessary
    //-> we will store the last command received from mqtt into an integer, so we can determine in the next run of the loop if we
    //received new data and if so, we will see which command it is and execute the needed code for that command
  }
}

// This function you need to develop as part of the assignment
// This function is called in the switch statement in the main loop. The goals
// of this function is to control the motors. Try to write a function that can
// handle the parameters. Subfunctions are allowed, hardcoded statements are
// frowned upon

void driveMotors(int leftMotorDirection, int leftMotorSpeed, int rightMotorDirection, int rightMotorSpeed) {
  ledcWrite(3, rightMotorSpeed);
  ledcWrite(0, leftMotorSpeed);
  switch (leftMotorDirection) {
    case 0:
      ledcWrite(1, 0); //put both pins of the left motor off so the motor doesn't turn
      ledcWrite(0, 0);
      break;
    case -1:
      ledcWrite(1, 255); //if the motor doesn't turn correctly, replace 0 by 255 or vice versa
      break;
    case 1:
      ledcWrite(1, 0); //if the motor doesn't turn correctly, replace 0 by 255 or vice versa
      break;
  }
  switch (rightMotorDirection) {
    case 0:
      ledcWrite(2, 0); //put both pins of the right motor off so the motor doesn't turn
      ledcWrite(3, 0);
      break;
    case -1:
      ledcWrite(2, 0); //if the motor doesn't turn correctly, replace 0 by 255 or vice versa
      break;
    case 1:
      ledcWrite(2, 255); //if the motor doesn't turn correctly, replace 0 by 255 or vice versa
      break;
  }
}
