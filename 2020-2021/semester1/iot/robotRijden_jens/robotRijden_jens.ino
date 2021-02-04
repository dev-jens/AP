#include<DFRobot_LiquidCrystal_I2C.h>
LiquidCrystal_I2C lcd(0x20, 16, 2); //I2C adres 0x20, 16 kolommen en 2 rijen

//buttons en motors waarde geven
int pushButton1 = 03;
int pushButton2 = 04;
int pushButton3 = 05;
int pushButton4 = 06;

int MOTOR1_PWM = 10;
int MOTOR1_DIR = 12;
int MOTOR2_PWM = 11;
int MOTOR2_DIR = 13;

void setup()
{
	// Starten van serial monitor
	Serial.begin(9600);

	// lcd 
	lcd.init();
	lcd.backlight();

	// pushButtons = INPUT
	pinMode(pushButton1, INPUT);
	pinMode(pushButton2, INPUT);
	pinMode(pushButton3, INPUT);
	pinMode(pushButton4, INPUT);

	// Motor pins = OUTPUT
	pinMode(MOTOR1_PWM, OUTPUT);
	pinMode(MOTOR1_DIR, OUTPUT);
	pinMode(MOTOR2_PWM, OUTPUT);
	pinMode(MOTOR2_DIR, OUTPUT);

	// robot begint met vooruit rijden
	digitalWrite(MOTOR1_DIR, HIGH);
	digitalWrite(MOTOR2_DIR, HIGH);

	// LCD display instellen
	lcd.setCursor(0, 0);
	lcd.print("vooruit rijden");
}

void loop()
{
	int speed = 100; // snelheid (speed) van de robot, een getal tussen 0 en 255.
	int pushButton1State = digitalRead(pushButton1);
	int pushButton2State = digitalRead(pushButton2);
	int pushButton3State = digitalRead(pushButton3);
	int pushButton4State = digitalRead(pushButton4);

	// Zet snelheid motoren naar variable speed
	analogWrite(MOTOR1_PWM, speed);
	analogWrite(MOTOR2_PWM, speed);


	if(pushButton1State == HIGH)  //pushButton1 wordt ingedrukt 
	{
		// Motor1 = CCW, Motor2 = CCW  robot rijdt vooruit
		digitalWrite(MOTOR1_DIR, HIGH);
		digitalWrite(MOTOR2_DIR, HIGH);

		//LCD instellen bij elke pushButton het zelfde
		lcd.clear(); // eerst leeg maken 
		lcd.setCursor(0, 0); // "vakje 0,0 starten met printen"
		lcd.print("vooruit rijden");// printen van status

	}
	else if(pushButton2State == HIGH) //pushButton2 wordt ingedrukt  
	{
		// Motor1 = CW , Motor2  =CW  robot rijdt achteruit
		digitalWrite(MOTOR1_DIR, LOW);
		digitalWrite(MOTOR2_DIR, LOW);

		//LCD  
		lcd.clear(); 
		lcd.setCursor(0, 0);
		lcd.print("achteruit rijden");
	}
	else if(pushButton3State == HIGH) //pushButton3 wordt ingedrukt  
	{
		// Motor1 = CW, Motor2 CCW robot rijd naar links
		digitalWrite(MOTOR1_DIR, LOW);
		digitalWrite(MOTOR2_DIR, HIGH);

		//LCD 
		lcd.clear(); 
		lcd.setCursor(0, 0);
		lcd.print("links draaien");

	}
	else if(pushButton4State == HIGH) // pushButton4 wordt ingedrukt  
	{
		// Motor1 = CCW, Motor2 = CW  robot rijdt naar rechts 
		digitalWrite(MOTOR1_DIR, HIGH);
		digitalWrite(MOTOR2_DIR, LOW);

		//LCD 
		lcd.clear(); 
		lcd.setCursor(0, 0);
		lcd.print("rechts draaien");

	}
}
