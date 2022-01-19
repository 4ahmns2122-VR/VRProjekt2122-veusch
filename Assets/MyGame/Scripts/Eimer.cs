using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eimer : MonoBehaviour
{
    public GameObject mLiquid;
    public GameObject mLiquidMesh;

    private int mSLoshSpeed = 60;
    private int mRotateSpeed = 15;

    private int difference = 25;

    

  
    void Update()
    {
        Slosh();

        mLiquidMesh.transform.Rotate(Vector3.up * mRotateSpeed * Time.deltaTime, Space.Self);
    }


    private void Slosh()
    {
        Quaternion inverseRotation = Quaternion.Inverse(transform.localRotation);

        Vector3 finalRotation = Quaternion.RotateTowards(mLiquid.transform.localRotation, inverseRotation, mSLoshSpeed * Time.deltaTime).eulerAngles;

        finalRotation.x = ClampRotationValue(finalRotation.x, difference);
        finalRotation.z = ClampRotationValue(finalRotation.z, difference);

        mLiquid.transform.localEulerAngles = finalRotation;

    }

    private float ClampRotationValue(float value, float difference)
    {
        float returnValue=0.0f;
        if (value > 180)
        {
            returnValue = Mathf.Clamp(value, 360 - difference, 360);
        }
        else
        {
            returnValue = Mathf.Clamp(value, 0, difference);
        }

        return returnValue;

    }
}
