using UnityEngine;

public class ScoreHolder : MonoBehaviour
{
    public int PointsCollected;
    // Start is called before the first frame update
    void Start()
    {
        PointsCollected = 0;

    }

// Update is called once per frame
    public void HitTarget()
    {
        
        PointsCollected = CreateBallsAndCountSingelton.Instance.AddToPointsCollected(PointsCollected);
        Debug.Log("Points: " +  PointsCollected);
    }
}
