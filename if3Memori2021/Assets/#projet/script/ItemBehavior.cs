using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public int id = -1;
    public Levelmanager manager;
    public bool mouseOver = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0 )&& mouseOver){
            manager.RevelMaterial(id);
        }
    }
    void OnMouseOver(){
        transform.localScale = new Vector3 (1,2,1);
        mouseOver = true;
    }
    void OnMouseExit(){
        transform.localScale = Vector3.one;
        mouseOver = false;
    }
}
