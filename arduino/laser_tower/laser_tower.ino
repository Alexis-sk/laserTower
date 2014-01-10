/* 
Laser-Tower -- www.skplace.org
Arduino code - Serial input

Serial Control 
input:  int1;int2

First int :
1 - laser servo 
    Second Int: angle
2 - direction servo
    Second int: angle
3 - direction servo
    Second int:
     1 - + Right
     2 - + Angle Left
     Else - Init
4 - laser servo
    Second int:
     1 - + Right
     2 - + Angle Left
     Else - Init
     
5 - laser enable
*/


#include <Servo.h>


const int laserPin = 12; 
int laserstatut = 0;

Servo dirservo;     // min=5 ; max=180; inc=?
int dirAngle = 0; // Direction servo actual angle
int dirinitAngle = 90; //Direction init angle
int dirminAngle = 5;
int dirmaxAngle = 180;
int dirnewAngle = 0;
int dirincAngle = 2;

Servo laserservo;    // min=0 ; max=20; inc=1
int lsrinitAngle = 5; //laser servo init angle
int lsrAngle = 0; // laser servo actual angle
int lsrminAngle = 0;
int lsrmaxAngle = 20;
int lsrnewAngle = 0;
int lsrincAngle = 1;


//serial data
int inputdata = 0;
int inputcmd = 0;


void setup(){
 
  Serial.begin(9600); 
    
  dirservo.attach(10); 
  dirservo.write(dirinitAngle);
  dirAngle = dirinitAngle;
  
  laserservo.attach(9);
  laserservo.write(lsrinitAngle);
  lsrAngle = lsrinitAngle;

  digitalWrite(laserPin, LOW);

  //Serial.println("Start");
}

void loop(){
  
// Serial input data  
 if (Serial.available() > 0) {
    inputcmd = Serial.parseInt();
    inputdata = Serial.parseInt();
                
     switch (inputcmd) {   
           case 1: // laser servo angle
                laserservo.write(inputdata);                  
                  break;
                  
           case 2: // direction servo angle
                dirservo.write(inputdata);
                break;
                
           case 3: // Direction servo angle
                switch (inputdata) {
                    case 1:
                      dirnewAngle = dirAngle + dirincAngle;
                      if (dirnewAngle < dirmaxAngle) {
                          dirAngle = dirnewAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    case 2:
                      dirnewAngle = dirAngle - dirincAngle;
                      if (dirnewAngle > dirminAngle) {
                          dirAngle = dirnewAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    default:
                    dirAngle = dirinitAngle;
                    break;            
                }              
                dirservo.write(dirAngle);
                //delay(15);
                break;
                
               case 4:      //lase servo angle
                 switch (inputdata) {
                    case 1: 
                      lsrnewAngle = lsrAngle + lsrincAngle;
                      if (lsrnewAngle < lsrmaxAngle) {
                          lsrAngle = lsrnewAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    case 2:
                      lsrnewAngle = lsrAngle - lsrincAngle;
                      if (lsrnewAngle > lsrminAngle) {
                          lsrAngle = lsrnewAngle;
                      }
                      else {
                          Serial.println("error");
                      }
                      break;
                    default:
                    lsrAngle = lsrinitAngle;
                    break;            
                  }             
               laserservo.write(lsrAngle);
               //delay(15);                        
               break;
               
               case 5: // laser control
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
  digitalWrite(laserPin, HIGH);
  }
  else {
  digitalWrite(laserPin, LOW);  
  }
  
}




