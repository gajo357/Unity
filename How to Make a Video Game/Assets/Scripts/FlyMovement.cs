using UnityEngine;

public class FlyMovement : MonoBehaviour
{
    [SerializeField]
    private Transform center;

    private float _flySpeed;

	// Use this for initialization
	private void Start ()
    {
        _flySpeed = Random.Range(300f, 700f);
	}
	
	// Update is called once per frame
	private void Update ()
    {
        transform.RotateAround(center.position, Vector3.up, _flySpeed * Time.deltaTime);
	}
}
