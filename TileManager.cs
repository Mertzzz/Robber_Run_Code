using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TileManager : MonoBehaviour
{


    public GameObject[] tileprefabs;
    private Transform playerTransform;

    private float spawnY = 0.0f;

    private float tileLenght = 83.3f;

    private int amnTilesOnScreen = 1;

    

    private int lastPrefabIndex = 0;
    private List<GameObject>activeTiles;
    // Start is called before the first frame update
    void Awake()
    {
        activeTiles = new List<GameObject>();
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void SpawnTile (int prefabIndex = -1){

        GameObject go ;
        go = Instantiate(tileprefabs[RandomPrefabIndex()] as GameObject);
        go.transform.SetParent(transform);
        go.transform.position = Vector2.up * spawnY;
        spawnY += tileLenght;
        activeTiles.Add(go);

    }

        private void DeleteTile(){

         Destroy(activeTiles[0]);
         activeTiles.RemoveAt(0);


    } 
     private int RandomPrefabIndex(){

            if (tileprefabs.Length <= 1)
            return 0;

            int randomIndex = lastPrefabIndex;

            while(randomIndex ==lastPrefabIndex){

                randomIndex = Random.Range(0,tileprefabs.Length);
            }

            lastPrefabIndex = randomIndex;
            return randomIndex;

            }
            
    void Update(){

            if(playerTransform.position.y  > (spawnY - amnTilesOnScreen * tileLenght)) {

                SpawnTile();
                
                
                spawnY = spawnY +107.5f;
                if(playerTransform.position.y > 200) {
                    
                    DeleteTile();


                }
            }

                

                
               
                
            }

           
}
            
        

     



   