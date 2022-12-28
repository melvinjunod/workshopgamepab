using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeRotator : MonoBehaviour
{
    
    private Quaternion curRotation;
    
    public GameManager gm;
    public SceneScript scene;
    // Start is called before the first frame update
    void Start()
    {
        curRotation = transform.rotation;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        transform.rotation = Quaternion.Lerp(transform.rotation, curRotation, 0.500f);
        // Debug.Log(transform.rotation.y);
        if(gm.gamePlaying) {
            if(Input.GetKey(KeyCode.R)) {
                scene.Restart();
            }
            if(Input.GetKey(KeyCode.LeftArrow) && transform.rotation.x < -0.55) {
                curRotation *= Quaternion.Euler(0.2f, 0, 0);
            }
            if(Input.GetKey(KeyCode.RightArrow) && transform.rotation.x > -0.85) {
                curRotation *= Quaternion.Euler(-0.2f, 0, 0);
            }
            if(Input.GetKey(KeyCode.DownArrow) && transform.rotation.y > -0.15) {
                curRotation *= Quaternion.Euler(0, -0.2f, 0);
            }
            if(Input.GetKey(KeyCode.UpArrow) && transform.rotation.y < 0.15) {
                curRotation *= Quaternion.Euler(0, 0.2f, 0);
            }
        }
    }
}
