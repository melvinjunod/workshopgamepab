using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDropWinTrigger : MonoBehaviour
{
    public GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider) {
        Destroy(collider.gameObject);
        gm.endGame();
    }
}
