using System;

namespace threeclassesstrother
{
class Family
{
    public string Name;
    
    public int numberofToes;

    public int numberofHorns;

    public int numberofEggs;

    public bool ScalesorFeathers;

    public bool coulditbeinJPark;
    
    public bool coulditsurviveToday;

 public Family(string _name)
 {
     Name=_name;
     Console.WriteLine("Creating: "+_name+ "at" +DateTime.Now.ToString("MM/DD/YYY"));
 }
 public void setAttributes(Family sentFamily)
 {
     numberofEggs=sentFamily.numberofEggs;
     numberofToes=sentFamily.numberofToes;
 }
 public bool ScalesorFeatheredDino()
 {
     return ScalesorFeathers;
 }
 public bool Coulditsurviveintheworld()
 {
     return coulditsurviveToday;
 }
 public bool IsitgoingtobeinJurassicWorldDominion()
 {
     return coulditbeinJPark;
 }
}
}

