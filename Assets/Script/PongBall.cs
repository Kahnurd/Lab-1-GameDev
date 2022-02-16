using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{

    [SerializeField] private Rigidbody2D mainRigidbody;
    [SerializeField] private BoxCollider2D mainBoxCollider;
    [SerializeField] private int startSpeed;
    private WaitForSeconds restartWait = new WaitForSeconds(1f);

    // Start is called before the first frame update
    void Start()
    {
        Restart();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void Restart()
    {
        mainRigidbody.position = Vector2.zero;
        mainRigidbody.velocity = Vector2.zero;
        StartCoroutine(startBall());
    }

    IEnumerator startBall()
    {
        Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
        mainRigidbody.velocity = newVelocity.normalized * startSpeed;
        yield return restartWait;
    }
}
