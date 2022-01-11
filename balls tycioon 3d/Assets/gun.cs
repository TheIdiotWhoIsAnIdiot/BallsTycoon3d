using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Camera playerCam;
    public GameObject gaming;
    public GameObject LiterallyGaming;
    ballgunpruchas scrip;
    rigi cScript;
    public GameObject Ball;
    private Rigidbody rb;
    public Vector3 offset = new Vector3(2, 0, 0);
    public GameObject PlayerMovement;
    PlayerMovement CScript;
        public TextMesh textt;

    void Awake()
    {
        rb = Ball.GetComponent<Rigidbody>();
    }
    void Start()
    {
      CScript = PlayerMovement.GetComponent<PlayerMovement>();
      cScript = gaming.GetComponent<rigi>();
      scrip = LiterallyGaming.GetComponent<ballgunpruchas>();
    }
    void Update()
    {
      textt.text = $"Balls Left: {cScript.balls}";



      if (Input.GetKeyDown(KeyCode.E) && scrip.alreadybought == true)
      {
        CScript.shouldmove = !CScript.shouldmove;

      }
        if (Input.GetMouseButtonDown(0) && playerCam.enabled == true)
        {
          if (cScript.balls > 0 )
          {
            GameObject BallClone = Instantiate(Ball, transform.position, transform.rotation);
            rb = BallClone.GetComponent<Rigidbody>();
            rb.AddForce(playerCam.transform.forward * 10000);
            cScript.balls--;
          }

        }
    }
}
