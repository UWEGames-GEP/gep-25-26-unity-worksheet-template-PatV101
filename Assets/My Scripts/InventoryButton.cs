using UnityEngine;
using TMPro;
public class InventoryButton : MonoBehaviour
{

    public TMP_Text text;

    public void Setbutton(GameObject item)
    {
        text.text = item.name;
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
