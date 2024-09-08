using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0)){
            RaycastHit hit;
            Vector3 hitDirection = transform.TransformDirection(Vector3.forward);
            if(Physics.Raycast(transform.position, hitDirection, out hit, 30)){
                Enemy enemyScript = hit.transform.GetComponent<Enemy>();
                if(enemyScript != null){
                    enemyScript.OnHit();
                    hit.rigidbody.AddForce(hitDirection * 1000);                        
                }

            }else{
            
            }
            
        }
        
    }

   
}
