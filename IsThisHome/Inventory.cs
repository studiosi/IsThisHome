using System.Collections.Generic;


namespace IsThisHome
{
    enum Item
    {
        KEY,
        FLAMETHROWER
    }

    class Inventory
    {
        Dictionary<Item, int> objects;
        
        public Inventory()
        {
            objects = new Dictionary<Item, int>();
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
