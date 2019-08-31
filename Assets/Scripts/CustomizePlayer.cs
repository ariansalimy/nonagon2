using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class CustomizePlayer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void square1()
    {
        PlayerPrefs.SetInt("player", 1);
        PlayerPrefs.Save();
    }
    void square2()
    {
        if (PlayerPrefs.GetInt("unlocked") >= 2)
        {
            PlayerPrefs.SetInt("player", 2);
            PlayerPrefs.Save();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
