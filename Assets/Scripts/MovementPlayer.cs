using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class MovementPlayer : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D rb;
    public Camera cam;

    Vector2 movement;
    Animator anim;

    public GameObject pauseMenu;

    Transform trans;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        anim = GetComponent<Animator>();
        trans = GetComponent<Transform>();
    }

    // Update is called once per frame
    //void Update()
    //{
    //movement.x = Input.GetAxisRaw("Horizontal");
    //movement.y = Input.GetAxisRaw("Vertical");
    //}

    private void Update()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    public void MoveLeftDown()
    {
        movement.x = -1;
        anim.SetTrigger("Walk");
        trans.localScale = new Vector3(-.6f, .6f, 1);
    }
    public void MoveLeftUp()
    {
        movement.x = 0;
        anim.SetTrigger("Idle");
    }

    public void MoveRightDown()
    {
        movement.x = 1;
        anim.SetTrigger("Walk");
        trans.localScale = new Vector3(.6f, .6f, 1);
    }
    public void MoveRightUp()
    {
        movement.x = 0;
        anim.SetTrigger("Idle");

    }

    public void MoveDownDown()
    {
        movement.y = -1;
        anim.SetTrigger("Walk");

    }
    public void MoveDownUp()
    {
        movement.y = 0;
        anim.SetTrigger("Idle");

    }

    public void MoveUpDown()
    {
        movement.y = 1;
        anim.SetTrigger("Walk");

    }
    public void MoveUpUp()
    {
        movement.y = 0;
        anim.SetTrigger("Idle");

    }

    public void MenuOpen()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
    }

    public void MenuClose()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void MainMenu()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enterCave"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
