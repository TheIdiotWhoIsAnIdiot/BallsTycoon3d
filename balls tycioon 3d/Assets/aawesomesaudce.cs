using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aawesomesaudce : MonoBehaviour
{
    public Camera mainCam;

    // Start is called before the first frame update
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.transform.position = new Vector3(10.628f, 6.26967f, -6.4799f);
        }
    }


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
