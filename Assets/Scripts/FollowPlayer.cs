using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset = new Vector3(0, 3, -7);



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        // Set position of camera to be that of Vehicle + an offset value
        transform.position = player.transform.position + offset;
        
    }
}
