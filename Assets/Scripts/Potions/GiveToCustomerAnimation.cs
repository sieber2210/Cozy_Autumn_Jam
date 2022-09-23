using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveToCustomerAnimation : MonoBehaviour
{
    public Vector3 target;
    public Vector3 origin;

    private bool animating;
    private Vector3 motionVector;
    public float animationTime;
    private float timeTaken;

    public void StartAnimation(Vector3 target) {
        this.origin = transform.position;
        this.target = target;
        timeTaken = 0f;
        animating = true;
        motionVector = new Vector3(
            target.x - origin.x,
            0f,
            target.z - origin.z
        );
    }

    public void Update()
    {
        if (animating)
        {
            // do animation
            timeTaken += Time.deltaTime;
            if (timeTaken >= animationTime)
            {
                // no longer animating. Set current snap. Reset times and vectors.
                animating = false;
                animationTime = 0f;
                timeTaken = 0f;
                transform.position = target;

                Destroy(gameObject);
            }
            else
            {
                // add a percentage of motionVector to position. % = deltaTime / animationTime
                transform.position += motionVector * (Time.deltaTime / animationTime);
            }
        }
    }
}
