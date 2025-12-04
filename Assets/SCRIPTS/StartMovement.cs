using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class LockDynamicMovementAtStart : MonoBehaviour
{
    public DynamicMoveProvider moveProvider;

    void Start()
    {
        if (moveProvider == null)
            moveProvider = FindObjectOfType<DynamicMoveProvider>();

        // Disable movement at start
        if (moveProvider != null)
            moveProvider.enabled = false;
    }

    // Call this from UI button OnClick
    public void EnableMovement()
    {
        if (moveProvider != null)
            moveProvider.enabled = true;
    }
}
