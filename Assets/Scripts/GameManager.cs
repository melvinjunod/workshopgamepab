using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool gamePlaying;
    public GameObject startPanel;
    public GameObject endPanel;
    // Start is called before the first frame update
    void Start()
    {
        startPanel.SetActive(true);
        endPanel.SetActive(false);
        gamePlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame() {
        startPanel.SetActive(false);
        gamePlaying = true;
    }

    public void endGame() {
        gamePlaying = false;
        endPanel.SetActive(true);
    }
}
