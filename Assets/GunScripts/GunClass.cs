using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GunClass : MonoBehaviour
{
    
    enum GunType
    {
        AssualtRifle,
        Sniper,
        Shotgun,
        Pistol,
        subMachinegun,
        LMG,
        Melee
    }
    [SerializeField] private int AmmoInClip;
    [SerializeField] private int CurrentAmmo;
    [SerializeField] private int MaxAmmo;

    [SerializeField] private List<Transform> SpawnLoc;
    
    //projectile type

    public virtual void UseWeapon()
    {
        //build the firing mechanics, maybe in a different class like how we refactored in the last campfire project
    }

    public void UpdateAmmo()
    {
        //do the ammo calculations in here
    }
//add a start or update if needed.
}
