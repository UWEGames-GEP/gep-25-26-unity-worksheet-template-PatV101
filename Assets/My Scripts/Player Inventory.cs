using UnityEngine;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class PlayerInventory : MonoBehaviour
{
    public Gamemanager gamemanager;
    public List<GameObject> items = new List<GameObject>();
    public Transform ItemTransform;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gamemanager = FindAnyObjectByType<Gamemanager>();
        ItemTransform = GameObject.Find("ItemTransform").transform;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddItem(GameObject gameObject)
    {
        items.Add(gameObject);
    }

    public void RemoveItem(GameObject item)
    {
        //if (gamemanager.state == Gamemanager.GameState.PLAY && items.Count > 0)
        {
            //items.Remove(gameObject);

            Debug.Log("Pressed Q");
            //GameObject item = items[0];

            Vector3 currentPosition = transform.position;
            Vector3 forward = transform.forward;

            Vector3 newPosition = currentPosition + forward;
            newPosition += new Vector3(0, 1, 0);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = currentRotation * Quaternion.Euler(0, 0, 180);

            GameObject newItem = Instantiate(item, newPosition, newRotation, ItemTransform);
            newItem.SetActive(true);

            items.Remove(item);
            //Destroy(item);
        }
        //items.Remove(gameObject);
    }

    public void RemoveItemfromInventory()
    {
        if (gamemanager.state == Gamemanager.GameState.PLAY && items.Count > 0)
        {
            GameObject item = items[0];

            RemoveItem(item);
        }
    }

    

    

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Obtainable collisionItem = hit.gameObject.GetComponent<Obtainable>();

        if (collisionItem != null)
        {
            AddItem(collisionItem.gameObject);

            (collisionItem.gameObject).SetActive(false);
        }
    }

    
}
