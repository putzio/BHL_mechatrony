int prog_wibracji = 800;
int prog_alarmu = 20;
int prevMillis = 0;
int cnt = 0;

void setup() {
  Serial.begin(9600);
  

}

void loop() {
  delay(50); 
  
  int czujnik = 0;
  czujnik = analogRead(A0);

  if (czujnik > prog_wibracji)
  {
    cnt++;
  }

  if(cnt > prog_alarmu)
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
