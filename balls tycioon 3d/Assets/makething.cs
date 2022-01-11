using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makething : MonoBehaviour
{
    public Transform ball;
    public Transform square;
    GameObject crigmode;
    crigmode cScript;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (cScript.squarbal == "ball")
            {
              Instantiate(ball, new Vector3(10.198f, 7.85f, -17.65f), Quaternion.identity);
            }
            if (cScript.squarbal == "square")
            {
              Instantiate(square, new Vector3(10.198f, 7.85f, -17.65f), Quaternion.identity);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      crigmode = GameObject.Find("crigmode");
      cScript = crigmode.GetComponent<crigmode>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
