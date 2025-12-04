using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ScubaPart : MonoBehaviour
{
    public string partName;
    public virtual void UsePart()
    {
        Debug.Log("The parent has been called instead.");
    }
}
