using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Animator _playerAnimator;
    private Rigidbody _playerRigidbody;

    private float _moveHorizontal;
    private float _moveVertical;
    private Vector3 _movement;
    private float _turningSpeed = 20f;

    // Use this for initialization
    private void Start ()
    {
        // get the Animator component from the Player GameObject
        _playerAnimator = GetComponent<Animator>();
        _playerRigidbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	private void Update ()
    {
        // get keyboard input
        _moveHorizontal = Input.GetAxisRaw("Horizontal");
        _moveVertical = Input.GetAxisRaw("Vertical");

        // y is vertical in Unity
        _movement = new Vector3(_moveHorizontal, 0, _moveVertical);
    }

    private void FixedUpdate()
    {
        // first we rotate
        // then we move if needed be

        if (_movement != Vector3.zero)
        {
            // create a target rotation based on the movement
            Quaternion targetRotation = Quaternion.LookRotation(_movement, Vector3.up);

            // we do not want to rotate instantly, but rather as an animation
            // got from curent rotation, move to the new one
            // update 20 times faster then the delta
            Quaternion newRotation = Quaternion.Lerp(_playerRigidbody.rotation, targetRotation, _turningSpeed * Time.deltaTime);

            // change the player's rotation to new incremental rotation
            _playerRigidbody.MoveRotation(newRotation);

            // actually move
            _playerAnimator.SetFloat("Speed", 3f);
        }
        else
        {
            _playerAnimator.SetFloat("Speed", 0f);
        }
    }
}
