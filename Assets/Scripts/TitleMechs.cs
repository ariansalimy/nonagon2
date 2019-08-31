using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleMechs : MonoBehaviour
{
    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("mechs");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
    public void Credits ()
    {
        SceneManager.LoadScene("Credits");
    }
    public void BackCredits ()
    {
        SceneManager.LoadScene("Title");
    }
    public void Customize ()
    {
        SceneManager.LoadScene("Customize");
    }
    public void CustomizePlayer()
    {
        SceneManager.LoadScene("CustomizePlayer");
    }
    public void Levels ()
    {
        SceneManager.LoadScene("GameScene");
    }
}

