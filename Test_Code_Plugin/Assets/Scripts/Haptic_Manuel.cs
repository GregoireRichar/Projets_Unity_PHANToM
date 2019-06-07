using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using utils;

[RequireComponent(typeof(SphereCollider))]
public class Haptic_Manuel : MonoBehaviour
{
    //public Collider collisionCol;
    //public string nameCol;
    public float distance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (HapticGrabber.manuelCol != null)
        {
            HapticSurfaceManuelle();
        }
    }

    //Méthode pour calculer la distance/profondeur de pénétration
    public float HapticSurfaceManuelle()
    {
        if (HapticGrabber.manuelCol.GetType() == typeof(MeshCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (MeshCollider)HapticGrabber.manuelCol);
        }
        if (HapticGrabber.manuelCol.GetType() == typeof(SphereCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (SphereCollider)HapticGrabber.manuelCol);
        }
        if (HapticGrabber.manuelCol.GetType() == typeof(BoxCollider))
        {
            distance = utils.DistanceUtil.Dist(gameObject.GetComponent<SphereCollider>(), (BoxCollider)HapticGrabber.manuelCol);
        }

        //Distance entre le sphere collider et les meshs que l'on vient toucher. Il faut aussi que l'objet touché ait un collider, et que celui-ci soit identifié (box, mesh, autre...)        

        //Debug.Log("distance de " + (distance));
        return distance;
    }

    private void HapticForceManuelle(float distance)
    {
        //On a la distance mais on a besoin de la direction aussi
        //A-t-on besoin de données pour le couple dans le setForce()?

    }
    
    
}
