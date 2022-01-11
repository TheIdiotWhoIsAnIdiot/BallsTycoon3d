using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuclicky : MonoBehaviour
{
    public Camera mainCam;


    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.transform.position = new Vector3(148.7f, 7.8f, 23.8f);
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
