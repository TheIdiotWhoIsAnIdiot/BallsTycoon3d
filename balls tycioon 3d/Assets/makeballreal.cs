using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeballreal : MonoBehaviour
{
    public GameObject dropperbutreal;
    public GameObject dropperbutfake;
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
            dropperbutreal.SetActive(true);
            dropperbutfake.SetActive(false);
          }
          else
          {
            isbuttonon = false;
            buttonrenderer.material.SetColor("_Color", Color.red);
            dropperbutreal.SetActive(false);
            dropperbutfake.SetActive(true);
          }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
      dropperbutreal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
