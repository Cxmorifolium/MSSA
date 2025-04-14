using System;

enum BreedType {
    Hound,
    Terrier,
    Working

    //etc
}

class Dog : Pet {
    public string Breed { get; set; }
    public BreedType Group { get; set; }

    public string ActivityLevel { get; set; }
    public string TempermentLevel { get; set; }
}
