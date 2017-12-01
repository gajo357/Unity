using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField]
    private Transform player;

    [SerializeField]
    private Vector3 offset;

    private float _cameraFollowSpeed = 5;

	// Update is called once per frame
	private void Update ()
    {
        Vector3 newPosition = player.position + offset;

        transform.position = Vector3.Lerp(transform.position, newPosition, _cameraFollowSpeed * Time.deltaTime);
	}
}
