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
    // Start is called before the first frame update
    void Start()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        count = gos.Length;
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] gos;
        gos = GameObject.FindGameObjectsWithTag("Enemy");
        count = gos.Length;

        if (count == 0)
        {
            youWin.SetActive(true);
            startOver.SetActive(true);
        }

    }

    public void TutorialButton()
    {
        tutorial.SetActive(false);
        tutorialButton.SetActive(false);
    }
    
    public void RestartGame()
    {
        UnityEngine.SceneManagement.Scene scene = SceneManager.GetActiveScene(); SceneManager.LoadScene(scene.name);
    }
    
    public void YouWin()
    {
        SceneManager.LoadScene("Start Game");
    }
    
}
