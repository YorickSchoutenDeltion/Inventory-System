using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEV_InventorySlot : MonoBehaviour {

    public GameObject objectReference2d;
    public DEV_InventoryManager manager;

    public bool occupied;

    public float zAxis;

    void Start()
    {
        manager = GameObject.FindWithTag("Managers").GetComponent<DEV_InventoryManager>();
        gameObject.GetComponent<Button>().onClick.AddListener(() => {if (occupied) {TakeItem();} else {PlaceItem(manager.currentlyHeld);}});
    }

    public void TakeItem()
    {
        if (manager.currentlyHeld == null)
        {
            occupied = false;
            manager.currentlyHeld = objectReference2d;
            manager.isHoldingItem = true;
            objectReference2d = null;
        }

        else
        {
            SwapItem(objectReference2d);
        }
    }

    public void PlaceItem(GameObject g)
    {
        if (manager.currentlyHeld != null)
        {
            objectReference2d = g;
            g.transform.position = transform.position;
            occupied = true;
            manager.isHoldingItem = false;
            manager.currentlyHeld = null;
        }
    }

    public void SwapItem(GameObject g)
    {
        objectReference2d = manager.currentlyHeld;
        manager.currentlyHeld = g;
        objectReference2d.transform.position = transform.position;
    }
}
