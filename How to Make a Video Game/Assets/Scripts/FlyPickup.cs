using UnityEngine;

public class FlyPickup : MonoBehaviour {

	private void OnTriggerEnter(Collider other)
    {
        // if the collider is tagged with Player
        if(other.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
