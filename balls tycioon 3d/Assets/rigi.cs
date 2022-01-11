using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rigi : MonoBehaviour
{
    public TextMesh textt;
    public int balls;
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.name == "ball") || (collision.collider.name == "ball(Clone)"))
        {
            Destroy(collision.collider.gameObject);
            balls++;
            textt.text = $"Balls: {balls}";
        }
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      textt.text = $"Balls: {balls}";
    }
}
