using UnityEngine;


namespace DureStudios
{

/// ====== Don't Use. Work In Progress ==========
/// Not Currently Completed. Please Do Not use it.
///
public class Item : MonoBehaviour
{
    private Rigidbody _rb;


    public string ItemName;
    
    [Range(1,100)] public int Rarity;


    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
    }


    public void Drop()
    {
        
    }

    public void Interact()
    {
        
    }

    public void Pickup()
    {
        
    }
    
    
}
}