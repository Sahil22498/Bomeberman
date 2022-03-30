using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CollectorScript : MonoBehaviour
{
   public Text scoreText;
   private int score=0;
     
     void IncreaseScore(){
       
       score++;
      scoreText.text= "Score" + score;

 }
        void OnTriggerEnter2D(Collider2D target){
       
        if(target.tag=="Fruit1"){


          IncreaseScore();
        target.gameObject.SetActive(false);
        }
        else if(target.tag=="Fruit2"){


          IncreaseScore();
        target.gameObject.SetActive(false);
        }
       else if(target.tag=="Fruit3"){


          IncreaseScore();
        target.gameObject.SetActive(false);
        }
         
    }
}
