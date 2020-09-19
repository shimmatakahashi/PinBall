using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{
    private float visiblePosZ = -6.5f;
    private GameObject gameoverText;
    // Start is called before the first frame update
    void Start()
    {
        this.gameoverText = GameObject.Find("GameOverText");

    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.visiblePosZ)
        {
            this.gameoverText.GetComponent<Text> ().text = "Game Over";
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "SmallStarTag")
        {
            ScoreScript.scoreValue += 5;
        }
        if(collision.gameObject.tag == "LargeStarTag")
        {
            ScoreScript.scoreValue += 10;
        }
        if (collision.gameObject.tag == "SmallCloudTag")
        {
            ScoreScript.scoreValue += 10;
        }
        if (collision.gameObject.tag == "LargecloudTag")
        {
            ScoreScript.scoreValue += 10;
        }
    }
}
