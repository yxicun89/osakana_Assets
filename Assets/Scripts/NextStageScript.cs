using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextStageScript : MonoBehaviour
{
    // Start is called before the first frame update
    public void TwoToOne()
    {
        SceneManager.LoadScene("Stage1SelectScene");
    }
    public void OneToTwo()
    {
        SceneManager.LoadScene("Stage2SelectScene");
    }
    public void TwoToThree()
    {
        SceneManager.LoadScene("Stage3SelectScene");
    }
    public void ThreeToFour()
    {
        SceneManager.LoadScene("Stage4SelectScene");
    }
    public void FourToFive()
    {
        SceneManager.LoadScene("Stage5SelectScene");
    }
    public void FiveToSix()
    {
        SceneManager.LoadScene("Stage6SelectScene");
    }
}
