using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class GrabDisable : MonoBehaviour
{
    private XRGrabInteractable grab;
    private void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();
    }
    public void DisableGrab()
    {
        StartCoroutine(DisableNextFrame());
    }
    private IEnumerator DisableNextFrame()
    {
        yield return null;

        if (grab != null)
            grab.enabled = false;
    }
}
