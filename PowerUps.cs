using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{

    private Animator anim ;
    private float counter = 0;

    private bool isFlying = false;

    void Start(){

            anim = GetComponent<Animator>();
                
              }

    private void OnTriggerEnter2D(Collider2D other){

        if(other.transform.tag == "JetpackPU"){

           Destroy(other.gameObject);
           anim.SetBool("IsFlying",true);
           isFlying = true;
           GetComponent<Rigidbody2D>().simulated = false;
        }



    }
    void Update(){

        if(isFlying)
        {
            
            counter += Time.deltaTime;
           
            if(counter > 10){

                
                counter  = 0;     
                isFlying = true;
                
                anim.SetBool("IsFlying",false);    
                 GetComponent<Rigidbody2D>().simulated = true;         
                
                
                }
        }

}
}
