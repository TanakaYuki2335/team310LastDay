﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // 地面に触れているかフラグ
    public FieldCheck field;

    private Rigidbody2D rb = null;
    private bool isField = false;
    float speed = 20;
   
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
           

            if (Input.GetKey("a"))
            {
                /* 移動 */
                Vector3 pd = Camera.main.ScreenToWorldPoint(Input.mousePosition) - this.transform.position; //カーソル方向のベクトル
                Vector3 pn = pd.normalized; //正規化

                pn = new Vector3(pn.x, pn.y, 0); //Z座標を0にする

                this.transform.position += pn * speed * Time.deltaTime;

                /* 回転 */
                /* float angle = Vector3.Angle(new Vector3(0, 1, 0), pn);
                 if (pn.x > 0) angle = -angle;
                 this.transform.rotation = Quaternion.Euler(this.transform.rotation.x, this.transform.rotation.y, angle);*/
            }
        }
    }
}
