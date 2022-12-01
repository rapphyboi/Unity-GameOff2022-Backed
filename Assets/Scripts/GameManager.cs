using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; }



    //NORMAL SPAWN VARIABLES
    [SerializeField] float normalMinValueSpawn = 3f;
    public float MinValueSpawn { get { return normalMinValueSpawn; } }

    [SerializeField] float normalMaxValueSpawn = 7f;
    public float MaxValueSpawn { get { return normalMaxValueSpawn; } }

    //HORDE SPAWN VARIABLES

    [SerializeField] float hordeMinValueSpawn = 2f;
    public float HordeMinValueSpawn { get { return hordeMinValueSpawn; } }

    [SerializeField] float hordeMaxValueSpawn = 3f;
    public float HordeMaxValueSpawn { get { return hordeMaxValueSpawn; } }


    bool isPaused = false;
    public bool IsPaused { get { return isPaused; } }


    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }
    private void Start()
    {

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 1)
            {
                isPaused = true;
                PauseGame();
            }
            else
            {
                isPaused = false;
                ResumeGame();
            }
        }
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        LoadGame();
    }
}
