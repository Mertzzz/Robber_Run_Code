using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectCoin : MonoBehaviour
{

    
    private AudioSource tickSource;
    private float coin = 0;

    public TextMeshProUGUI textCoins;
    

    void Start(){

           

            tickSource = GetComponent<AudioSource> ();

    }
    

    private void OnTriggerEnter2D(Collider2D other){

        if(other.transform.tag=="Coin"){
            tickSource.Play();
            coin++;
            textCoins.text = coin.ToString();
            
            Destroy(other.gameObject);
        
            
        }

        


    }

    

    


}

