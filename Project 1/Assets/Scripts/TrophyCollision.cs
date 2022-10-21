using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TrophyCollision : MonoBehaviour
{
    private int trophyCollisionCount;
    public TextMeshPro trophyCountText;


    // Start is called before the first frame update
    void Start()
    {
        trophyCollisionCount = 0;
        trophyCountText.text = "Trophy Count: " + trophyCollisionCount;
    }
    private void OnTriggerEnter2D(Collider2D Trophy)
    {
        if(Trophy.tag == "Trophy")
        {
            trophyCollisionCount += 1;
            trophyCountText.text = "Trophy Count: " + trophyCollisionCount;
        }
    }
}
