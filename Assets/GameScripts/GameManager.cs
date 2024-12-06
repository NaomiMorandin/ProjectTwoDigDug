using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject tutorialButton;
    public GameObject tutorial;
    public GameObject restartButton;
    public int count;
    public CharacterStats cs;
    public GameObject youWin;
    public GameObject startOver;
    public int enemyCount = 0;
    public bool canMove = true;
    GameObject[] enemiesAlive;
    List<GameObject> enemies = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("Enemy");

        foreach (GameObject go in gameObjects) { 
            enemies.Add(go);
        }

        
        enemyCount = GameObject.FindGameObjectsWithTag("Enemy").Length;
        //enemy count is set to the number of game objects with the tag Enemy
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
       


    }

    public void TutorialButton()
    {
        tutorial.SetActive(false);
        tutorialButton.SetActive(false);
        //when function is called from button press, turn off the tutorial.
    }
    
    public void RestartGame()
    {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
        //when restart game function is called, it reloads the current active scene.
    }
    public void ShowWinUI()
    {
        youWin.SetActive(true);
        startOver.SetActive(true);
        canMove = false;
    }
    public void YouWin()
    {

        SceneManager.LoadScene("Start Game");
        //when you win function is called, set the UI for winning active and 
    }
    
}
