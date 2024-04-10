using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{
    GameObject GreenBox;
    GameObject GreenTraking;
    GameObject RedBox;
    GameObject RedTraking;
    GameObject BlueBox;
    GameObject BlueTraking;

    // Start is called before the first frame update
    void Start()
    {
        GreenBox = GameObject.Find("GreenBox");
        GreenTraking = GameObject.Find("GreenTracker");
        RedBox = GameObject.Find("RedBox");
        RedTraking = GameObject.Find("RedTracker");
        BlueBox = GameObject.Find("BlueBox");
        BlueTraking = GameObject.Find("BlueTracker");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 positionG = new Vector3();
        Quaternion rotationG = new Quaternion();

        Vector3 positionR = new Vector3();
        Quaternion rotationR = new Quaternion();

        Vector3 positionB = new Vector3();
        Quaternion rotationB = new Quaternion();
       
        
        positionG = GreenTraking.transform.position;
        positionG.y -= 0.149f;
        positionG.x -= 0.004f;
        positionG.z += 0.034f;
        rotationG = GreenTraking.transform.rotation;

        GreenBox.transform.rotation = rotationG;
        GreenBox.transform.position = positionG;

        positionR = RedTraking.transform.position;
        positionR.y -= 0.173f;
        positionR.x += 0.04f;
        positionR.z -= 0.033f;
        rotationR = RedTraking.transform.rotation;

        RedBox.transform.rotation = rotationR;
        RedBox.transform.position = positionR;

        positionB = BlueTraking.transform.position;
        positionB.y -= 0.170f;
        positionB.x += 0.010f;
        positionB.z += 0.021f;
        rotationB = BlueTraking.transform.rotation;

        BlueBox.transform.rotation = rotationB;
        BlueBox.transform.position = positionB;
    }
}
