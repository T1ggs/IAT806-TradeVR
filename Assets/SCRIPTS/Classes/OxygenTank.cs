using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OxygenTank : ScubaPart
{
    public bool valveInteract = false;
    public override void UsePart()
    {
        Debug.Log("Tank provides oxygen.");
    }

    public void valveInstall()
    {
        valveInteract = true;
        Debug.Log("Air is now flowing.");
    }
}