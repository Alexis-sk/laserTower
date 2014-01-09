/* 
Laser-Tower -- www.skplace.org
Arduino code - Serial input

Serial Control 
input:  int1;int2

First int :
1 - Motor Speed
    Second Int:
      1 - Speed +
      2 - Speed -
      Else - Speed 0
2 - Motor Direction (Front/Back)
    Second int:
      1 - Front
      Else - Back
3 - Robot Directoin (servo)
    Second int:
     1 - Angle Right
     2 - Angle Left
     Else - Init

*/


#include <Servo.h>

Servo laserservo;
Servo dirservo;

const int enablePin = 7; 
int laserstatut = 0;


int dirAngle = 0; // Direction servo actual angle
int initAngle = 90; //Direction init angle
int minAngle = 0;
int maxAngle = 170;
int newAngle = 0;
int incAngle = 5;

int inputdata = 0;
int inputcmd = 0;



void setup(){
 
  Serial.begin(9600); 
    
  dirservo.attach(10); 
  dirservo.write(initAngle);
   // min=5 ; max=180; inc=?
  dirAngle = initAngle;
  
  laserservo.attach(9);
  laserservo.write(initAngle);
  // min=0 ; max=20; inc=1

   digitalWrite(enablePin, LOW);

  //Serial.println("Start");
}

void loop(){
  

// Serial input data  
 if (Serial.available() > 0) {
    inputcmd = Serial.parseInt();
    inputdata = Serial.parseInt();
                

  
     switch (inputcmd) {   
           case 1: // motor speed input
                laserservo.write(inputdata);                  
                  break;
           case 2: // motor direction input 
                dirservo.write(inputdata);
                break;
           case 3: // Direction servo angle
                switch (inputdata) {
                    case 1:
                      newAngle = dirAngle + incAngle;
                      if (newAngle < maxAngle) {
                          dirAngle = newAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    case 2:
                      newAngle = dirAngle - incAngle;
                      if (newAngle > minAngle) {
                          dirAngle = newAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    default:
                    dirAngle = initAngle;
                    break;            
                }             
                
                dirservo.write(dirAngle);
                delay(15);
                
                break;
                
               case 4:
                   laserstatut = inputdata;
                break;
           default:
                Serial.print("invalid command: ");
                Serial.print("inputcmd=");
                Serial.print(inputcmd);
                Serial.print("  inputdata=");
                Serial.print(inputdata);
                break; 
        }//end switch  
   }//end Serial

if (laserstatut == 1) {  
  digitalWrite(enablePin, HIGH);
  }
  else {
  digitalWrite(enablePin, LOW);  
  }
  
}




