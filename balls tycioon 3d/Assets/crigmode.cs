using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crigmode : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isbuttonon = false;
    public GameObject button;
    public string squarbal = "ball";
    void OnMouseOver()
    {
        var buttonrenderer = button.GetComponent<Renderer>();
        if (Input.GetMouseButtonDown(0))
        {
          if (isbuttonon == false)
          {
            isbuttonon = true;
            buttonrenderer.material.SetColor("_Color", Color.green);
            squarbal = "square";
          }
          else
          {
            isbuttonon = false;
            buttonrenderer.material.SetColor("_Color", Color.red);
            squarbal = "ball";
          }
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
