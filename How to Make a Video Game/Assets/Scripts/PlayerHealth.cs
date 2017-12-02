using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public bool Alive;

    [SerializeField]
    private GameObject pickupPrefab;

	// Use this for initialization
	private void Start ()
    {
        Alive = true;
	}
	
	// Update is called once per frame
	private void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!Alive)
            return;

        // if the collider is tagged with Player
        if (other.CompareTag("Enemy"))
        {
            Alive = false;

            // create the pickup particles
            Instantiate(pickupPrefab, transform.position, Quaternion.identity);
        }
    }
}
