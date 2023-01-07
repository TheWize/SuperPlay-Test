using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Popup : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void Open()
    {
        animator.SetBool("Open", true);
    }
    public void Close()
    {
        animator.SetBool("Open", false);
    }
}
