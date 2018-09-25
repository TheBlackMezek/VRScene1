using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatterCubeGoal : MonoBehaviour {

    [SerializeField]
    private Text scoreText;
    [SerializeField]
    private string validTag;

    private int score = 0;




    private void Awake()
    {
        scoreText.text = "SCORE\n" + score;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == validTag)
        {
            ++score;
            scoreText.text = "SCORE\n" + score;
            Destroy(other.gameObject);
            BatterSpawnManager.Instance.SpawnCube();
        }
    }

}
