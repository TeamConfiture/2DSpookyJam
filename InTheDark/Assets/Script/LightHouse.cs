using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightHouse : MonoBehaviour
{

    private GameObject theCharacter;
    public Light theLightBulb;
    private bool LightHouseOn = false;
    // Start is called before the first frame update
    void Start()
    {
        theCharacter = GameObject.FindGameObjectsWithTag("Character")[0];
        theLightBulb.intensity = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (!(LightHouseOn) && DistanceBetweenTwoPoints(theCharacter.transform.localPosition, transform.localPosition)<3)
        {
            if (Input.GetKey("e"))
            {
                Debug.Log(transform.localPosition);
                ActivateLightHouse();
            }
        }
    }


    float DistanceBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Sqrt(Mathf.Pow(a.x - b.x, 2) + Mathf.Pow(a.y - b.y, 2));
    }

    void ActivateLightHouse()
    {
        theLightBulb.intensity = 3;
        LightHouseOn = true;
    }
}
