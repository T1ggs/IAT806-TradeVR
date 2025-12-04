using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollidePopup : MonoBehaviour
{
    public GameObject popuptarget;
    public Collider selfcollide; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            popuptarget.SetActive(true);

            selfcollide.enabled = false;   // disable after first use
        }
    }
}
