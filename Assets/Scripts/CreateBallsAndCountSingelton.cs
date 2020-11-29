using UnityEngine;

public sealed class CreateBallsAndCountSingelton : MonoBehaviour
{
    
    
        private static CreateBallsAndCountSingelton CreateBallsAndCountSingeltoninstance = null;
        private static readonly object padlock = new object();
        public ScoreHolder score;
    

    CreateBallsAndCountSingelton()
    {

    }

        public static CreateBallsAndCountSingelton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (CreateBallsAndCountSingeltoninstance == null)
                    {
                        CreateBallsAndCountSingeltoninstance = new CreateBallsAndCountSingelton();
                    }
                    return CreateBallsAndCountSingeltoninstance;
                }
            }

        }
        public int AddToPointsCollected(int points)
        {
          Debug.Log("pointsincrease");
          points++;
          return points;
          
        }
    public void RandomSpawn(GameObject WhatToSpawn)
    {
        Instantiate(WhatToSpawn, RandomPosition(), Quaternion.identity);
        Debug.Log("EnemySummoned");
    }
    public Vector3 RandomPosition()
    {
        Vector3 randompos = new Vector3(Random.Range(-4, 4), 2, Random.Range(-4, 4));
        return randompos;
        
    }
    
}
