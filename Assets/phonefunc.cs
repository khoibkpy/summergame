using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonefunc : MonoBehaviour
{
    public GameObject write;
    public GameObject shop;
    public GameObject log;
    public GameObject mission;
    public GameObject setting;
    public GameObject next;
    public GameObject background;
    public GameObject phone;
    private bool expand = false;
    public float spd = 1;
    private int num = 0;
    // Start is called before the first frame update
    void Start()
    {
        write.SetActive(false);
        shop.SetActive(false);
        log.SetActive(true);
        mission.SetActive(false);
        setting.SetActive(false);
        next.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(background.transform.localScale.x<=0f)
        {
            background.transform.localScale = new Vector3(0f, 0f, 0f);
        }
        if(expand&&background.transform.localScale.x<1f)
        {
            background.transform.localScale += new Vector3(0.01f * spd, 0.01f * spd, 0.01f * spd);
        }
        if(background.transform.localScale.x>=1f)
        {
            write.SetActive(false);
            shop.SetActive(false);
            log.SetActive(false);
            mission.SetActive(false);
            setting.SetActive(false);
            next.SetActive(false);
            switch(num)
        {
            case 1:
                write.SetActive(true);
                break;
            case 2:
                shop.SetActive(true);
                break;
            case 3:
                log.SetActive(true);
                break;
            case 4:
                mission.SetActive(true);
                break;
            case 5:
                setting.SetActive(true);
                break;
            case 6:
                next.SetActive(true);
                break;
        }
            expand = false;
        }
        if(!expand&&background.transform.localScale.x>0f)
        {
            background.transform.localScale -= new Vector3(0.01f * spd, 0.01f * spd, 0.01f * spd);
        }
        if(nextfunc.game_end)
        {
            write.SetActive(false);
            shop.SetActive(false);
            log.SetActive(true);
            mission.SetActive(false);
            setting.SetActive(false);
            next.SetActive(false);
            phone.SetActive(false);
        }
    }
    public void buttonClick(int num)
    {
        this.num = num;
        expand = true;
    }
}
