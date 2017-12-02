using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public static int Score;

    private Text scoreCounterText;

	// Use this for initialization
	private void Start ()
    {
        Score = 0;
        scoreCounterText = GetComponent<Text>();
	}

    // Update is called once per frame
    private void Update ()
    {
        scoreCounterText.text = string.Format("{0} Flies", Score);
	}
}
