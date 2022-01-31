using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private Button startButton;
    [SerializeField] private Button openCredits;
    [SerializeField] private Button closeCredits;



    void Start()
    {
        startButton.onClick.AddListener(() => { });
        openCredits.onClick.AddListener(() => { });
        closeCredits.onClick.AddListener(() => { });


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
