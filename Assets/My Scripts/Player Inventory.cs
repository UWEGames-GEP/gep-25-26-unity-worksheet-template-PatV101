using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;

public class PlayerInventory : MonoBehaviour
{
    public Gamemanager gamemanager;
    public List<string> items = new List<string>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamemanager = FindAnyObjectByType<Gamemanager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            AddItem("Generic Item");
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            RemoveItem("Generic Item");
        }
    }

    public void AddItem(string ItemName)
    {
        items.Add(ItemName);
    }

    public void RemoveItem(string ItemName)
    {
        items.Remove(ItemName);
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Obtainable collisionItem = hit.gameObject.GetComponent<Obtainable>();

        if (collisionItem != null)
        {
            AddItem(collisionItem.name);

            Destroy(collisionItem.gameObject);
        }
    }

    
}
