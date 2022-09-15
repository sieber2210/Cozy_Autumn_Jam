using System;
using UnityEngine;

[Serializable]
public class SnapPoint : MonoBehaviour
{
    public SnapPoint leftSnap;
    public SnapPoint rightSnap;
    public SnapPoint forwardSnap;
    public SnapPoint backSnap;

    public float leftAnimationTime;
    public float rightAnimationTime;
    public float forwardAnimationTime;
    public float backAnimationTime;
}
