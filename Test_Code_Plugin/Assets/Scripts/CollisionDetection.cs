using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utils;

[RequireComponent(typeof(SphereCollider))]
public class CollisionDetection : MonoBehaviour
{
    Collider otherCol = null;
    public float distance = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (otherCol != null)
        {
            CalculDistance();
        }
    }

    public float CalculDistance()
    {
        if (otherCol.GetType() == typeof(MeshCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (MeshCollider)otherCol);
        }
        if (otherCol.GetType() == typeof(SphereCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (SphereCollider)otherCol);
        }
        if (otherCol.GetType() == typeof(BoxCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (BoxCollider)otherCol);
        }

        //Distance entre le sphere collider et les meshs que l'on vient toucher. Il faut aussi que l'objet touché ait un collider, et que celui-ci soit identifié (box, mesh, autre...)        

        Debug.Log("distance de " + (distance));
        return distance;
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        Collider other = collisionInfo.collider;
        Debug.unityLogger.Log("OnCollisionEnter : " + other.name);
        otherCol = other;
    }
}
