using System;


namespace threeclassesstrother
{
 enum TypeofDiet
 {
     Herbivore, Carnivore, Omnivore
 }
 class Species: Family
 {
    public string _binomialName;
    public int _numberofHorns;
        public int _numberofEggs;

    public int _numberofToes;

    public string name;

    public List<TypeofDiet> Diets;
    public Species(string _name): base(_name)
    {
        if(_name is null ||_name.Length<1)
        {
            _name="Nameless";
        }else{
            _name=_name.Replace(";"," ");
        }
        Console.WriteLine("Creating:" +_name+"at"+DateTime.Now.ToString("MM/DD/YYYY"));
    }
    public Species(string _name, string binomialName): this( _name)
    {
        if(_binomialName is null|| _binomialName.Length<1)
        {
            binomialName="Nameless";
        }
        else
        {
            binomialName= _binomialName.Replace(";","");
        }
    }
    public Species(string _name, int numberofToes, int numberofHorns, int numberofEggs): this(_name)
    {
        if (numberofToes > 0) {
        _numberofToes=numberofToes;
        }
          if (numberofHorns > 0) {
        _numberofHorns=numberofHorns;
        }
          if (numberofEggs > 0) {
        _numberofEggs=numberofEggs;
        }
    }
 }
}


 
