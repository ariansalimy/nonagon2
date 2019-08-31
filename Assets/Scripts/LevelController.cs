using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    float rotateSpeed = 0.0f;
    public static float timer;
    float countdown = 4;
    public Text timerText;
    bool forwards = true;
    bool start = true;
    bool start2 = false;
    GameObject mechs;
    GameObject nonagon;
    GameObject alert;
    float reverseTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        nonagon = GameObject.FindGameObjectWithTag("nonagon");
        alert = GameObject.Find("Alert");
        mechs = GameObject.Find("mechs");
        alert.SetActive(false);
        reverseTimer = Random.Range(11.0f, 14.0f);
        timer = 0;
        Invoke("Begin", 3);
    }

    // Update is called once per frame
    void Update()
    {
        nonagon.transform.eulerAngles = new Vector3(nonagon.transform.eulerAngles.x, nonagon.transform.eulerAngles.y, nonagon.transform.eulerAngles.z + rotateSpeed);
        if (start == true)
        {
            timerText.text = "" + (int)countdown;
            countdown -= Time.fixedDeltaTime;
        }
        // Counts up time
        if (start == false)
        {
            timer += Time.fixedDeltaTime;
            timerText.text = "" + (int)timer;
        }
        if (countdown <= 0)
        {
            start = false;
        }

        reverseTimer -= Time.fixedDeltaTime;
        if (reverseTimer <= 3 && start == false)
        {
            alert.SetActive(true);
            if (reverseTimer <= 0)
            {
                Reverse();
            }
        }
    }
 
  
    void Reverse()
    {
        alert.SetActive(false);
        rotateSpeed = rotateSpeed * -1;
        reverseTimer = Random.Range(6.0f, 9.0f);
    }

    public void Begin()
    {
        rotateSpeed = 1.0f;
    }

}


