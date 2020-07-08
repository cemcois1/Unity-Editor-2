using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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
    public Collider2D baslangic;
    Physics2DRaycaster dRaycaster;
    RaycastHit2D raycastHit;
    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit raycast;
        Physics.Raycast(ray.origin, ray.direction*200,out raycast);
        Debug.DrawRay(ray.origin, ray.direction*20,Color.red,3,false);
        Debug.Log(raycastHit.collider.name);
    }
    private void OnMouseOver()
    {
        print("deneme");
    }
}
