using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraupdate : MonoBehaviour
{
    public GameObject firstcamera;
    public GameObject secondcamera;
    public GameObject play;
    public GameObject player;
    [SerializeField] private Vector3 ofset = new Vector3(1, 2, -2);
    private Vector3 offset = new Vector3(0, 5, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (Input.GetKeyDown("1"))
        {
            Cameras();
            transform.position = player.transform.position + offset;
        }

        if (Input.GetKeyDown("2"))
        {
            Cameraa();
            transform.position = play.transform.position + ofset;
        }


    }
    void Cameras()
    {
        firstcamera.SetActive(true);
        secondcamera.SetActive(false);
 
    }

    void Cameraa()
    {
        firstcamera.SetActive(false);
        secondcamera.SetActive(true);
    }
}
