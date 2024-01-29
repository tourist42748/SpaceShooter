using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float GameSpeed;

    [Range(0, 5)] public float GameSpeedRegulator;
    public float SpeedRate = 0.5f;
    public float GameSpeedMax = 5f;

    private void Update()
    {
        if (GameSpeedRegulator <= GameSpeedMax)
        {
            GameSpeedRegulator += SpeedRate * Time.deltaTime;
        }
        GameSpeed = GameSpeedRegulator;
    }

}
