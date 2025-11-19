using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using System.Collections;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class DelayedSocketInteractor : XRSocketInteractor
{
    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);

        // Start coroutine to delay any post-snap logic
        StartCoroutine(DelayedSnap(args.interactableObject));
    }

    private IEnumerator DelayedSnap(IXRSelectInteractable interactable)
    {
        yield return null; // wait one frame for snap to complete

        if (interactable is XRGrabInteractable grab)
        {
            grab.enabled = false; // disable grab after snap
            Debug.Log(grab.name + " grab disabled after snap!");
        }

        // Optional: trigger StepManager or other logic here
    }
}
