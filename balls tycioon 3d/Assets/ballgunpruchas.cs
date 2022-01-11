using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballgunpruchas : MonoBehaviour
{
  public GameObject crigmode;
  rigi cScript;
    public GameObject button;
    public bool alreadybought = false;
    public TextMesh textt;
    public TextMesh texttt;
    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var buttonrenderer = button.GetComponent<Renderer>();
            if (cScript.balls >= 100 && alreadybought == false)
            {
              cScript.balls = cScript.balls - 100;
              alreadybought = true;
              buttonrenderer.material.SetColor("_Color", Color.red);
              textt.text = "purchased";
              texttt.transform.position = new Vector3(17.5799999f, 8.97000027f, -16.8700008f);
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        cScript = crigmode.GetComponent<rigi>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
