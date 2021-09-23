using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRGrass : MonoBehaviour
{
 
    public GameObject rGrass;
    public float height;
    float timer = 0f;
    public float maxTime = 1f;
   
    // Start is called before the first frame update
    void Start()
    {
        GameObject newRGrass = Instantiate(rGrass);
        newRGrass.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > maxTime)
        {
            GameObject newRGrass = Instantiate(rGrass);
            newRGrass.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newRGrass, 20f);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
