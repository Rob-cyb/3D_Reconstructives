using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class GameStateManager : MonoBehaviour
{

    public GameObject goodprefab1;
    public GameObject goodprefab2;
    public GameObject goodprefab3;
    public GameObject TrashPrefab1;
    public GameObject TrashPrefab2;
    private int howManyGood1 = 3;
    private int howManyGood2 = 3;
    private int howManyGood3 = 4;
    private int howManyTrash1 = 5;
    private int howManyTrash2 = 5;
    public static float Score;
    public float TrashScore;
    public TMP_Text text;
    public TMP_Text instructions;
     public ParticleSystem rain;
     public ParticleSystem rain1;
     public AudioSource rainsound;
     
   


    // Use this for initialization
    void Start()
    {
        
      instructions.enabled = true;
     


        for (int i = 0; i < howManyGood1; i++)
        {
               
        Instantiate(
        goodprefab1,
        new Vector3(Random.Range(22,78), Random.Range(0.4f,0.4f), Random.Range(5,60)),
        Quaternion.Euler(270, 0, 0)
        );            
        }
              for (int i = 0; i < howManyGood2; i++)
        {
               
        Instantiate(
        goodprefab2,
        new Vector3(Random.Range(22,78), Random.Range(0.4f,0.4f), Random.Range(5,60)),
        Quaternion.Euler(270, 0, 0)
        );            
        }
              for (int i = 0; i < howManyGood3; i++)
        {
               
        Instantiate(
        goodprefab3,
        new Vector3(Random.Range(22,78), Random.Range(0.4f,0.4f), Random.Range(5,60)),
        Quaternion.Euler(270, 0, 0)
        );            
        }

         for (int i = 0; i < howManyTrash1; i++)
        {
               
        Instantiate(
        TrashPrefab1,
        new Vector3(Random.Range(22,78), Random.Range(0.4f,0.4f), Random.Range(5,60)),
        Quaternion.Euler(270, 0, 0)
        );        
        }
           for (int i = 0; i < howManyTrash2; i++)
        {
               
        Instantiate(
        TrashPrefab2,
        new Vector3(Random.Range(22,78), Random.Range(0.4f,0.4f), Random.Range(5,60)),
        Quaternion.Euler(270, 0, 0)
        );
                    
        }

      
    }

    public void Update()
    {

        if(TrashScore >= 5)
        {
            rain.Stop();
        }if(TrashScore == 10)
        {
            rain1.Stop();
            rainsound.Stop();
        }

    
    

}
    public float getScore()
        {
        return Score;
        }

    public void setScore(float s)
        {
        Score = s;
        }

    public void adjustScore(float s)
    {
        Score += s;
        text.text = Score.ToString();
    }
    public float getTrashScore()
        {
        return TrashScore;
        }

    public void setTrashScore(float ts)
    {
        TrashScore = ts;
    }
    public void adjustTrashScore(float ts)
    {
        TrashScore += ts;
       
    }



}

