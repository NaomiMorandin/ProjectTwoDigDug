using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonSceneLoader : MonoBehaviour
{
    public GameObject startButton;

    public void WhenPressed()
    {
        SceneManager.LoadScene("Gamescene");
    }

}
