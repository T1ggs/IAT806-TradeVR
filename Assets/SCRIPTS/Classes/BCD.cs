using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BCD : ScubaPart
{
    public bool strapInteract = false;

    public void strapInstall()
    {
        strapInteract=true;
        Debug.Log("Air tank secured.");
    }
    

}
