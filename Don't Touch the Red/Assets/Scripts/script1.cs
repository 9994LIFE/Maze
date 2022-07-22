using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script1 : MonoBehaviour
{
    public float speed = 7;
    public float rotatespeed = 5;
    public Vector3 respawnPosition;
    
    private void Start()
   
   
    {
        Cursor.visible = false; respawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, Input.GetAxis("Mouse X") * rotatespeed, 0);
        Vector3 movement = new Vector3(horizontal, 0, vertical)  * speed * Time.deltaTime;
       
        transform.Translate(movement);

    } //end of script

    public void RespawnPlayer()
    {
        transform.position = respawnPosition;
    }
}
