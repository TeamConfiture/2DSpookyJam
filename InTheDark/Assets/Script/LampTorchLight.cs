using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampTorchLight : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 mousePos;
    Vector3 selfPos;
    Light thisLight;
    public Camera theCamera;

    void Start()
    {

        selfPos = transform.localPosition;
        selfPos.x += theCamera.pixelWidth / 2;
        selfPos.y += theCamera.pixelHeight / 2;

        thisLight = GetComponent<Light>();

        Debug.Log(selfPos);
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = Input.mousePosition;
        float angle = AngleBetweenTwoPoints(selfPos, mousePos);
        transform.rotation = Quaternion.Euler(new Vector3(angle,90f, 0f));
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(selfPos + mousePos); 
            Debug.Log(angle);
        }

        float dist = DistanceBetweenTwoPoints(selfPos, mousePos);

        if (dist > 100.0f && dist < 300.0f)
        {
            thisLight.range = 5 + dist / 40;
            thisLight.intensity = 10- dist / 50;
            thisLight.spotAngle = 95 - dist / 5;
        }


    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return -1 * Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg -180 ;
    }

    float DistanceBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2));
    }
}
