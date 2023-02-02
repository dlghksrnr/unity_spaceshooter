using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = -1f;
        float rx = Random.Range(-0.7f, 0.7f);
        var dir = new Vector3(rx, 0.05f, 0);
        dir.Normalize();
        this.transform.Translate(dir * speed * Time.deltaTime);
        //this.transform.position = new Vector3(rx, dir, 0);
        if (transform.position.y<-5f)
        {
            Destroy(gameObject);
        }
        
    }
}
