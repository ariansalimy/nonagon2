using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameover : MonoBehaviour
{
    public Text bestT;
    int besttime;
    // Start is called before the first frame update
    void Start()
    {
        besttime = PlayerPrefs.GetInt("bestTime");
        bestT.text = "best time: " + besttime + " seconds";
        PlayerPrefs.Save();
    }
    // Update is called once per frame
    void Update()
    {

    }

}