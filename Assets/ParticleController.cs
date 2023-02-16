using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public GameObject explotionEffect;
    //GameObject explosion;
    GameObject takeobj;
    // Start is called before the first frame update
    void Start()
    {
        //this.explosion=GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnParticleCollision(GameObject obj){
            //obj.transform.GetChild(1).gameObject.GetComponent<ParticleSystem>().Play();
        Instantiate(explotionEffect,obj.transform.position,Quaternion.identity);
        Debug.Log("うん");
        Debug.Log("当たった");
       /*  if(explotionEffect!=null){
            Instantiate(explotionEffect,obj.transform.position,Quaternion.identity);
            Debug.Log("うん");
        }
 */
        Destroy(obj,0.1f);
        
        
    }

    // void OnParticleCollision(GameObject obj){
    //     this.explosion.GetComponent<ParticleSystem>().Play();
    //     this.takeobj=this.obj.Instantiate()
    // }
    // void OnParticleSystemStopped(){
    //     Destroy(this.takeobj);
    //     Debug.Log("kietayo");
    // }
}
