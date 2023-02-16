using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
    public float speedx;
    public float speedy;
    public float speedz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<50){
            if(Input.GetKey(KeyCode.RightArrow)){
            transform.Translate(speedx,0,0);
           
            }
        }
        if(transform.position.x>-50){
            if(Input.GetKey(KeyCode.LeftArrow)){
            transform.Translate(-speedx,0,0);
            }
        }       
        
        if(transform.position.y<50){
            if(Input.GetKey(KeyCode.UpArrow)){
            transform.Translate(0,speedy,0);
            }
        }

        if(transform.position.y>-10){
            if(Input.GetKey(KeyCode.DownArrow)){
            transform.Translate(0,-speedy,0);
            }

        }
        
        


        transform.Translate(0,0,speedz);



    }
}
