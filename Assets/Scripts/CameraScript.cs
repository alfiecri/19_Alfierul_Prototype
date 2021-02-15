using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;

    Vector3 posOffset = new Vector3(0, 15f, -34);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, player.transform.position + posOffset, 0.2f);
        transform.rotation = Quaternion.Euler(25, 0, 0);
    }
}
