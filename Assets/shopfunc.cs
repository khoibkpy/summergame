using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class shopfunc : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    private TMP_Text desc;
    [SerializeField]
    private TMP_Text buytext;
    private int selecting = 0;
    public static bool[] bought = new bool[7];
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void buttonClick(int num)
    {
        selecting = num;
        switch(num)
        {
        case 1:
            desc.text = "Tăng số người theo dõi nhận được thêm 10%. Giá 50000.";
            break;
        case 2:
            desc.text = "Nhân đổi sự thay đổi đối với số người theo dõi và uy tín trong ngày hôm nay. Giá 80000.";
            break;
        case 3:
            desc.text = "Trò chơi sẽ không kết thúc khi uy tín về 0, tuy nhiên số người theo dõi nhận được sẽ giảm. Giá 100000.";
            break;
        case 4:
            desc.text = "Tăng số người theo dõi thêm 10000 ngay lập tức. Giá 120000.";
            break;
        case 5:
            desc.text = "Tăng uy tín thêm 20 ngay lập tức. Giá 150000.";
            break;
        case 6:
            desc.text = "Không biết làm sao mua được cái này luôn. Giá 400000.";
            break;
        }
        if(bought[num])
        {
            buytext.text = "Đã mua";
        }
        else
        {
            buytext.text = "Mua";
        }
    }
    public void buy()
    {
        switch(selecting)
        {
        case 1:
            if(nextfunc.money_count >= 50000 && !bought[1])
            {
                nextfunc.money_count -= 50000;
                bought[1] = true;
                buytext.text = "Đã mua";
                nextfunc.follow_buff += 0.1f;
            }
            desc.text = "Tăng số người theo dõi nhận được thêm 10%. Giá 50000.";
            break;
        case 2:
            if(nextfunc.money_count >= 80000 && !bought[2])
            {
                nextfunc.money_count -= 80000;
                bought[2] = true;
                buytext.text = "Đã mua";
                nextfunc.doubled = 2;
            }
            desc.text = "Nhân đổi sự thay đổi đối với số người theo dõi và uy tín trong ngày hôm nay. Giá 80000.";
            break;
        case 3:
            if(nextfunc.money_count >= 100000 && !bought[3])
            {
                nextfunc.money_count -= 100000;
                bought[3] = true;
                buytext.text = "Đã mua";
                nextfunc.troll = true;
            }
            desc.text = "Trò chơi sẽ không kết thúc khi uy tín về 0, tuy nhiên số người theo dõi nhận được sẽ giảm. Giá 100000.";
            break;
        case 4:
            if(nextfunc.money_count >= 120000 && !bought[4])
            {
                nextfunc.money_count -= 120000;
                bought[4] = true;
                buytext.text = "Đã mua";
                nextfunc.follower_count += 10000;
            }
            desc.text = "Tăng số người theo dõi thêm 10000 ngay lập tức. Giá 120000.";
            break;
        case 5:
            if(nextfunc.money_count >= 150000 && !bought[5])
            {
                nextfunc.money_count -= 150000;
                bought[5] = true;
                buytext.text = "Đã mua";
                nextfunc.uytin_count += 20;
                if(nextfunc.uytin_count > 100)
                {
                    nextfunc.uytin_count = 100;
                }
            }
            desc.text = "Tăng uy tín thêm 20 ngay lập tức. Giá 150000.";
            break;
        case 6:
            if(nextfunc.money_count >= 400000 && !bought[6])
            {
                nextfunc.money_count -= 400000;
                bought[6] = true;
                buytext.text = "Đã mua";
                nextfunc.follower_count = 123456;
            }
            desc.text = "Không biết làm sao mua được cái này luôn. Giá 400000.";
            break;
        }
    }
}
