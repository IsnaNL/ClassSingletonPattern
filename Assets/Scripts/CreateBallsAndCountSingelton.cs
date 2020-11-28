using UnityEngine;

public sealed class CreateBallsAndCountSingelton : MonoBehaviour
{
    
    
        private static CreateBallsAndCountSingelton CreateBallsAndCountSingeltoninstance = null;
        private static readonly object padlock = new object();
        private int PointsCollected;
        
    

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
        public void AddToPointsCollected()
        {
            PointsCollected++;
        }
    public void RandomSpawn(GameObject WhatToSpawn)
    {
        Instantiate(WhatToSpawn, RandomPosition(), Quaternion.identity);
    }
    public Vector3 RandomPosition()
    {
        Vector3 randompos = new Vector3(Random.Range(-4, 4), 2, Random.Range(-4, 4));
        return randompos;
    }
    
}
