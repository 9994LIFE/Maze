using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawnobjred : MonoBehaviour
{ 
   
   
      public Vector3 startposition = new Vector3();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            other.GetComponent<script1>().RespawnPlayer(); 
    }
    

}
