using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class writefunc : MonoBehaviour
{
    public News new1;
    public News new2;
    public News new3;
    public News new4;
    public News new5;
    public News new6;
    public News new7;
    public News new8;
    public News new9;
    public News new10;
    public News new11;
    public News new12;
    public News new13;
    public News new14;
    public News new15;
    public News new16;
    public News new17;
    public News new18;
    public News new19;
    public News new20;
    public News new21;
    public News new22;
    public News new23;
    public News new24;
    public bool[] used = new bool[25];
    public TMP_Text opt1;
    public TMP_Text opt2;
    public TMP_Text opt3;
    private News new_option1;
    private News new_option2;
    private News new_option3;
    private News roll_result;
    public static int uytin_gain = 0;
    public static int follower_gain = 0;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public TMP_Text title;
    // Start is called before the first frame update
    void Start()
    {
        roll();
    }

    // Update is called once per frame
    void Update()
    {
        if(nextfunc.new_day)
        {
            roll();
            nextfunc.new_day = false;
        }
    }
    public void choice(int ch)
    {
        title.text = "Đã chọn xong tin tức cho hôm nay!";
        switch(ch)
        {
            case 1:
                box2.SetActive(false);
                box3.SetActive(false);
                uytin_gain = new_option1.uytin;
                follower_gain = new_option1.follow;
                break;
            case 2:
                box1.SetActive(false);
                box3.SetActive(false);
                uytin_gain = new_option2.uytin;
                follower_gain = new_option2.follow;
                break;
            case 3:
                box1.SetActive(false);
                box2.SetActive(false);
                uytin_gain = new_option3.uytin;
                follower_gain = new_option3.follow;
                break;
        }
        nextfunc.written = true;
    }
    
    public void roll()
    {
        title.text = "Chọn tin tức để đăng tải hôm nay...";
        box1.SetActive(true);
        box2.SetActive(true);
        box3.SetActive(true);
        int rollResult = Random.Range(1, 25);
        Debug.Log(rollResult);
        while (used[rollResult])
        {
            rollResult = Random.Range(1, 25);
        }
        new_option1 = GetNews(rollResult);
        used[rollResult] = true;
        rollResult = Random.Range(1, 25);
        while (used[rollResult])
        {
            rollResult = Random.Range(1, 25);
        }
        new_option2 = GetNews(rollResult);
        used[rollResult] = true;
        rollResult = Random.Range(1, 25);
        while (used[rollResult])
        {
            rollResult = Random.Range(1, 25);
        }
        new_option3 = GetNews(rollResult);
        used[rollResult] = true;
        opt1.text = new_option1.line;
        opt2.text = new_option2.line;
        opt3.text = new_option3.line;
    }
    private News GetNews(int rollResult)
    {
        switch (rollResult)
        {
            case 1:
                return new1;
            case 2:
                return new2;
            case 3:
                return new3;
            case 4:
                return new4;
            case 5:
                return new5;
            case 6:
                return new6;
            case 7:
                return new7;
            case 8:
                return new8;
            case 9:
                return new9;
            case 10:
                return new10;
            case 11:
                return new11;
            case 12:
                return new12;
            case 13:
                return new13;
            case 14:
                return new14;
            case 15:
                return new15;
            case 16:
                return new16;
            case 17:
                return new17;
            case 18:
                return new18;
            case 19:
                return new19;
            case 20:
                return new20;
            case 21:
                return new21;
            case 22:
                return new22;
            case 23:
                return new23;
            case 24:
                return new24;
            default:
                return null;
        }
    }
}