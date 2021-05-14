using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float translation;
    private float rotation;

    public float tspeed = 13f;
    public float rspeed = 130f;
    void Update()
    {
        translation = Input.GetAxis("Ve") * tspeed;
        rotation = Input.GetAxis("Ho") * rspeed;

        transform.Translate(0, 0,translation * Time.deltaTime);
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }
}
