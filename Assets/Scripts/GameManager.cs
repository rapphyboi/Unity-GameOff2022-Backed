using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
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



    int currentSceneIndex;

    private void Start()
    {
        
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void GameOver()
    {
        RestartGame();
    }
}
