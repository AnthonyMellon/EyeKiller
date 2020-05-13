#include <LiquidCrystal.h>
#include <Servo.h>


Servo srvoX;
Servo srvoY;

LiquidCrystal LCD_cords(13, 12, 11, 10, 9, 8);

int posX = 0;
int posY = 0;

String serialIn;

void setup() {
  // put your setup code here, to run once:
  srvoX.attach(6);
  srvoY.attach(7);

  LCD_cords.begin(16, 2);
  LCD_cords.clear();
  
  Serial.begin(9600);
  Serial.setTimeout(10);
}

void loop() {
  // put your main code here, to run repeatedly: 
}

void serialEvent() {

  serialIn = Serial.readString();

  int xPos = parseXPos(serialIn)
  int yPos = parseYPos(serialIn)

  LCD_cords.setCursor(0,0);
  LCD_cords.print("X: " + xPos);
  LCD_cords.setCursor(1, 1);
  LCD_cords.print("Y: " + yPos);
  
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
