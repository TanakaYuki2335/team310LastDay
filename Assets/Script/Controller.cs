using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // 地面に触れているかフラグ
    public FieldCheck field;

    private Rigidbody2D rb = null;
    private bool isField = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        isField = field.IsField();

        // 地面に触れていなかったら
        if (isField == false)
        {
            if (Input.GetKey("d"))
            {
                transform.position += transform.right * 0.07f;
            }

            if (Input.GetKey("a"))
            {
                transform.position += transform.right * -0.07f;
            }
            if(Input.GetKey("w"))
            {
                transform.position += transform.up* 0.21f;
            }
            if (Input.GetKey("s"))
            {
                transform.position += transform.up * -0.07f;
            }
        }
    }
}
