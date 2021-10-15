
/*	Servomotor voorbeeld (slagboom overweg)
*/

#include <Servo.h>

int ServoPin = 9;
int LEDR= 4;
int LEDGr= 5;
int Button=6;

int Toggle=0;

Servo SlagBoom;

float tijdsduur;

void setup()
{
	Serial.begin(9600);

	pinMode(LEDR, OUTPUT);
	pinMode(LEDGr, OUTPUT);

	pinMode(Button, INPUT);

	SlagBoom.attach(ServoPin);
	SlagBoom.write(90);
	Serial.println("Start programma; Slagboom staat open");
	delay(1000);
}

void loop()
{
	while (digitalRead(Button) == HIGH) {
		while(Toggle == 0){
			tijdsduur = millis();
			Serial.print(tijdsduur);
			Serial.println(" - SlagBoom naar beneden");
			Toggle = 1;
		}
		digitalWrite(LEDGr, LOW);
		digitalWrite(LEDR, HIGH);
		SlagBoom.write(0);
		delay(2000);

	}

	while (Toggle == 1) {
		tijdsduur = millis();
		Serial.print(tijdsduur);
		Serial.println(" - SlagBoom naar omhoog");
		Toggle = 0;
	}

	SlagBoom.write(90);
	delay(500);

	digitalWrite(LEDR, LOW);
	digitalWrite(LEDGr, HIGH);

}
