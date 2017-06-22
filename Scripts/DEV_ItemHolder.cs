using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEV_ItemHolder : MonoBehaviour {

    public DEV_Item thisSlot;

    public DEV_InventoryManager manager;

    public delegate void testDelegate();
    public testDelegate myDelegate;

    public enum Filled {Filled, Empty}
    public Filled fillState;

    void Start()
    {
        manager = GameObject.FindWithTag("Managers").GetComponent<DEV_InventoryManager>();

    }

    public void Clicked()
    {
        if (fillState == Filled.Filled)
        {

        }
    }

}
