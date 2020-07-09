using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EditorControlCode : MonoBehaviour
{
    /* 
     * eğer hareket et butonuna basılmışsa
     * mousemun olduğu konuma bak
     *  orada obje varsa onu seç ve update içerisinde o nesneye  mousenin konumunu eşitle
     *  objeye tekrar dokununca bırak
     *
     */
    /*başlangıç konumunu al Raybaslangıc
     * bitiş konumunu al ınput.mouse
     * bu ikisi arasında ray çiz ve raycasthit al
     * raycasthit in adını yazdır
     */

    Renderer sakla;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Physics.Raycast(ray.origin, ray.direction * 200, out hit);
        Debug.DrawRay(ray.origin, ray.direction * 20, Color.red, 3, false);
        if (Input.GetMouseButtonDown(0))
        {
            sakla = hit.collider.gameObject.GetComponent<Renderer>();
            sakla.material.SetColor("_Color", Color.red);
            Debug.Log(hit.collider.name);
            Vector3.Lerp(hit.collider.gameObject.transform.position, Input.mousePosition,1);
        }
        else if (Input.GetMouseButtonUp(0))
        {
            sakla.material.SetColor("_Color", Color.white);
            print("girdi");

        }
    }
}
