using System;

class HousePlants : Plant {
    public List<string> LightReq { get; set; } // low, high, indirect, direct
    public string WateringFreq { get; set; } 
    public int TemperatureReq { get; set; }

}