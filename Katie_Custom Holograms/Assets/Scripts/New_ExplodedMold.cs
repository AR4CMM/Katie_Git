using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//module name given as a string
//step given as an int

public class New_ExplodedMold : MonoBehaviour
{
    public bool expand = false;
    public bool expanded = false;
    public GameObject[] layers;
    public GameObject[] labels;
    public bool currentlyComplete = false;
    //input from Chris's code about the step#
    public int currentStep = 7;

    void Start()
    {
        layers = GameObject.FindGameObjectsWithTag("Layer");
        labels = GameObject.FindGameObjectsWithTag("Label");

        //hide all labels at the start because the mold is condensed
        for (int i = 0; i < layers.Length; i++)
        {
            labels[i].SetActive(false);
        }

        //hide all layers > currentStep
        for (int j = currentStep; j < layers.Length; j++)
        {
            layers[j].SetActive(false);
        }
    }

    //Update is called once per frame
    void Update()
    {

    }

    public void expandLayers()       //expand is clicked
    {
        //-------------------EXPAND---------------------
        expand = true;
        //if (mold is currently condensed)
        //  EXPAND
        //  show labels
        if (expanded == false)
        {
            float heightIncrease = 0f;
            for (int i = 0; i < layers.Length; i++)
            {
                GameObject currentLayer = layers[i];
                currentLayer.transform.localPosition += new Vector3(0, heightIncrease, 0);
                heightIncrease += .15f;

                //show labels
                labels[i].SetActive(true);
            }
            expanded = true;
        }
    }

    public void condenseLayers()     //condense is clicked
    {
        //------------------CONDENSE--------------------
        expand = false;
        //if (mold is currently expanded)
        //  CONDENSE
        //  hide labels
        if (expanded == true)
        {
            float heightDecrease = 0f;
            for (int i = 0; i < layers.Length; i++)
            {
                GameObject currentLayer = layers[i];
                currentLayer.transform.localPosition += new Vector3(0, heightDecrease, 0);
                heightDecrease -= .15f;

                //hide labels
                labels[i].SetActive(false);
            }
            expanded = false;
        }
    }

    public void showCompleteLayup()     //"show complete layup" is clicked
    {
        //-------------SHOW COMPLETE LAYUP--------------
        //if (layers > currentlyComplete layer are inactive)
        //  activate layers > current layer
        if (currentlyComplete == false)
        {
            for (int i = 0; i < layers.Length; i++)
            {
                layers[i].SetActive(true);
            }
            currentlyComplete = true;
        }
    }

    public void showCurrentLayup()      //"show current layup" is clicked
    {
        //-------------SHOW CURRENT LAYUP--------------
        //if (layers > curentlyComplete layer are active)
        //   deactivate layers > current layer
        if (currentlyComplete == true)
        {
            for (int i = currentStep; i < layers.Length; i++)
            {
                layers[i].SetActive(false);
            }
            currentlyComplete = false;
        }
    }
}
