using System;
using UnityEngine;

public class GreenBallCollisionManager : BallCollisionManager
{
    public GameObject greenBallPrefab;
    public GameObject plane;

    public override void CollideWithBall(GameObject OtherBall)
    {
        Debug.Log("Green Ball Collision Manager Function");

        // Homework: Do something interesting here
        if (OtherBall.GetComponent<RedBallCollisionManager>() != null)
        {
            Debug.Log("Green Collided With Red");

            transform.localScale += new Vector3 (1,1,1);
        }
    }
}

