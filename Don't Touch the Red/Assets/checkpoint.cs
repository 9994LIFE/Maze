using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerenter(Collider other)

    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 newPosition = transform.position;
            newPosition.y = newPosition.y +1;
            other.GetComponent<script1>().respawnPosition = newPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
