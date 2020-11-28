using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeBetweenSpheres;
    private float currentTime;
    public GameObject SphereToSpawn;
    // Start is called before the first frame update



    // Update is called once per frame
    void Update()
    {
        if(currentTime < timeBetweenSpheres)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            CreateBallsAndCountSingelton.Instance.RandomSpawn(SphereToSpawn);
            currentTime = 0;
        }
    }
}
