using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class adsad : MonoBehaviour
{
    // Start is called before the first frame update
    public Camera mainCam;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mainCam.transform.position = new Vector3(-152.513596f ,22.2432003f ,-54.4700012f );
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
