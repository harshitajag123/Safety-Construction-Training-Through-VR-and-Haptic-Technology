using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumCollision : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     private void OnCollisionEnter( Collision collision){
         FindAnyObjectByType<PendCntrl>().movependulum= false;
         Debug.Log ( "Collided");

     }
}
