#include <Servo.h>


Servo srvoX;
Servo srvoY;

int posX = 0;
int posY = 0;

String serialIn;

void setup() {
  // put your setup code here, to run once:
  srvoX.attach(6);
  srvoY.attach(7);
  
  Serial.begin(9600);
  Serial.setTimeout(10);
}

void loop() {
  // put your main code here, to run repeatedly: 
}

void serialEvent() {

  serialIn = Serial.readString();

  int xPos = 180 - parseXPos(serialIn);
  int yPos = 180 - parseYPos(serialIn);
  
  srvoX.write(xPos);
  srvoY.write(yPos);

}

int parseXPos(String data)
{
  data.remove(data.indexOf("Y"));
  data.remove(data.indexOf("X"), 1);

  return data.toInt();
}

int parseYPos(String data)
{
  data.remove(0, data.indexOf("Y") + 1);

  return data.toInt();
}
