using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongManager : MonoBehaviour

{

    [SerializeField] private PongBall ball;
    [SerializeField] private PongGoal p1Goal;
    [SerializeField] private PongGoal p2Goal;
    [SerializeField] private TextMeshProUGUI playerOneScore;
    [SerializeField] private TextMeshProUGUI playerTwoScore;
    [SerializeField] private TextMeshProUGUI victoryText;
    public int redScore = 0;
    public int realRedScore;
    public int blueScore = 0;
    public int realBlueScore;

    private WaitForSeconds restartWait = new WaitForSeconds(5f);
    void Start()
    {
        Awake();
    }
    void Update()
    {
        realRedScore = redScore/2;
        realBlueScore = blueScore/2;
        playerOneScore.text = "Player 1: " + realRedScore.ToString();
        playerTwoScore.text = "Player 2: " + realBlueScore.ToString();

        if(redScore == 10) {
        victoryText.text = "Player 1 Wins!";
        StartCoroutine(restartGame());
        }

        if(blueScore == 10) {
        victoryText.text = "Player 2 Wins!";
        StartCoroutine(restartGame());
        }
    }

    void HandleP1Score() {
        redScore++;
        ball.Restart();
    }

    void HandleP2Score() {
        blueScore++;
        ball.Restart();
    }

    private void Awake() {
    p2Goal.onScore += HandleP2Score;
    p1Goal.onScore += HandleP1Score;
    ball.Restart();
    }
      IEnumerator restartGame() {
        yield return restartWait;
        redScore = 0;
        blueScore = 0;
        victoryText.text = "";
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
