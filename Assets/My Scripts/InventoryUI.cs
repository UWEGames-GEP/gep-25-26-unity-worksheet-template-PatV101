using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public PlayerInventory inventory;
    public List<GameObject> inventorybuttons = new List<GameObject>();

    private void OnEnable()
    {
        //Debug.Log("INV UI Enabled 1");
        RefreshInventory();
    }

    void RefreshInventory()
    {
        Debug.Log("Refreshed");
        foreach (GameObject item in inventorybuttons)
        {
            item.SetActive(false);
            //Debug.Log("Set Active False 1");
        }

        for (int i = 0; i < inventory.items.Count; i++)
        {
            if (i < inventorybuttons.Count)
            {
                //Debug.Log("test message 1");
                InventoryButton button = inventorybuttons[i].GetComponent<InventoryButton>();
                GameObject item = inventory.items[i];
                //Debug.Log("test message 2");
                button.gameObject.SetActive(true);
                button.Setbutton(item);
                //Debug.Log("test message 3");
            }
        }

    }

    public void RemoveInventoryInt(int i)
    {
        //if (i < inventory.items.Count)
        {
            inventory.RemoveItem(inventory.items[i]);
            Debug.Log("Button step 2");
        }
    }

    public void OnInventoryButton(int i)
    {
        Debug.Log("Pressed BUtton");
        RemoveInventoryInt(i);
        RefreshInventory();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
