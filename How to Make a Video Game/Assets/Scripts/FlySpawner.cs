using UnityEngine;

public class FlySpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject flyPrefab;

    [SerializeField]
    private int totalFlyMinimum = 12;

    /// <summary>
    /// The area in which flies can be positioned
    /// </summary>
    private float _spawnArea = 25f;

    /// <summary>
    /// Total number of flies currently alive
    /// </summary>
    public static int TotalFlies;

	// Use this for initialization
	private void Start ()
    {
        TotalFlies = 0;
	}
	
	// Update is called once per frame
	private void Update ()
    {
        // create at least the minimum number of flies
		while(TotalFlies < totalFlyMinimum)
        {
            // create a random position for a fly
            float positionX = Random.Range(-_spawnArea, _spawnArea);
            float positionZ = Random.Range(-_spawnArea, _spawnArea);
            var posisiton = new Vector3(positionX, 2f, positionZ);

            // create a new fly
            Instantiate(flyPrefab, posisiton, Quaternion.identity);

            // increase the fly count
            TotalFlies++;
        }
	}
}
