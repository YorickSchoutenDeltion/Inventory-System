using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DEV_InventoryManager : MonoBehaviour {

    public GameObject currentlyHeld;
    public GameObject invCanvas;
    public Vector3 mousePos;

    public bool isHoldingItem;
    public bool isEnabled;

    public int to;
    public int from;

    public float zAxis;

    void Start()
    {
        
    }

    void Update()
    {
        if (isHoldingItem)
        {
            FollowMouse();
            if (Input.GetButtonDown("Fire1"))
            {
                if (EventSystem.current.IsPointerOverGameObject())
                {
                    Debug.Log("Clicked on UI");
                }
            }
        }
        if (Input.GetButtonDown("Inventory"))
        {
            ToggleInventory();
        }
    }

    public void ToggleInventory()
    {
        if (isEnabled)
        {
            invCanvas.SetActive(false);
            isEnabled = false;
        }
        else
        {
            invCanvas.SetActive(true);
            isEnabled = true;
        }
    }

    public void FollowMouse()
    {
        if (currentlyHeld != null)
        {
            currentlyHeld.transform.position = Input.mousePosition; 
        }
    }

    public void DropItem()
    {

    }
}
