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
    public GameObject key;
    public bool canMove = true;
    
   
    // Start is called before the first frame update
    void Start()
    {
       
        
        
        

    }

    // Update is called once per frame
    void Update()
    {

       

    }
    public void ShowKey()
    {
        key.SetActive(true);
    }
    public void HideKey()
    {
        key.SetActive(false);
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

        SceneManager.LoadScene(0);
    }
    
}
