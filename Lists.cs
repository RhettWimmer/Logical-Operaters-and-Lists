/* 
Lists are a more in depth version of an array.
We can make a class script that that uses a list
 */

public class heroes{
    public string name;
    public int health;
    public int stamina;
    public int mana;

    public heroes(string heroName, int heroHealth, int heroStamina, int heroMana){
        name = heroName;
        health = heroHealth;
        stamina = heroStamina;
        mana = heroMana;
    }
}

//Now we can start creating our list 

    List<heroes> heroList = new List<heroes>();

//using .Add we can start populating our list 
    heroList.Add ( new heroes("King Maelon", 200, 150, 50));
    heroList.Add ( new heroes("Jorn", 350, 250, 10));
    heroList.Add ( new heroes("Vyndahl", 150, 50, 300));

//We can also remove or insert things in our list
//To remove 
    heroList.RemoveAt
//To insert
    heroList.Insert

//Helpful information: inialized with Generic collection
using.System.Collection.Generc;

//Since lists work like arrays we can count things in it, like length does for arrays
heroList.Count
//We can also find things within the list like an array
heroList[0];

//Here's some more examples of lists using a class script
//Class script

public class cats{
    public string name;
    public int powerLevel;
    public string fur;

    public cats(string catName, int catLevel, string catFur){
        name = catName;
        powerLevel = catPowerLevel;
        fur = catFur;
    }
}

//List Script

    List<cats> catsList = new List<cats>();

    catsList.Add (new cats("Spahgetti", 111, "Orange Tabby"));
    catsList.Add (new cats("Bean", 100, "Pastel Calico"));
    castList.Add (new cats("Big Boi", 999999, "Pure White"));
