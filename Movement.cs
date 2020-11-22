using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Movement : MonoBehaviour
{

  
  float zaehler = 0;
  public TextMeshProUGUI textscore;

  public Rigidbody2D rb ;
  float speedUpdateTime = 0f; 

  private float deltaX,deltaY;

  private Animator anim;

  

    

  



public float moveSpeed;
public int SpeedWithTime = 20;




void Start(){

rb =GetComponent<Rigidbody2D>();
anim=GetComponent<Animator>();

}

public void FixedUpdate(){
   
 
 transform.Translate(Vector3.up * Time.deltaTime * SpeedWithTime, Space.Self);//UP
 zaehler++;
 textscore.text = zaehler.ToString();
 
 

 


 

 if (Input.GetKey (KeyCode.A)) {
 transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.Self);//LEFT
 
 }
 if (Input.GetKey (KeyCode.D)) {
 transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.Self); //RIGHT
 }
 
 

 }

 private void OnTriggerEnter2D(Collider2D other){

   if(other.transform.tag == "Magnet"){
     
     
     Destroy(other.gameObject);
   }


 }
 private void Update()
   {

speedUpdateTime += Time.deltaTime;
if (speedUpdateTime > 5) {
SpeedWithTime=SpeedWithTime+1;
speedUpdateTime = 0;
}
if(SpeedWithTime==40){
  

  speedUpdateTime = 2;


}



 }



}
      
  
  
    

    



     






    