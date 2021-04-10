int prog_wibracji = 800;
int prog_alarmu = 2;
int prevMillis = 0;
int cnt = 0;

void setup() {
  Serial.begin(9600);
  

}

void loop() {
  delay(50); 
  
  int czujnik = 0;
  czujnik = analogRead(A0);
  
  int pomiarA = 0;
  int pomiarB = 0;
  
  pomiarA = digitalRead(5);
  delay(5);
  pomiarB = digitalRead(5);
  if (pomiarA < pomiarB)
  {
    cnt++;
  }

//  if (czujnik > prog_wibracji)
//  {
//    cnt++;
//  }

  if(cnt >= prog_alarmu)
  {
    Serial.println("uwgaa ktos napierdala w okienko aaa");
    
  }

Serial.println(cnt);

  if (millis() - prevMillis > 3000)
  {
    cnt = 0;
    prevMillis = millis();
  }


}
