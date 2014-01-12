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


//const int laserPin = 7; 
int laserstatut = 0;

Servo dirservo;     // min=5 ; max=180; inc=?
int dirAngle = 0; // Direction servo actual angle
int dirinitAngle = 90; //Direction init angle
int dirminAngle = 5;
int dirmaxAngle = 180;
int dirnewAngle = 0;
int dirincAngle = 1;

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
  
  pinMode(7,OUTPUT);
  digitalWrite(7, LOW);

  //Serial.println("Start");
}

void loop(){
  
// Serial input data  
 if (Serial.available() > 0) {
    inputcmd = Serial.parseInt();
                    
     switch (inputcmd) {   
       
           case 30:
                dirAngle = dirinitAngle;
                break;   
                
           case 31: // Direction servo angle
                dirnewAngle = dirAngle + dirincAngle;
                if (dirnewAngle < dirmaxAngle) {
                    dirAngle = dirnewAngle;
                }
                else {
                    Serial.println("error");
                }
                break;
                      
            case 32:
                dirnewAngle = dirAngle - dirincAngle;
                if (dirnewAngle > dirminAngle) {
                    dirAngle = dirnewAngle;
                 }
                 else {
                     Serial.println("error");
                 }
                 break;
                 
             case 40:
                 lsrAngle = lsrinitAngle;
                 break;   
                    
             case 41:      //lase servo angle
                 lsrnewAngle = lsrAngle + lsrincAngle;
                 if (lsrnewAngle < lsrmaxAngle) {
                    lsrAngle = lsrnewAngle;
                 }
                 else {
                    Serial.println("error");
                 }
                 break;
  
              case 42:
                 lsrnewAngle = lsrAngle - lsrincAngle;
                 if (lsrnewAngle > lsrminAngle) {
                     lsrAngle = lsrnewAngle;
                 }
                 else {
                     Serial.println("error");
                 }
                 break;
              
               case 50: // laser control
                   laserstatut = 0;
               break; 
              
               case 51: // laser control
                   if (laserstatut == 1) {
                       laserstatut = 0;
                   }
                   else {
                       laserstatut = 1;
                   }
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

dirservo.write(dirAngle);
laserservo.write(lsrAngle);

if (laserstatut == 1) {  
  digitalWrite(7, HIGH);
  }
  else {
  digitalWrite(7, LOW);  
  }
  
}




