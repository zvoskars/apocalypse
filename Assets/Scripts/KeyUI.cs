using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
   public GameObject scoreText;
   public AudioSource collectSound;

   void OnTriggerEnter(Collider other){
       scoreText.GetComponent<Text>().text = "Keys: " + DoorScript.doorKey;
       
   }
}
