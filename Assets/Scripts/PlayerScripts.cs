using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScripts : MonoBehaviour
{

    public  Text scoreText;

    
     public GameObject GameOver;
     private int score;
   
    public float speed = 10f;
    private float minx = -2.30f;
     private float maxx = 2.30f;


    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void MovePlayer()
    {
      float d = Input.GetAxis ("Horizontal");
      Vector2 currentPosition = transform.position;

      if(d > 0){
          currentPosition.x += speed * Time.deltaTime;
      }
      else if(d < 0){
          currentPosition.x -= speed * Time.deltaTime;
      }

      if(currentPosition.x < minx){
          currentPosition.x = minx;
      }

          if(currentPosition.x > maxx){
              currentPosition.x = maxx;
          }

     transform.position = currentPosition;
    }
        
         void IncreaseScore()
         {
             score++;
        scoreText.text= "Score" + score;
         }  

   void OnTriggerEnter2D(Collider2D target){

       if(target.tag == "Bomb"){
         // target.gameObject.SetActive(false);
           GameOver.SetActive(true);
           Time.timeScale= 0f;

       }
   }
    
}


  