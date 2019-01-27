using System.Collections.Generic;
using System.Text;

namespace IsThisHome
{
    public enum Item
    {
        PICTURE,
        SPACESUIT,
        JYRI,
        FLAMETHROWER,
        DOOR,
        BUTTON,
        SOIL,
        MOUND,
        SAND,
        STARROCK,
        SQUAREROCK,
        ROCK,
        RIGHT,
        LEFT,
        RADIOPHONE,
        HILL,
        LOCK,
        ICE,
        GENERAL,
        VERBS,
        PANEL,
        PICKAXE,
        WATER
    }

    public class Inventory
    {
        Dictionary<Item, int> objects;
        
        public Inventory()
        {
            objects = new Dictionary<Item, int>();
        }        

        public List<string> GetText()
        {
            List<string> r = new List<string>();
            r.Add("= INVENTORY =");
            r.Add("");
            List <Item> items = new List<Item>(objects.Keys);
            for(int i = 0; i < items.Count; i+=2)
            {                
                StringBuilder sb = new StringBuilder();
                sb.Append(System.Enum.GetName(typeof(Item), items[i]));
                if (i+1 < objects.Keys.Count)
                {
                    while(sb.Length <= 20)
                    {
                        sb.Append(" ");
                    }
                    sb.Append(System.Enum.GetName(typeof(Item), items[i + 1]));
                }
                r.Add(sb.ToString());
            }
            r.Add("");
            r.Add("Press enter to continue...");
            return r;
        }

        public void AddItem(Item i, int amount)
        {
            if(!objects.ContainsKey(i))
            {
                objects.Add(i, amount);
            }
            else
            {
                int currentAmount;
                objects.TryGetValue(i, out currentAmount);
                currentAmount += amount;
                objects[i] = currentAmount;
            }
        }

        public bool RemoveItem(Item i, int amount)
        {
            if (objects.ContainsKey(i))
            {
                int currentAmount;
                objects.TryGetValue(i, out currentAmount);
                if(currentAmount >= amount)
                {
                    currentAmount -= amount;
                    if(currentAmount == 0)
                    {
                        objects.Remove(i);
                    }
                    else
                    {
                        objects[i] = currentAmount;
                    }                    
                    return true;
                }                
            }
            return false;
        }

        public bool CheckItem(Item i, int amount)
        {
            int currentAmount;
            objects.TryGetValue(i, out currentAmount);
            return currentAmount >= amount;
        }
    }
}
