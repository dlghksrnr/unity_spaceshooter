using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1f;
        var dir = new Vector3(0, 0.05f, 0);
        dir.Normalize();
        this.transform.Translate(dir*speed*Time.deltaTime);
        if (transform.position.y > 5.0f)
        {
            Destroy(gameObject);
        }
    }
}
