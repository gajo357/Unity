using UnityEngine;

public class PickupParticlesDestruction : MonoBehaviour
{
	// Use this for initialization
	private void Start ()
    {
        if (gameObject.CompareTag("Player"))
            return;

        // destry the particle after 5 seconds
        Destroy(gameObject, 5);
	}
}
