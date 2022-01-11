using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clicky : MonoBehaviour
{
    

    public Camera mainCam;

    
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.transform.position = new Vector3(10.628f, 6.26967f, -6.4799f);
        }
    }

    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
