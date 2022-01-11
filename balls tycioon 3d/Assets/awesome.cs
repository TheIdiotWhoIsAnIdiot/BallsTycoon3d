using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class awesome : MonoBehaviour
{   
    public int increment = 0;
    // Start is called before the first frame update
    public int health = 100;
    public GameObject cool;
    public bool isdead = false;
    rigi Script;
    public GameObject Self;
    public TextMesh healthtext;
    public int bossTokens = 0;
    public TextMesh bossTokensText;

    // wait coroutine
    IEnumerator wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if ((collision.collider.name == "Sphere") || (collision.collider.name == "Sphere(Clone)"))
        {
            if (isdead == false)
            {
                Destroy(collision.collider.gameObject);
                health -= 10;
            }
            else
            {
                Destroy(collision.collider.gameObject);
                Script.balls++;
            }
        }
    }
    void Start()
    {
      Script = cool.GetComponent<rigi>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isdead == true)
        {
            Script.balls = Script.balls + 10;
            increment = increment + 20;
            health = 100 + increment;
            isdead = false;
        }
        if (health <= 0)
        {
            isdead = true;
        }
        healthtext.text = $"Boss Health: {health}";
    }
}
