using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EnlargeHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

  

    float timer = 0.0f;
    Vector4 OriginalScale; // original scale of button

    // Start is called before the first frame update
    void Start()
    {

        OriginalScale = transform.localScale;    //storing button scale
     
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {

        Debug.Log(transform.localScale);
        transform.localScale = Vector4.Lerp(OriginalScale, (OriginalScale * 1.25f), timer);
       
        

    }
    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit");
        transform.localScale = Vector4.Lerp((OriginalScale * 1.25f), OriginalScale, timer);//back to normal scale
    }
  
    // Update is called once per frame
    void Update()
    {
        timer = Time.captureDeltaTime;

    }
}
