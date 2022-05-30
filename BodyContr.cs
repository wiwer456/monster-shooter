using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

//движение через character controller, время, hp.
public class BodyContr : MonoBehaviour
{

    Transform Pler;
    CharacterController cntrl;
    public float speed = 12f;

    int time = 30;
    [SerializeField] TextMeshProUGUI timeLeft; 
    int hpPoints = 100;
    [SerializeField] TextMeshProUGUI HP; 

    public GameObject loose;

    void Start()
    {
        Pler = GetComponent<Transform>();
        cntrl = GetComponent<CharacterController>();   
        InvokeRepeating("Timer", 1f, 1f);
    }
   
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");

        cntrl.Move(Pler.forward * vertical * speed * Time.deltaTime);
        cntrl.Move(Pler.right * horizontal * speed * Time.deltaTime);
        
    }

    void Timer(){
        time -= 1;
        timeLeft.text =  time + "";
        if(time <= 0 ){
            CancelInvoke();
            loose.SetActive(true);
        }
    }

    void OnControllerColliderHit(ControllerColliderHit col){
        if(col.gameObject.tag == "bad"){
            hpPoints -= 5;
            HP.text = hpPoints + "";
            if(hpPoints <= 0){
                loose.SetActive(true);
                hpPoints = 0;
                HP.text = hpPoints + "";
            }
        }
    }
   
}
