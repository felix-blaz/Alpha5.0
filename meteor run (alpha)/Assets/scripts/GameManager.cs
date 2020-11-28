using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject titleScreen;
    public TextMeshProUGUI gameOverText;
    public List<GameObject> meteors;
    public bool isGameActive = true;
    private float spawnRate = 1.0f;
    public Button restartButton;
    // Start is called before the first frame update
    void Start()
    {
      
        

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(true);
        isGameActive = false;
    }

    IEnumerator SpawnMeteor()
    {
        while(isGameActive)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, meteors.Count);
            Instantiate(meteors[index]);
        }
    }
    public void RestartGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void StartGame()
    {
        isGameActive = true;
        StartCoroutine(SpawnMeteor());
        titleScreen.gameObject.SetActive(false);
    }
    
}
