using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

//default view will be condensed and showing the current layer

public class Exploded_old : MonoBehaviour
{
    bool expand = false;
    //bool showComplete = false;
    //public static Vector3 GetLocalPosition(XR.XRNode mold);
    //public positionY spaceBetween = X;

    // Update is called once per frame
    void Update()
    {
        if (expand == true)
        {
            //increase space between layers
            //float initialVertical = Input.GetAxis("Vertical");
            //Vector3 initialPosition;
            //update the position
            //transform.localPosition = Vector3(0, 1, 0) + initialVertical;
            //output to log the position change
            //Debug.Log(transform.position.y);

            //show labels
        }
        else
        {
            //decrease area between layers
            //hide labels

        }
    }

    public void Expand()
    {
        expand = true;
    }

//    public void showComplete() => showComplete = true;
}
