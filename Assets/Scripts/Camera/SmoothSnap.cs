using System;
using System.Collections.Generic;
using UnityEngine;

public class SmoothSnap : MonoBehaviour
{
    public SnapPoint currentSnapPoint;
    private SnapPoint targetSnapPoint;

    private bool animating;
    private Vector3 motionVector;
    private Quaternion finalRotation;
    private float animationTime;
    private float timeTaken;

    public void Update()
    {
        if (animating) {
            // do animation
            timeTaken += Time.deltaTime;
            if (timeTaken >= animationTime)
            {
                // no longer animating. Set current snap. Reset times and vectors.
                animating = false;
                animationTime = 0f;
                timeTaken = 0f;
                transform.position = targetSnapPoint.transform.position;
                transform.rotation = targetSnapPoint.transform.rotation;
                currentSnapPoint = targetSnapPoint;
                targetSnapPoint = null;
            }
            else
            {
                // add a percentage of motionVector to position. % = deltaTime / animationTime
                transform.position += motionVector * (Time.deltaTime / animationTime);

                // change rotation to an angle between start and last angle. Param 3 is a percentage, 0 - 1
                transform.rotation = Quaternion.Lerp(
                    currentSnapPoint.transform.rotation, 
                    finalRotation, 
                    timeTaken / animationTime
                );
            }
        } 
        else if (Input.GetKey("a") || Input.GetKey("left")) {
            if (currentSnapPoint.leftSnap != null)
            {
                targetSnapPoint = currentSnapPoint.leftSnap;
                SetAnimationData(currentSnapPoint.leftAnimationTime);
            }
        }
        else if (Input.GetKey("s") || Input.GetKey("down"))
        {
            if (currentSnapPoint.backSnap != null)
            {
                targetSnapPoint = currentSnapPoint.backSnap;
                SetAnimationData(currentSnapPoint.backAnimationTime);
            }
        }
        else if (Input.GetKey("d") || Input.GetKey("right"))
        {
            if (currentSnapPoint.rightSnap != null)
            {
                targetSnapPoint = currentSnapPoint.rightSnap;
                SetAnimationData(currentSnapPoint.rightAnimationTime);
            }
        }
        else if (Input.GetKey("w") || Input.GetKey("up"))
        {
            if (currentSnapPoint.forwardSnap != null)
            {
                targetSnapPoint = currentSnapPoint.forwardSnap;
                SetAnimationData(currentSnapPoint.forwardAnimationTime);
            }
        }
    }

    private void SetAnimationData(float time) {
        animationTime = time;
        timeTaken = 0f;
        animating = true;
        Vector3 target = targetSnapPoint.transform.position;
        Vector3 current = currentSnapPoint.transform.position;
        motionVector = new Vector3(
            target.x - current.x, 
            target.y - current.y, 
            target.z - current.z
        );

        Debug.Log("Delta X " + (target.x - current.x));
        Debug.Log("Delta Y " + (target.y - current.y));
        Debug.Log("Delta Z " + (target.z - current.z));

        Vector3 targetRot = targetSnapPoint.transform.rotation.eulerAngles;
        Vector3 currentRot = currentSnapPoint.transform.rotation.eulerAngles;
        finalRotation = Quaternion.Euler(targetRot.x, targetRot.y, targetRot.z);
    }
}
