//Hackaton 2021
//Druzyna Kwartetu Mechatronicznego przedstawia:


#include <DHT.h>
#include <DHT_U.h>

#define POMIAR_PRADU A0
#define PRZEKAZNIK 4
#define POMIAR_CZADU A1
#define DHTPIN 3
#define DHTTYPE DHT11

#include <SPI.h>
#include <WiFiNINA.h>
#include <ThingSpeak.h>


//deklaracje funkcji
int PomiarPradu(void);
int BadanieCzadu(void);
void ThingspeakWysylanie(int liczbaPierwsza, int liczbaDruga, int liczbaTrzecia, int liczbaCzwarta);

//hasło, SSID sieci WiFi
char ssid[] = "Ecuador";
char pass[] = "slodkiekotki69";

int status = WL_IDLE_STATUS;
WiFiClient client;

//informacje dot. serwera Thingspeak
unsigned long numerKanalu = 1353802;
const char numerAPIZapisz[] = "SF93QOL0YTQXZVB3";

//czujnik czadu
int prog_czadu = 500;

//DHT11
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  pinMode(POMIAR_PRADU, INPUT);
  pinMode(PRZEKAZNIK, OUTPUT);
  Serial.begin(9600);

  dht.begin();

  while (status != WL_CONNECTED)
  {
    Serial.print("Lacze sie z siecia");
    Serial.println(ssid);
    status = WiFi.begin(ssid, pass);
    delay(5000);
  }
  ThingSpeak.begin(client);
}

void loop() {
  ThingspeakWysylanie(PomiarPradu(), BadanieCzadu(), dht.readTemperature(), dht.readHumidity());



    delay(10000);
  }


  int PomiarPradu(void)
  {

    int mVnaAmper = 100;

    int ACSoffset = 2500;

    int RawValue = analogRead(POMIAR_PRADU);
    double Napiecie = (RawValue / 1024.0) * 5000;
    double Prad = ((Napiecie - ACSoffset) / mVnaAmper);

    // Serial.print("Prad : ");
    //Serial.println(Prad);
    if (Prad < 3)
    {
      digitalWrite(PRZEKAZNIK, HIGH);
    }
    else
    {
      digitalWrite(PRZEKAZNIK, LOW);
      Serial.println("masz włączone żelazko");
    }
    return Prad;
  }

  void ThingspeakWysylanie(int liczbaPierwsza, int liczbaDruga, int liczbaTrzecia, int liczbaCzwarta)
  {
    ThingSpeak.setField(1, liczbaPierwsza);
    ThingSpeak.setField(2, liczbaDruga);
    ThingSpeak.setField(3, liczbaTrzecia);
    ThingSpeak.setField(4, liczbaCzwarta);
    int x = ThingSpeak.writeFields(numerKanalu, numerAPIZapisz);
    if (x == 200)
    {
      Serial.println("Wyslano dane");
    }
    else
    {
      Serial.println("Blad wysylania danych");
    }
  }

  int BadanieCzadu(void)
  {
    int pomiar = analogRead(POMIAR_CZADU);
    Serial.print("Czad: ");
    Serial.println(pomiar);
    if (pomiar > prog_czadu)
    {
      return 1;
    }
    else
    {
      return 0;
    }

  }
