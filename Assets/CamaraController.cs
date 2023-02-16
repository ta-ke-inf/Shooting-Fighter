using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraController : MonoBehaviour
{
    Vector3 diff;
    public GameObject player;
    public float followSpeed;
    // Start is called before the first frame update
    void Start()
    {
        this.diff=this.player.transform.position-transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position=Vector3.Lerp(transform.position,player.transform.position-this.diff,Time.deltaTime*this.followSpeed);
    }
}
