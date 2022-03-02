using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button platformerButton;
    [SerializeField] private Button SpawnerButton;
    [SerializeField] private Button PongButton;
    [SerializeField] private Button openCredits;
    [SerializeField] private Button closeCredits;
    [SerializeField] private GameObject credits;
 


    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        credits.SetActive(false);
        startButton.onClick.AddListener(() => { LoadingScreen.LoadScene("SampleScene"); });
        platformerButton.onClick.AddListener(() => { LoadingScreen.LoadScene("NotQuitePlatformer"); });
        SpawnerButton.onClick.AddListener(() => { LoadingScreen.LoadScene("3DSpawner"); });
        PongButton.onClick.AddListener(() => { LoadingScreen.LoadScene("Pong"); });
        openCredits.onClick.AddListener(() => { credits.SetActive(true); });
        closeCredits.onClick.AddListener(() => { credits.SetActive(false); });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
