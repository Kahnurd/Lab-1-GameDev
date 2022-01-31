using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button openCredits;
    [SerializeField] private Button closeCredits;
    [SerializeField] private GameObject credits;
 


    void Start()
    {
        credits.SetActive(false);
        startButton.onClick.AddListener(() => { LoadingScreen.LoadScene("SampleScene"); });
        openCredits.onClick.AddListener(() => { credits.SetActive(true); });
        closeCredits.onClick.AddListener(() => { credits.SetActive(false); });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
