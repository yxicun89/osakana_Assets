using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneManager : MonoBehaviour
{
    public void StartButton()
    {
        SceneManager.LoadScene("Stage1SelectScene");
    }
    public void TutorialButton()
    {
        SceneManager.LoadScene("TutorialScene");
    }
}
