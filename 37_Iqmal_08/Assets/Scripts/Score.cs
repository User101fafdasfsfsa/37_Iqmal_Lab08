using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text ScoreText;
    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText.text = "Score :" + score;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            score += 10;
            Destroy(collision.gameObject);
            ScoreText.text = "Score :" + score;
        }
    }
}
