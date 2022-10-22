using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampTorch : MonoBehaviour
{
    Vector3 mousePos;
    Vector3 selfPos;
    public Camera theCamera;

    void Start()
    {

        selfPos = transform.localPosition;
        selfPos.x += theCamera.pixelWidth/2;
        selfPos.y += theCamera.pixelHeight/2;

        Debug.Log(selfPos);
    }



    void Update()
    {
        mousePos = Input.mousePosition;
        float angle = AngleBetweenTwoPoints(selfPos, mousePos);
        transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));




        float dist = DistanceBetweenTwoPoints(selfPos, mousePos);

        if(dist > 100.0f && dist < 300.0f) {
            Vector3 selfScale = transform.localScale;
            selfScale.x = 0.8f * 1 / (0.035f+(dist*0.005f));
            selfScale.y = 0.8f * (dist*0.012f);
            transform.localScale = selfScale;
        }





    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y  , a.x - b.x ) * Mathf.Rad2Deg + 90;
    }

    float DistanceBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Sqrt(Mathf.Pow(a.x-b.x, 2) + Mathf.Pow(a.y - b.y, 2));
    }
}
