using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class topfactory : MonoBehaviour  
{
    public GameObject top;
    public float sure = 2f;
    public float minX = -8f;
    public float maxX = 8f;
    public float spawnY = 10f;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(TopUret());
    }

    IEnumerator TopUret()
    {
        while (true)
        {
            float randomX = Random.Range(minX, maxX);
            Instantiate(top, new Vector2(randomX, spawnY), Quaternion.identity);
            yield return new WaitForSeconds(sure);  
        }
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
