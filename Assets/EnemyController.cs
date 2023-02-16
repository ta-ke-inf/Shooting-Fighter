using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,0,-0.5f);
        if(this.player.transform.position.z-transform.position.z>10){
            Destroy(this.gameObject);
        }
    }
}
