using threeclassesstrother;

// 03032022 First version
            Species Triceratops=new Species("Triceratops", "Triceratops Horridus");
            Species Pachyrhinosaurus=new Species("Pachyrhinosaurus", "Thick-Nosed Lizard");
            Family Ceratopsian=new Family("Ceratopsian");

            Ceratopsian.numberofEggs=20;
            Ceratopsian.numberofToes=5;
            Ceratopsian.numberofHorns=3;
            Triceratops.setAttributes(Ceratopsian);
            Pachyrhinosaurus.setAttributes(Ceratopsian);
            Console.WriteLine("What is the name of this dinosaur?");
            string newSpeciesname=Console.ReadLine();
            Console.WriteLine("How many horns did it have?");
            int numofHorn=3;

            try
            {
                numofHorn=int.Parse(Console.ReadLine());
            }catch (Exception ex)
            {
                Console.WriteLine("Oops, Bruce Banner couldn't have even made a number out of what you just put down, try again after the beep...but the error was"+ex.ToString());
                while (numofHorn<=0)
                {
                    Console.WriteLine("How many horns does it have?");
                    try{
                        numofHorn=int.Parse(Console.ReadLine());
                    }
                    catch(Exception){}
                }
            }
            Species newObj= new Species(newSpeciesname, 0, numofHorn,0);
            Console.ReadLine();
