using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameState : MonoBehaviour
{
    [SerializeField]
    private Text gameStateText;
    [SerializeField]
    private GameObject player;
    [SerializeField]
    private BirdMovement birdMovement;
    [SerializeField]
    private FollowCamera followCamera;

    private PlayerMovement _playerMovement;
    private PlayerHealth _playerHealth;

    private bool _gameStarted = false;

    private float _restartDelay = 3f;
    private float _restartTimer = 0f;

    // Use this for initialization
	private void Start ()
    {
        // we do not use the mouse
        Cursor.visible = false;

        // get components
        _playerMovement = player.GetComponent<PlayerMovement>();
        _playerHealth = player.GetComponent<PlayerHealth>();

        // prevent the player, bird and camera from moving at the start of the game
        _playerMovement.enabled = false;
        birdMovement.enabled = false;
        followCamera.enabled = false;
    }
	
	// Update is called once per frame
	private void Update ()
    {
        // game not started and user pressed the Space bar, start the game
		if(!_gameStarted && Input.GetKeyUp(KeyCode.Space))
        {
            StartGame();
        }
        // player no longer alive
        else if(!_playerHealth.Alive)
        {
            EndGame();

            // wait a bit after the game has ended
            _restartTimer += Time.deltaTime;
            if(_restartTimer >= _restartDelay)
            {
                // restart the game
                // unity has built in management
                // relad the currently loaded game
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

                _restartTimer = 0;
            }
        }
    }

    private void StartGame()
    {
        // enable movement the player, bird and camera from moving at the start of the game
        _gameStarted = true;

        // hide the text
        gameStateText.color = Color.clear;

        // enable the player, bird and camera from moving at the start of the game
        _playerMovement.enabled = true;
        birdMovement.enabled = true;
        followCamera.enabled = true;
    }

    private void EndGame()
    {
        // enable movement the player, bird and camera from moving at the start of the game
        _gameStarted = false;

        // we could change the text to be empty, but this is easier
        gameStateText.color = Color.white;
        gameStateText.text = "Game Over";

        // enable the player, bird and camera from moving at the start of the game
        _playerMovement.enabled = false;
        birdMovement.enabled = false;
        followCamera.enabled = false;

        // remove the player from the game
        player.SetActive(false);
    }
}
