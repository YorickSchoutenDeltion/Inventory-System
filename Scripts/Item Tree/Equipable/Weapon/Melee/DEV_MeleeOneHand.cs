using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEV_MeleeOneHand : DEV_MeleeWeapon {

    public DEV_MeleeOneHand (string _statType, float _statBoost)
    {
        itemName = "Iron Mace";
        statBoost = _statBoost;
        statType = _statType;
    }

}
