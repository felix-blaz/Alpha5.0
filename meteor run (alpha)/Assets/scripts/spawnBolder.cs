using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnBolder : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject powerupPrefab;
    private float startDelay = 5;
    private float repeatDelay = 15;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerup", startDelay, repeatDelay);
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    void SpawnPowerup()
    {
        if (gameManager.isGameActive)
        {
            Vector3 position = new Vector3(Random.Range(-5.0f, 5.0f), 1, 20);
            Instantiate(powerupPrefab, position, powerupPrefab.transform.rotation);
        }
    }
}