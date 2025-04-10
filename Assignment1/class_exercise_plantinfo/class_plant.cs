using System;

class Plant {

    public List<string> SunlightPref { get; set; } // Shade, PartialSun/Shade, Full sun
    public string WaterReq { get; set; } // Low, Med, High
    public string LifeCycle { get; set; } // Annual, Biannual, Perennial
    public List<string> Origin { get; set; } 
    public List<string> SoilPref { get; set; } // Rocky, Acidic, Sandy, Cloamy, etc
    public bool PetSafe { get; set; } 
    public List<string> BloomSeason { get; set; } // Winter, Fall, Spring, Summar
    public string GrowthRate { get; set; } // Slow to Fast
    public int MaximumHeight { get; set; }
    public bool FloweringOrNot { get; set; } 
    public string HardinessZone { get; set; } // USDA Zones Range
    public string ScientificName { get; set; }
    public string CommonName { get; set; }
    public string GrowingHabit { get; set; } // Mounding, Creeping, Upright, etc
    public string WateringFreq { get; set; }


}