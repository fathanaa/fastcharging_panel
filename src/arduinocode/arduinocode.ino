
void setup() {
    Serial.begin(9600); 
    delay(2000);  
}
 
void loop() {
    int Voltage_src = random(0,255);
    int Current_src = random(0,255);
    int Power_src = random(0,255);
    int Energy_src = random(0,255);
    int CellTemp_src = random(0,255);
    int Cycle_src = random(0,255);
    int AmbTemp_src = random(0,255);
    int AmbHumid_src = random(0,255);
    int CellFanCool_src = random(0,255);
    int DCurrentTarget_src = random(0,255);
    int DPowerTarget_src = random(0,255);
    int PWMOut_src = random(0,255);
    

    String Voltage = String(Voltage_src);
    String Current = String(Current_src);
    String Power = String(Power_src);

    String Energy = String(Energy_src);
    String CellTemp = String(CellTemp_src);
    String Cycle = String(Cycle_src);

    String AmbTemp = String(AmbTemp_src);
    String AmbHumid = String(AmbHumid_src);
    String CellFanCool = String(CellFanCool_src);

    String DCurrentTarget = String(DCurrentTarget_src);
    String DPowerTarget = String(DPowerTarget_src);
    String PWMOut = String(PWMOut_src);

    

    String output = 
    Voltage +";"+ Current +";"+ Power +";"+
    Energy +";"+ CellTemp +";"+ Cycle +";"+
    AmbTemp +";"+ AmbHumid +";"+ CellFanCool +";"+
    DCurrentTarget +";"+ DPowerTarget +";"+ PWMOut;
    
    Serial.println(output);
    delay(1000);
}
