using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{

    public int noOfCircles = 10;
    public float initialRadius = 1f;
    void Start()
    {
        
        for (int circle = 0 ; circle < noOfCircles ; circle++){

            
            float circumference = 2*(initialRadius*(circle+1))*22/7;
            int noOfSpheres = (int)circumference*1;

            print(noOfSpheres);
            float angle = 360f/noOfSpheres;


            // Colours
            Color circleColor = Color.HSVToRGB((float)(circle+1)/noOfCircles, 1, 1);
            for(int i = 0; i < noOfSpheres;i++){

                print(i*angle);
                GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                
                sphere.transform.Rotate(0,angle*i,0);
                sphere.transform.Translate(initialRadius*(circle+1),0,0);
               
                sphere.GetComponent<Renderer>().material.color = circleColor;
               
                // sphere.transform.position = transform.TransformPoint(new Vector3((initialRadius)*1,0,0));
            }
             /*
                    Mathf.Sin(angle)
                Mathf.Cos(angle)
                GameObject.Instantiate()
                transform.Rotate()

                */
        }
        
    }


    // Update is called once per frame
    void Update()
    {

    }
}
