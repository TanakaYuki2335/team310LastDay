using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldCheck : MonoBehaviour
{
    private string fieldTag = "Field";
    private bool isField = false;
    private bool isFieldEnter, isFieldStay, isFieldExit;

    
    public bool IsField()
    {
        if (isFieldEnter || isFieldStay)
        {
            isField = true;
        }
        else if(isFieldExit)
        {
            isField = false;
        }

        isFieldEnter = false;
        isFieldStay = false;
        isFieldExit = false;
        return isField;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == fieldTag)
        {
            isFieldEnter = true;
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == fieldTag)
        {
            isFieldStay = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == fieldTag)
        {
            isFieldExit = true;
        }
    }
}
