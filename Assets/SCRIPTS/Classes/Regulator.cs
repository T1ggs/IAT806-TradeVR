using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Regulator : ScubaPart
{
    public bool hoseInteract = false;
    public override void UsePart()
    {
        Debug.Log("Don't bite down on the mouthpiece when you breathe.");
    }

    public void hoseInstall()
    {
        hoseInteract = true;
        Debug.Log("You can turn the air now.");
    }
}
