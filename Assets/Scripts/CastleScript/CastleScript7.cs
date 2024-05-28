using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CastleScript7 : MonoBehaviour
{
    public int HP = 100;
    public int AllCost = 500;
    public int cost = 250;
    public int cost1=100;
    public int cost2=150;
    public int cost3=200;
    public int cost4=250;
    public int cost5=300;
    public int cost6=350;
    public int cost7=400;
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    public GameObject player4;
    public GameObject player5;
    public GameObject player6;
    public GameObject player7;
    public bool PlayerCreate=false;
    public bool PlayerCreate1 = false;
    public bool PlayerCreate2 = false;
    public bool PlayerCreate3 = false;
    public bool PlayerCreate4 = false;
    public bool PlayerCreate5 = false;
    public bool PlayerCreate6 = false;
    public bool PlayerCreate7 = false;
    public bool cooltime = false;
    public bool cooltime1 = false;
    public bool cooltime2 = false;
    public bool cooltime3 = false;
    public bool cooltime4 = false;
    public bool cooltime5 = false;
    public bool cooltime6 = false;
    public bool cooltime7 = false;
    public float timer = 5.0f;
    public float timer1 = 5.0f;
    public float timer2 = 5.0f;
    public float timer3 = 5.0f;
    public float timer4 = 5.0f;
    public float timer5 = 5.0f;
    public float timer6 = 5.0f;
    public float timer7 = 5.0f;
    public Button button;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Text PlayerCastleFullHP;
    public Text PlayerCastleCurrentHP;
    public Text AllCostText;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCastleFullHP.text = HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerCastleCurrentHP.text = HP.ToString();
        AllCostText.text = AllCost.ToString();
        if (AllCost !=0 && AllCost >= 0)
        {
            Create();
            Create1();
            Create2();
            Create3();
            Create4();
            Create5();
            Create6();
            Create7();
        }
        MoveScene();
        /*
        if (cooltime == true)
        {
            timer -= Time.deltaTime;
            button.interactable = false;
        }
        */
        CoolTime();
        CoolTime1();
        CoolTime2();
        CoolTime3();
        CoolTime4();
        CoolTime5();
        CoolTime6();
        CoolTime7();
        /*
        if (timer <= 0)
        {
            cooltime= false;
            timer = 0;
            button.interactable = true;
            timer = 5;
        }
        */
        Timer();
        Timer1();
        Timer2();
        Timer3();
        Timer4();
        Timer5();
        Timer6();
        Timer7();
    }

    public void Create()
    {
        if (Input.GetKeyDown("space") || PlayerCreate == true)
        {
            var obj=Instantiate(player) as GameObject;
            obj.name = player.name;
            AllCost -= cost;
            PlayerCreate = false;
        }

    }

    public void Create1()
    {
        if (Input.GetKeyDown("space") || PlayerCreate1 == true)
        {
            var obj = Instantiate(player1) as GameObject;
            obj.name = player.name;
            AllCost -= cost1;
            PlayerCreate1 = false;
        }

    }

    public void Create2()
    {
        if (Input.GetKeyDown("space") || PlayerCreate2 == true)
        {
            var obj = Instantiate(player2) as GameObject;
            obj.name = player.name;
            AllCost -= cost2;
            PlayerCreate2 = false;
        }

    }

    public void Create3()
    {
        if (Input.GetKeyDown("space") || PlayerCreate3 == true)
        {
            var obj = Instantiate(player3) as GameObject;
            obj.name = player.name;
            AllCost -= cost3;
            PlayerCreate3 = false;
        }

    }
    public void Create4()
    {
        if (Input.GetKeyDown("space") || PlayerCreate4 == true)
        {
            var obj = Instantiate(player4) as GameObject;
            obj.name = player.name;
            AllCost -= cost4;
            PlayerCreate4 = false;
        }
    }
    public void Create5()
    {
        if (Input.GetKeyDown("space") || PlayerCreate5 == true)
        {
            var obj = Instantiate(player5) as GameObject;
            obj.name = player5.name;
            AllCost -= cost5;
            PlayerCreate5 = false;
        }

    }
    public void Create6()
    {
        if (Input.GetKeyDown("space") || PlayerCreate6 == true)
        {
            var obj = Instantiate(player6) as GameObject;
            obj.name = player6.name;
            AllCost -= cost6;
            PlayerCreate6 = false;
        }

    }
    public void Create7()
    {
        if (Input.GetKeyDown("space") || PlayerCreate7 == true)
        {
            var obj = Instantiate(player7) as GameObject;
            obj.name = player7.name;
            AllCost -= cost7;
            PlayerCreate7 = false;
        }

    }

    public void PlayerCreateButtonDown()
    {
        PlayerCreate = true;
        cooltime = true;
    }

    public void Player1CreateButtonDown()
    {
        PlayerCreate1 = true;
        cooltime1 = true;
    }

    public void Player2CreateButtonDown()
    {
        PlayerCreate2 = true;
        cooltime2 = true;
    }

    public void Player3CreateButtonDown()
    {
        PlayerCreate3 = true;
        cooltime3 = true;
    }

    public void Player4CreateButtonDown()
    {
        PlayerCreate4 = true;
        cooltime4 = true;
    }
    public void Player5CreateButtonDown()
    {
        PlayerCreate5 = true;
        cooltime5 = true;
    }
    public void Player6CreateButtonDown()
    {
        PlayerCreate6 = true;
        cooltime6 = true;
    }
    public void Player7CreateButtonDown()
    {
        PlayerCreate7 = true;
        cooltime7 = true;
    }
    public void CoolTime()
    {
        if (cooltime == true)
        {
            timer -= Time.deltaTime;
            button.interactable = false;
        }
    }

    public void CoolTime1()
    {
        if (cooltime1 == true)
        {
            timer1 -= Time.deltaTime;
            button1.interactable = false;
        }
    }

    public void CoolTime2()
    {
        if (cooltime2 == true)
        {
            timer2 -= Time.deltaTime;
            button2.interactable = false;
        }
    }

    public void CoolTime3()
    {
        if (cooltime3 == true)
        {
            timer3 -= Time.deltaTime;
            button3.interactable = false;
        }
    }

    public void CoolTime4()
    {
        if (cooltime4 == true)
        {
            timer4 -= Time.deltaTime;
            button4.interactable = false;
        }
    }
    public void CoolTime5()
    {
        if (cooltime5 == true)
        {
            timer5 -= Time.deltaTime;
            button5.interactable = false;
        }
    }
    public void CoolTime6()
    {
        if (cooltime6 == true)
        {
            timer -= Time.deltaTime;
            button6.interactable = false;
        }
    }
    public void CoolTime7()
    {
        if (cooltime7 == true)
        {
            timer -= Time.deltaTime;
            button7.interactable = false;
        }
    }

    public void Timer()
    {
        if (timer <= 0)
        {
            cooltime = false;
            timer = 0;
            button.interactable = true;
            timer = 5;
        }
    }
    public void Timer1()
    {
        if (timer1 <= 0)
        {
            cooltime1 = false;
            timer1 = 0;
            button1.interactable = true;
            timer1 = 5;
        }
    }

    public void Timer2()
    {
        if (timer2 <= 0)
        {
            cooltime2 = false;
            timer2 = 0;
            button2.interactable = true;
            timer2 = 5;
        }
    }

    public void Timer3()
    {
        if (timer3 <= 0)
        {
            cooltime3 = false;
            timer3 = 0;
            button3.interactable = true;
            timer3 = 5;
        }
    }

    public void Timer4()
    {
        if (timer4 <= 0)
        {
            cooltime4 = false;
            timer4 = 0;
            button4.interactable = true;
            timer4 = 5;
        }
    }
    public void Timer5()
    {
        if (timer5 <= 0)
        {
            cooltime5 = false;
            timer5 = 0;
            button5.interactable = true;
            timer5 = 5;
        }
    }
    public void Timer6()
    {
        if (timer6 <= 0)
        {
            cooltime6 = false;
            timer6 = 0;
            button6.interactable = true;
            timer6 = 5;
        }
    }
    public void Timer7()
    {
        if (timer7 <= 0)
        {
            cooltime7 = false;
            timer7 = 0;
            button7.interactable = true;
            timer7 = 5;
        }
    }
    public void MoveScene()
    {
        if (HP < 0)
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("RetryScene7");
        }
    }
}
