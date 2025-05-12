using System.Collections.Generic;
using UnityEngine;

namespace DureStudios
{

/// ====== Don't Use. Work In Progress ==========
/// Not Currently Completed. Please Do Not use it.
///
public class PlayerInventory : MonoBehaviour
{
    private List<Item> _items;
    [SerializeField] private int _MaxItems;
    
    private void Awake()
    {
        _items = new List<Item>();
    }

    public bool AddItem(Item item)
    {
        if(item == null || _items.Count >= _MaxItems)
            return false;
        
        _items.Add(item);
        return true;
    }

    public bool RemoveItem(Item item)
    {
        if(item == null)
            return false;
        
        return _items.Remove(item);
    }
    
    

}
}