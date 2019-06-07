using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_2 : MonoBehaviour
{
    [Range(0, 1000)] public int vitesseRotation = 10;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * vitesseRotation);
    }
}
