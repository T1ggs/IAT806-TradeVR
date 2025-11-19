using UnityEngine;

public class TeleportCollide : MonoBehaviour
{
    public Transform player, destination;
    public GameObject playerg;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            playerg.SetActive(false);
            player.position = destination.position;
            player.rotation = destination.rotation;
            playerg.SetActive(true);
        }
    }
}
