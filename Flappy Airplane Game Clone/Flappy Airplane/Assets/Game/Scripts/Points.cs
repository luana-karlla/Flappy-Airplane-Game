using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    public GameController controller;

    // Start is called before the first frame update
    void Start()
    {
        controller = FindObjectOfType<GameController>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        controller.score++;
        controller.txtScore.text = controller.score.ToString();

       if(gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            
        }
    }
}
