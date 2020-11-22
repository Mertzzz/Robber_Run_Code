using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Collision_Dmg : MonoBehaviour
{
  
  
    private Animator anim;
   
    

    void Start(){

         anim = GetComponent<Animator>();
         
        
    }

  
   public void OnTriggerEnter2D(Collider2D other){


        if(other.transform.tag=="Hütchen"){

          
           
            GetComponent<Health>().TakeDamage(1) ;
             FindObjectOfType<AudioManager>().Play("PlayerHit");
            anim.Play("Hit");
            anim.SetBool("IsFlying",false);
            
            
            
            

            
            
            

        }
         

            else if (other.transform.tag=="Stein")
            {

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
                 


            } else if(other.transform.tag=="Mülltonne")
            {
                GetComponent<Health>().TakeDamage(1);
                FindObjectOfType<AudioManager>().Play("PlayerHit");
                anim.Play("Hit");
                
            } else if(other.transform.tag=="Reifen"){

                GetComponent<Health>().TakeDamage(1);
                FindObjectOfType<AudioManager>().Play("PlayerHit");
                anim.Play("Hit");
                

            }
            else if(other.transform.tag=="Laterne"){

                GetComponent<Health>().TakeDamage(1);
                FindObjectOfType<AudioManager>().Play("PlayerHit");
                anim.Play("Hit");
               
            }
            else if(other.transform.tag=="Bank"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
                
                 
                 


            }
            else if(other.transform.tag=="AutoGelb"){

                 
                 GetComponent<Health>().TakeDamage(3);
                 anim.SetTrigger("IsCaught");
                 Destroy(GameObject.FindGameObjectWithTag("Polizist"));
                 
                 
                 
                 
                   
                   

            }
             else if(other.transform.tag=="AutoBlau"){

                 GetComponent<Health>().TakeDamage(3);
                 anim.SetTrigger("IsCaught");
                 Destroy(GameObject.FindGameObjectWithTag("Polizist"));
                 
                   

            }
             else if(other.transform.tag=="AutoRot"){

                 GetComponent<Health>().TakeDamage(3);
                 anim.SetTrigger("IsCaught");
                 Destroy(GameObject.FindGameObjectWithTag("Polizist"));
                


            }
             else if(other.transform.tag=="LKW"){

                 GetComponent<Health>().TakeDamage(3);
                 anim.SetTrigger("IsCaught");
                 Destroy(GameObject.FindGameObjectWithTag("Polizist"));
                 
                 
                   


            }
             else if(other.transform.tag=="Polizist"){


                  
                 GetComponent<Health>().TakeDamage(3);
                 anim.SetTrigger("IsCaught");
                 Destroy(GameObject.FindGameObjectWithTag("Polizist"));
                 
                
                
                
                   


            }
             else if(other.transform.tag=="Stopschild"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
               


            }
             else if(other.transform.tag=="WarnungsSchild"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
                
             }


            else if(other.transform.tag=="Baumstamm"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
                


            }
            else if(other.transform.tag=="Zaun1"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
                


            }
            else if(other.transform.tag=="Zaun2"){

                 GetComponent<Health>().TakeDamage(1);
                 FindObjectOfType<AudioManager>().Play("PlayerHit");
                 anim.Play("Hit");
               


            }
             

            }

            }

            


