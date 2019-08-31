using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerScript : MonoBehaviour
{
    Rigidbody2D rb2d;
    public int jumps = 2;
    GameObject mechs;
    // Start is called before the first frame update
    void Start()
    {
        mechs = GameObject.FindGameObjectWithTag("mechs");
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            jump();
        }
    }
    private void FixedUpdate()
    {
        if (rb2d.velocity.y < .1f)
        {
            rb2d.gravityScale = 1.5f;
        }
        if (rb2d.velocity.y >= .1f)
        {
            rb2d.gravityScale = 1.0f;
        }
    }
    void jump()
    {
        if (jumps > 0)
        {
            rb2d.velocity = new Vector2(rb2d.velocity.x, 4);
            jumps -= 1;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            PlayerPrefs.SetInt("bestTime", (int)LevelController.timer);
            SceneManager.LoadScene("GameOver");
        }
        else
        {
            jumps = 2;
        }
    }
    
}
