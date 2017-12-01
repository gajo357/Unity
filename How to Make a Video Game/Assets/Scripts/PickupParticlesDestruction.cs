using UnityEngine;

public class PickupParticlesDestruction : MonoBehaviour
{

	// Use this for initialization
	private void Start ()
    {
        // destry the particle after 5 seconds
        Destroy(gameObject, 5);
	}
}
