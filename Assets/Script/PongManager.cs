using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PongManager : MonoBehaviour

{

    [SerializeField] private PongBall ball;
    [SerializeField] private PongGoal p1Goal;
    [SerializeField] private TextMeshProUGUI textDisplay;
    public int redScore = 0;
    public int blueScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        Awake();
    }

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = redScore.ToString();
    }

    void HandleP1Score() {
        redScore++;
    }

    void HandleP2Score() {
        
    }

    private void Awake() {
    p1Goal.onScore += HandleP2Score;
    /*p2Goal.onScore += HandleP1Score;*/
    ball.Restart();
 
    }
}
