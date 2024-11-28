using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameratwo : MonoBehaviour
{
    public GameObject thirdcamera;
    public GameObject fourthcamera;
    public GameObject playe;
    public GameObject playere;
    private Vector3 ofeset = new Vector3(1, 2, -2);
    private Vector3 offiset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("3"))
        {
            Camerasa();
            transform.position = playere.transform.position + offiset;
        }

        if (Input.GetKeyDown("4"))
        {
            Cameraas();
            transform.position = playe.transform.position + ofeset;
        }


    }
    void Camerasa()
    {
        thirdcamera.SetActive(true);
        fourthcamera.SetActive(false);

    }

    void Cameraas()
    {
        thirdcamera.SetActive(false);
        fourthcamera.SetActive(true);
    }
}
