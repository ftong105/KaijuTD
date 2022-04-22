using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int enemiesAlive = 0;
    public int round = 0;
    public GameObject[] spawnPoints;
    public GameObject enemyPrefab1;
    public GameObject enemyPrefab2;
    public GameObject enemyPrefab3;
    public GameObject enemyPrefab4;

    public Text roundNumber;
    public GameObject endScreen;
    public GameObject winScreen;
    public GameObject pauseScreen;

    public Text Money;
    public static int money;
    public int startMoney = 100;

    void Start()
    {
        endScreen.SetActive(false);
        winScreen.SetActive(false);
        pauseScreen.SetActive(false);
        money = startMoney;
    }

    // Update is called once per frame
    void Update()
    {
        if (enemiesAlive == 0 && round < 10)
        {
            round++;
            NextWave(round);
        }
        roundNumber.text = "Round " + round.ToString();

        WinGame();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
    }

    public void GetMoney()
    {
        money += 10;
        Money.text = "$" + money.ToString();
    }

    public void NextWave(int round)
    {

        /*for (var x= 0; x< round;x++)
        {
            GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            GameObject enemySpawned = Instantiate(enemyPrefab, spawnPoint.transform.position, Quaternion.identity);
            enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

            enemiesAlive++;
        }*/


        if (round == 1)
        {
            for (var x = 0; x < 16; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 2)
        {
            for (var x = 0; x < 30; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 3)
        {
            for (var x = 0; x < 10; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 10; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 4)
        {
            for (var x = 0; x < 20; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab3, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 8; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 5)
        {
            for (var x = 0; x < 25; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 6)
        {
            for (var x = 0; x < 25; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 10; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 7)
        {
            for (var x = 0; x < 50; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab3, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 8)
        {
            for (var x = 0; x < 20; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 20; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 10; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab3, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 9)
        {
            for (var x = 0; x < 6; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab1, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 25; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab2, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }

            for (var x = 0; x < 20; x++)
            {
                GameObject spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length - 1)];

                GameObject enemySpawned = Instantiate(enemyPrefab3, spawnPoint.transform.position, Quaternion.identity);
                enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

                enemiesAlive++;
            }
        }

        if (round == 10)
        {
            GameObject spawnPoint = spawnPoints[5];

            GameObject enemySpawned = Instantiate(enemyPrefab4, spawnPoint.transform.position, Quaternion.identity);
            enemySpawned.GetComponent<EnemyManager>().gameManager = GetComponent<GameManager>();

            enemiesAlive++;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void EndGame()
    {
        Time.timeScale = 0;
        Cursor.lockState = CursorLockMode.None;
        endScreen.SetActive(true);
    }

    public void WinGame()
    {
        if (enemiesAlive == 0 && round == 10)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
            winScreen.SetActive(true);
        }
    }

    public void GameExit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pauseScreen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    public void pauseContinue()
    {
        pauseScreen.SetActive(false);
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
