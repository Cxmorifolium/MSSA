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


    // Preferably have a JSON of data but if not User Entry

    public static Plant Create(string commonName, string scientificName, bool petSafe, 
                               List<string> sunlightPref, string waterReq, string lifeCycle,
                               List<string> origin, List<string> soilPref, string bloomSeason, 
                               string growthRate, int maximumHeight, bool floweringOrNot,
                               string hardinessZone, string wateringFreq)
    {
        return new Plant
        {
            CommonName = commonName,
            ScientificName = scientificName,
            PetSafe = petSafe,
            SunlightPref = sunlightPref,
            WaterReq = waterReq,
            LifeCycle = lifeCycle,
            Origin = origin,
            SoilPref = soilPref,
            BloomSeason = bloomSeason,
            GrowthRate = growthRate,
            MaximumHeight = maximumHeight,
            FloweringOrNot = floweringOrNot,
            HardinessZone = hardinessZone,
            WateringFreq = wateringFreq
        };
    }

    // Edit method to update existing plant's details. Does not need <return> value.
    public void Edit(string commonName, string scientificName, bool petSafe, 
                     List<string> sunlightPref, string waterReq, string lifeCycle,
                     List<string> origin, List<string> soilPref, string bloomSeason, 
                     string growthRate, int maximumHeight, bool floweringOrNot,
                     string hardinessZone, string wateringFreq)

    {
        CommonName = commonName;
        ScientificName = scientificName;
        PetSafe = petSafe;
        SunlightPref = sunlightPref;
        WaterReq = waterReq;
        LifeCycle = lifeCycle;
        Origin = origin;
        SoilPref = soilPref;
        BloomSeason = bloomSeason;
        GrowthRate = growthRate;
        MaximumHeight = maximumHeight;
        FloweringOrNot = floweringOrNot;
        HardinessZone = hardinessZone;
        WateringFreq = wateringFreq;
    }

    // Other method ideas? Maybe if user is searching for something??
}