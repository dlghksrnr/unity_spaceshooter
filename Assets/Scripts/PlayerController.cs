using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 1f;
    public GameObject laserPrefab;
    public GameObject enermyPrefab;
    //private GameObject laserPrefab;
    void Start()
    {
        //this.laser = GetComponent<GameObject>();
        //this.enermyPrefab=GetComponent<GameObject>();
    }


    void Update()
    {
        
        Instantiate(enermyPrefab);
        //Input.GetAxis
        var dirx=Input.GetAxisRaw("Horizontal"); //-1,0,1 //반환 타입 float
        var diry=Input.GetAxisRaw("Vertical");
        //Debug.LogFormat("{0}", dirx);
        //이동
        //방향*속도*시간
        var dir=new Vector3(dirx,diry,0);
        dir.Normalize();
        this.transform.Translate(dir * speed * Time.deltaTime);
        this.Attack();
        
        
    }
    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            Debug.LogFormat("attack");
            Instantiate(laserPrefab);

        }
    }
    
}
