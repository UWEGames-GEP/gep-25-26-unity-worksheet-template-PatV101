using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerCharacterController : ThirdPersonController
{
    public Gamemanager gamemanager;
    public PlayerInventory inventory;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inventory = GetComponent<PlayerInventory>();
    }

    private void OnPause(InputValue value)
    {
        if(value.isPressed)
        {
            Debug.Log("Pause Game");
            gamemanager.PauseGame();
        }
    }

    private void OnSpawnItem(InputValue value)
    {
        if(value.isPressed)
        {
            Debug.Log("Removed Item");
            inventory.RemoveItemfromInventory();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
