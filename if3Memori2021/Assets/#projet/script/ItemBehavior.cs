using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBehavior : MonoBehaviour
{
    public int id = -1;
    public Levelmanager manager;
    public bool mouseOver = false;
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    
    void Update()
    {
        if (Input.GetMouseButtonUp(0 )&& mouseOver){
            manager.RevelMaterial(id);
        }
    }
    void OnMouseOver(){
        
        mouseOver = true;
        animator.SetBool("MouseOver",true);
    }
    void OnMouseExit(){
        
        mouseOver = false;
        animator.SetBool("MouseOver",false);
    }

    public void HasBeenSelected(bool selected){
        animator.SetBool("itemSelected",selected);
        
    }
    public void HasBeenSelected(){
         animator.SetBool("itemmatch",true);
    }
}
