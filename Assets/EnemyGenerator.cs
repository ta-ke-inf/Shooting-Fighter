using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject enemy;
    GameObject player;
    public float span;
    float time=0;
    // Start is called before the first frame update
    void Start()
    {
        this.player=GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        this.time+=Time.deltaTime;
        if(this.time>this.span){
            this.time=0;
            int GenerateXPos=Random.Range(-50,50);
            int GenerateYPos=Random.Range(-10,50);
            Instantiate(this.enemy,new Vector3(GenerateXPos,GenerateYPos,this.player.transform.position.z+100),Quaternion.identity);
        }
    }
}
