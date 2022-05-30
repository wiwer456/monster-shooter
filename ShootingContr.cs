using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//стрельба и вывод количества убитых монстров
public class ShootingContr : MonoBehaviour
{
    public Camera cam;
    public ParticleSystem part;
    [SerializeField] TextMeshProUGUI monsters;
    int mns = 0;

    public GameObject win;

    void Start()
    {
        
    }


    void Update()
    {
        Debug.DrawRay(cam.transform.position, cam.transform.forward * 100f, Color.green);
        RaycastHit hit;
        if(Input.GetButtonDown("Fire1")){
            part.Play();
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, 100)){
                
                if(hit.transform.gameObject.tag == "bad"){
                    Destroy(hit.transform.gameObject);
                    mns += 1;
                    monsters.text = mns +"";
                    if(mns == 9){
                        win.SetActive(true);
                    }
                }
            }

        }
    }
}
