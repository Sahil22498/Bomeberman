using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
     public GameObject Fruit1Prefabs;
     public GameObject Fruit2Prefabs;   
     public GameObject Fruit3Prefabs;
     public GameObject bombPrefabs;

     private float minx = -2.30f;
     private float maxx = 2.30f;

    void Start()
    {
      StartCoroutine(SpawnBombs());  
     StartCoroutine(Fruit1());
       StartCoroutine(Fruit2());
      StartCoroutine(Fruit3());
    }

    IEnumerator SpawnBombs(){
         
        yield return new WaitForSeconds(Random.Range(2f,4f));
      
      Instantiate(bombPrefabs, new  Vector2(Random.Range(minx,maxx),transform.position.y), 
      Quaternion.identity);

      StartCoroutine(SpawnBombs());  
    }

    IEnumerator Fruit1(){
        yield return new WaitForSeconds(Random.Range(1f,2f));

         Instantiate(Fruit1Prefabs, new Vector2(Random.Range(minx,maxx),transform.position.y),
       Quaternion.identity);
       

         StartCoroutine(Fruit1());

    }

    IEnumerator Fruit2(){
        yield return new WaitForSeconds(Random.Range(2f,3f));

        Instantiate(Fruit2Prefabs, new Vector2(Random.Range(minx,maxx),transform.position.y),
        Quaternion.identity);

        StartCoroutine(Fruit2());
    }
     
     IEnumerator Fruit3(){
         yield return new WaitForSeconds(Random.Range(1f,3f));

         Instantiate(Fruit3Prefabs, new Vector2(Random.Range(minx,maxx),transform.position.y),
         Quaternion.identity);

         StartCoroutine(Fruit3());

     }
}
