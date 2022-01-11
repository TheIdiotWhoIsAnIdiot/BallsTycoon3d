using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public float health = 100f;
    public int squareKills = 0;
    public int balls = 0;
    public int ballGunShots = 0;
    public int score = 0;
    void Start()
    {
        
    }
    void Update()
    {
        
        score = balls * 10 + squareKills * 100 + ballGunShots;
    }
}
