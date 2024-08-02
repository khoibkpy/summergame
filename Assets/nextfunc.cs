using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class nextfunc : MonoBehaviour
{
    public TMP_Text date;
    public TMP_Text follower;
    public TMP_Text uytin;
    public TMP_Text money;
    public TMP_Text log;
    public static int day = 1;
    public static int follower_count = 1000;
    public static int uytin_count = 50;
    public static int money_count = 0;
    public static bool written = false;
    public static float follow_buff = 1;
    public static int doubled = 1;
    private float half = 1f;
    public static bool new_day = false;
    public static bool troll = false;
    public static bool game_end = false;
    // Start is called before the first frame update
    void Start()
    {
        date.text = "Ngày " + day.ToString();
        follower.text = follower_count.ToString();
        uytin.text = uytin_count.ToString() + "/100";
        money.text = money_count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void next()
    {
        if (written)
        {
            if(uytin_count<=0&&troll==true)
            {
                half = 0.5f;
                uytin_count = 0;
            }
            else {
                half = 1f;
            }
            money_count += follower_count;
            follower_count += (int)(writefunc.follower_gain * doubled * follow_buff * half);
            uytin_count += writefunc.uytin_gain * doubled;
            if(!game_end)
            {
            log.text = "\n\n" + "Kết quả bài đăng ngày " + day.ToString() + ": " + "\n\n" + "Số người theo dõi nhận được: " + ((int)(writefunc.follower_gain * doubled * follow_buff * half)).ToString() + "\n" + "Số uy tín nhận được: " + (writefunc.uytin_gain * doubled).ToString() + "\n" + "Số tiền kiếm được: " + follower_count.ToString();
            }
            doubled = 1;
            shopfunc.bought[2] = false;
            if(uytin_count>100)
            {
                uytin_count = 100;
            }
            if(day>=7)
            {
                if(follower_count>=100000)
                {
                    log.text = "\n\n" + "Chúc mừng bạn đã vượt qua thử thách! Bạn đã trở thành một nhà báo có sức ảnh hưởng trên mạng xã hội!" + "\n\n" + "Số người theo dõi cuối cùng: " + follower_count.ToString() + "\n" + "Số tiền còn lại: " + money_count.ToString();
                }
                else
                {
                    log.text = "\n\n" + "Game over! Bạn đã không đạt đủ chỉ tiêu đề ra." + "\n\n" + "Số người theo dõi cuối cùng: " + follower_count.ToString() + "\n" + "Số tiền còn lại: " + money_count.ToString();
                }
                game_end = true;
            }
            if(uytin_count<=0&&!troll)
            {
                {
                    log.text = "\n\n" + "Game over! Uy tín của bạn đã trở về 0!" + "\n\n" + "Số người theo dõi cuối cùng: " + follower_count.ToString() + "\n" + "Số tiền còn lại: " + money_count.ToString();
                }
                game_end = true;
            }
            day++;
            date.text = "Ngày " + day.ToString();
            follower.text = follower_count.ToString();
            uytin.text = uytin_count.ToString() + "/100";
            money.text = money_count.ToString();
            written = false;
            new_day = true;
        }
    }
}
