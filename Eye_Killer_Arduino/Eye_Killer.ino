#include <Servo.h>


Servo srvoX;
Servo srvoY;

int posX = 0;
int posY = 0;

void setup() {
  // put your setup code here, to run once:
  srvoX.attach(6);
  srvoY.attach(7);
}

void loop() {
  // put your main code here, to run repeatedly:

  for(int i = 0; i <= 180; i++)
  {
    srvoX.write(i);
    srvoY.write(i);
    delay(5);
  }

  for(int i = 180; i >= 0; i--)
  {
    srvoX.write(i);
    srvoY.write(i);
    delay(5);
  }

}
