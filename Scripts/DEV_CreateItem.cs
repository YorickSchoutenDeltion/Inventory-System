using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEV_CreateItem : MonoBehaviour {

    public List<GameObject> references3D = new List<GameObject>();
    public List<Sprite> references2D = new List<Sprite>();
    public List<string> itemTypes = new List<string>();

    public Vector2 statRoll;

    public int statType;

    public DEV_InventoryManager manager;

    void Start()
    {
        manager = GetComponent<DEV_InventoryManager>();
    }

    void CreateItem()
    {
        float typeRoll = Random.Range(0, 2);
        statType = Mathf.RoundToInt(typeRoll);
        string typeString = itemTypes[statType];
        float statBoost = Random.Range(statRoll.x, statRoll.y);
            
    }

}
