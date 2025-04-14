using System;

class Tree : Plant {
    public string FruitOrNut { get; set;} // default to no if
    public bool CanBeShrub { get; set;}
    public string TreeType { get; set; } // "Deciduous" or "Evergreen"
}