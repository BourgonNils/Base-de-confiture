using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{

    bool isCatched = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void Update()
    {
       
        if (isCatched)
        {
            Vector3 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            this.transform.position = mousePos;
           
        }
    }

    void OnMouseDown()
    {
        isCatched = true;
    }

 
    void OnMouseUp()
    {
        isCatched = false;
    }

}
