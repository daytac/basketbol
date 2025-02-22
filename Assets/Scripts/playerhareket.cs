using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;
using System.Xml;
using Vector2 = UnityEngine.Vector2;


public class playerhareket : MonoBehaviour
{
    public float hiz = 5f;
   
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector2(horizontal, 0) * Time.deltaTime * hiz);
    }
}
