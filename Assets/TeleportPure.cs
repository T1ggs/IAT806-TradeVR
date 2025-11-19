using UnityEngine;

public class TeleportPure : MonoBehaviour
{
    public GameObject playerg;
    public Transform destination; 

    public void TeleportPlayer()
    {
        if (playerg == null || destination == null) return;

        Debug.Log("tp terminal");
        playerg.transform.position = destination.position;
        playerg.transform.rotation = destination.rotation;
    }
}
