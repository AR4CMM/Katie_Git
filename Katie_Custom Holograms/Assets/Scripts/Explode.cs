using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explode : MonoBehaviour
{
    public bool expand = false;
    public bool expanded = false;
    public GameObject[] layers;

    void Start()
    {
        layers = GameObject.FindGameObjectsWithTag("Layer");
        //check to see how many layers are included:
        //Debug.Log("# of layers: " + layers.Length);
    }
    

    // Update is called once per frame
    void Update()
    {
        //expand is clicked and mold is currently condensed
        //EXPAND
        //show labels
        if (expand == true && expanded == false) 
        {
            float heightIncrease = 0f;
            for (int i = 0; i < layers.Length; i++)
            {
                GameObject currentLayer = layers[i];
                currentLayer.transform.localPosition += new Vector3(0, heightIncrease, 0);
                heightIncrease += .15f;
            }
            expanded = true;
        }

        //condense is clicked and mold is currently expanded
        //CONDENSE
        //hide labels
        if (expand == false && expanded == true)
        {
            float heightDecrease = 0f;
            for (int j = 0; j < layers.Length; j++)
            {
                GameObject currentLayer = layers[j];
                currentLayer.transform.localPosition += new Vector3(0, heightDecrease, 0);
                heightDecrease -= .15f;
            }
            expanded = false;
        }
    }

    public void expandLayers()
    {
        expand = true;
    }

    public void condenseLayers()
    {
        expand = false;
    }

    public void showCurrentLayer()
    {
        //only show current layer and below
    }
}
