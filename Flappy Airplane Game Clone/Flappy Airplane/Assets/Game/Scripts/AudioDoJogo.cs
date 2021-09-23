using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioDoJogo : MonoBehaviour
{
    public AudioSource audioJogo;
    public bool tocarMusica;

    // Start is called before the first frame update
    void Start()
    {
        audioJogo = GetComponent<AudioSource>();
        tocarMusica = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (tocarMusica == false)
        {
            audioJogo.Stop();
        }
    }
}
