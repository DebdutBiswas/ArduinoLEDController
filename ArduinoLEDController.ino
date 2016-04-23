#include <SoftwareSerial.h>

SoftwareSerial BTSerial(7, 8); // RX, TX
int BTSerialData =0;
//-------------------------------------------
void setup()
{
  BTSerial.begin(9600);

  pinMode(2,OUTPUT);
  pinMode(3,OUTPUT);
  pinMode(5,OUTPUT);
  pinMode(6,OUTPUT);
  pinMode(9,OUTPUT);
  pinMode(10,OUTPUT);
  pinMode(11,OUTPUT);

  digitalWrite(2,LOW);
  digitalWrite(3,LOW);
  digitalWrite(5,LOW);
  digitalWrite(6,LOW);
  digitalWrite(9,LOW);
  digitalWrite(10,LOW);
  digitalWrite(11,LOW);
}
//-------------------------------------------
void loop()
{

  if (BTSerial.available()>0)
  {

    BTSerialData=BTSerial.read();
// Blink start----------------------------------|
    if (BTSerialData==48)
    {
      digitalWrite(2, HIGH);
      BTSerial.println("LED0 ON");
      BTSerial.flush();
    }
    if (BTSerialData==49)
    {
      digitalWrite(2,LOW);
      BTSerial.println("LED0 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==50)
    {
      digitalWrite(3, HIGH);
      BTSerial.println("LED1 ON");
      BTSerial.flush();
    }
    if (BTSerialData==51)
    {
      digitalWrite(3,LOW);
      BTSerial.println("LED1 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==52)
    {
      digitalWrite(5, HIGH);
      BTSerial.println("LED2 ON");
      BTSerial.flush();
    }
    if (BTSerialData==53)
    {
      digitalWrite(5,LOW);
      BTSerial.println("LED2 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==54)
    {
      digitalWrite(6, HIGH);
      BTSerial.println("LED3 ON");
      BTSerial.flush();
    }
    if (BTSerialData==55)
    {
      digitalWrite(6,LOW);
      BTSerial.println("LED3 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==56)
    {
      digitalWrite(9, HIGH);
      BTSerial.println("LED4 ON");
      BTSerial.flush();
    }
    if (BTSerialData==57)
    {
      digitalWrite(9,LOW);
      BTSerial.println("LED4 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==58)
    {
      digitalWrite(10, HIGH);
      BTSerial.println("LED5 ON");
      BTSerial.flush();
    }
    if (BTSerialData==59)
    {
      digitalWrite(10,LOW);
      BTSerial.println("LED5 OFF");
      BTSerial.flush();
    }

    if (BTSerialData==60)
    {
      digitalWrite(11, HIGH);
      BTSerial.println("LED6 ON");
      BTSerial.flush();
    }
    if (BTSerialData==61)
    {
      digitalWrite(11,LOW);
      BTSerial.println("LED6 OFF");
      BTSerial.flush();
    }
// Blink End ----------------------------------|
// Switch All ON Start ------------------------|
    if (BTSerialData==62)
    {
      digitalWrite(2,HIGH);
      BTSerial.println("LED0 ON");
      digitalWrite(3,HIGH);
      BTSerial.println("LED1 ON");
      digitalWrite(5,HIGH);
      BTSerial.println("LED2 ON");
      digitalWrite(6,HIGH);
      BTSerial.println("LED3 ON");
      digitalWrite(9,HIGH);
      BTSerial.println("LED4 ON");
      digitalWrite(10,HIGH);
      BTSerial.println("LED5 ON");
      digitalWrite(11,HIGH);
      BTSerial.println("LED6 ON");
      BTSerial.flush();
    }

    if (BTSerialData==63)
    {
      digitalWrite(2,LOW);
      BTSerial.println("LED0 OFF");
      digitalWrite(3,LOW);
      BTSerial.println("LED1 OFF");
      digitalWrite(5,LOW);
      BTSerial.println("LED2 OFF");
      digitalWrite(6,LOW);
      BTSerial.println("LED3 OFF");
      digitalWrite(9,LOW);
      BTSerial.println("LED4 OFF");
      digitalWrite(10,LOW);
      BTSerial.println("LED5 OFF");
      digitalWrite(11,LOW);
      BTSerial.println("LED6 OFF");
      BTSerial.flush();
    }
// Switch All OFF End ------------------------|

    if (BTSerialData==64)
    {
      digitalWrite(2,HIGH);
      BTSerial.println("LED0 ON");
      delay(100);
      digitalWrite(3,HIGH);
      BTSerial.println("LED1 ON");
      delay(100);
      digitalWrite(5,HIGH);
      BTSerial.println("LED2 ON");
      delay(100);
      digitalWrite(6,HIGH);
      BTSerial.println("LED3 ON");
      delay(100);
      digitalWrite(9,HIGH);
      BTSerial.println("LED4 ON");
      delay(100);
      digitalWrite(10,HIGH);
      BTSerial.println("LED5 ON");
      delay(100);
      digitalWrite(11,HIGH);
      BTSerial.println("LED6 ON");
      delay(100);
      BTSerial.flush();
    }

    if (BTSerialData==65)
    {
      digitalWrite(11,LOW);
      BTSerial.println("LED6 OFF");
      delay(100);
      digitalWrite(10,LOW);
      BTSerial.println("LED5 OFF");
      delay(100);
      digitalWrite(9,LOW);
      BTSerial.println("LED4 OFF");
      delay(100);
      digitalWrite(6,LOW);
      BTSerial.println("LED3 OFF");
      delay(100);
      digitalWrite(5,LOW);
      BTSerial.println("LED2 OFF");
      delay(100);
      digitalWrite(3,LOW);
      BTSerial.println("LED1 OFF");
      delay(100);
      digitalWrite(2,LOW);
      BTSerial.println("LED0 OFF");
      delay(100);
      BTSerial.flush();
    }

    if (BTSerialData==66)
    {
      digitalWrite(2,HIGH);
      BTSerial.println("LED0 ON");
      delay(100);
      digitalWrite(3,HIGH);
      BTSerial.println("LED1 ON");
      delay(100);
      digitalWrite(5,HIGH);
      BTSerial.println("LED2 ON");
      delay(100);
      digitalWrite(6,HIGH);
      BTSerial.println("LED3 ON");
      delay(100);
      digitalWrite(9,HIGH);
      BTSerial.println("LED4 ON");
      delay(100);
      digitalWrite(10,HIGH);
      BTSerial.println("LED5 ON");
      delay(100);
      digitalWrite(11,HIGH);
      BTSerial.println("LED6 ON");
      delay(100);
      digitalWrite(11,LOW);
      BTSerial.println("LED6 OFF");
      delay(100);
      digitalWrite(10,LOW);
      BTSerial.println("LED5 OFF");
      delay(100);
      digitalWrite(9,LOW);
      BTSerial.println("LED4 OFF");
      delay(100);
      digitalWrite(6,LOW);
      BTSerial.println("LED3 OFF");
      delay(100);
      digitalWrite(5,LOW);
      BTSerial.println("LED2 OFF");
      delay(100);
      digitalWrite(3,LOW);
      BTSerial.println("LED1 OFF");
      delay(100);
      digitalWrite(2,LOW);
      BTSerial.println("LED0 OFF");
      delay(100);
      BTSerial.flush();
    }
  }
}
