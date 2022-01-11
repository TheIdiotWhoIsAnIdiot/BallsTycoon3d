using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class amogusmode : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isbuttonon = false;
    public GameObject button;
    void OnMouseOver()
    {
        var buttonrenderer = button.GetComponent<Renderer>();
        if (Input.GetMouseButtonDown(0))
        {
          if (isbuttonon == false)
          {
            isbuttonon = true;
            buttonrenderer.material.SetColor("_Color", Color.green);

          }
          else
          {
            isbuttonon = false;
            buttonrenderer.material.SetColor("_Color", Color.red);
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
