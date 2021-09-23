using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rid2D;
    public float speed = 1f;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
        rid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rid2D.velocity = Vector2.up * speed;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameOver.SetActive(true);
        Time.timeScale=0;
    }
}
