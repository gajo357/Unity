using UnityEngine;

public class FlyPickup : MonoBehaviour
{
    [SerializeField]
    private GameObject pickupPrefab;

	private void OnTriggerEnter(Collider other)
    {
        // if the collider is tagged with Player
        if(other.CompareTag("Player"))
        {
            // add the pickup particles
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);

            Destroy(gameObject);

            // decrease the number of flies
            FlySpawner.TotalFlies--;
        }
    }
}
