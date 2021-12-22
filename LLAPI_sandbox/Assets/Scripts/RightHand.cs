using System.Collections;
using UnityEngine;

public enum Finger
{
    INDEX, MIDDLE, RING, PINKY, THUMB
}


public class RightHand : MonoBehaviour
{
    public Transform b_r_index3, b_r_index2, b_r_index1;
    public Transform b_r_middle3, b_r_middle2, b_r_middle1;
    public Transform b_r_ring3, b_r_ring2, b_r_ring1;
    public Transform b_r_pinky3, b_r_pinky2, b_r_pinky1, b_r_pinky0;
    public Transform b_r_thumb3, b_r_thumb2, b_r_thumb1, b_r_thumb0;

    public Finger selectedFinger;
    [Range(0f, 90f)]
    public float fingerIndexRot;

    void Start()
    {
        FingerRotation(Finger.INDEX, fingerIndexRot);
        FingerRotation(Finger.MIDDLE, fingerIndexRot);
        FingerRotation(Finger.RING, fingerIndexRot);
        FingerRotation(Finger.PINKY, fingerIndexRot);
        FingerRotation(Finger.THUMB, fingerIndexRot);      
    }
    void Update()
    {
        FingerRotation(selectedFinger, fingerIndexRot);

    }

    private void FingerRotation(Finger finger, float rot)
    {
        switch (finger)
        {
            case Finger.INDEX:
                b_r_index1.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_index2.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_index3.transform.localEulerAngles = new Vector3(0, 0, -rot);
                break;
            case Finger.MIDDLE:
                b_r_middle1.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_middle2.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_middle3.transform.localEulerAngles = new Vector3(0, 0, -rot);
                break;
            case Finger.RING:
                b_r_ring1.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_ring2.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_ring3.transform.localEulerAngles = new Vector3(0, 0, -rot);
                break;
            case Finger.PINKY:
                // TODO: account for b_r_pinky0
                b_r_pinky1.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_pinky2.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_pinky3.transform.localEulerAngles = new Vector3(0, 0, -rot);
                break;
            case Finger.THUMB:
                // TODO: account for b_r_thumb0
                b_r_thumb1.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_thumb2.transform.localEulerAngles = new Vector3(0, 0, -rot);
                b_r_thumb3.transform.localEulerAngles = new Vector3(0, 0, -rot);
                break;
            default:
                break;

        }
        
            
        
        
    }
}
