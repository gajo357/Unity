using UnityEngine;
using UnityEngine.AI;

public class BirdMovement : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    [SerializeField]
    private RandomSoundPlayer birdFootsteps;

    private NavMeshAgent birdAgent;
    private Animator birdAnimator;

	// Use this for initialization
	private void Start ()
    {
        birdAgent = GetComponent<NavMeshAgent>();
        birdAnimator = GetComponent<Animator>();
	}

    // Update is called once per frame
    private void Update ()
    {
        // set the bird's destination
        birdAgent.SetDestination(target.position);

        // measure the magnitute of nav mesh velocity
        float speed = birdAgent.velocity.magnitude;

        // pass the velocity to animator component
        birdAnimator.SetFloat("Speed", speed);

        birdFootsteps.enabled = speed > 0;
	}
}
