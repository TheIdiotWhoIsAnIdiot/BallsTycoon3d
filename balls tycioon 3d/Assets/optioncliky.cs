using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class optioncliky : MonoBehaviour
{
    public Camera mainCam;

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.transform.position = new Vector3(190f, 11.71f, 28.41f);
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
