using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class AppliedMathDecrement : MonoBehaviour
{
    public Image healthBarIncrement;
   public Image healthBarDecrement;
   public Image healthBarLoading;

   public float incrementCount = 0.05f;
   public float DecrementCount = 0.05f;
   public float loadingCount = 0.0000000002f;
    
    void OnWake(){
    healthBarIncrement = GetComponent<Image>();
    healthBarDecrement = GetComponent<Image>();
    healthBarLoading = GetComponent<Image>();
    }
    void Update(){
       Load();
    }
    public void Add(){
        healthBarIncrement.fillAmount += incrementCount/1f;
    }
     public void Minus(){
        healthBarDecrement.fillAmount -= DecrementCount/1f;
    }
     public void Load(){
        healthBarLoading.fillAmount += loadingCount/1f;
    }
}
