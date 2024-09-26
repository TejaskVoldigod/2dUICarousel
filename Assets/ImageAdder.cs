using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageAdder : MonoBehaviour
{
    public Transform I;
    public Transform container;
   
    public void Instantiate()
    {
        Instantiate(I,container);
    }

    public void Destroy()
    {
         if (container.childCount > 1)
        {
            int i = container.childCount-1;
            Transform child = container.GetChild(i);
            Destroy(child.gameObject);
        }

    }
    }
