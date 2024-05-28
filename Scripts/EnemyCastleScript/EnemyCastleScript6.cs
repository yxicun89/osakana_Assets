using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyCastleScript6 : MonoBehaviour
{
    public int HP = 100;
    public int count = 5;
    public int count1 = 3;
    public int count2 = 2;
    public GameObject enemy;
    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public bool create=false;
    //public bool cooltime = false;
    //public float timer = 5.0f;
    public float t;
    public float t1;
    public float t2;
    public float t3;
    public float t4;
    public Button cat;
    public Text EnemyCastleFullHP;
    public Text EnemyCastleCurrentHP;
    // Start is called before the first frame update
    void Start()
    {
        EnemyCastleFullHP.text = HP.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        EnemyCastleCurrentHP.text = HP.ToString();
        t += Time.deltaTime;
        t1 += Time.deltaTime;
        t2 += Time.deltaTime;
        t3 += Time.deltaTime;
        t4 += Time.deltaTime;
        /*
        if (t > 3)
        {
            var obj = Instantiate(enemy) as GameObject;
            obj.name = enemy.name;
            t = 0;
        }
        */
        Create();
        Create1();
        Create2();
        MoveScene();
        /*
        if (cooltime == true)
        {
            timer -= Time.deltaTime;
            cat.interactable = false;
        }

        if (timer == 0 || timer < 0)
        {
            cooltime= false;
            timer = 0;
            cat.interactable = true;
            timer = 5;
        }
        */
    }

    public void Create()
    {
        if (t > 8 && count >= 0)
        {
            var obj = Instantiate(enemy) as GameObject;
            obj.name = enemy.name;
            t = 0;
            count--;
        }
    }

    public void Create1()
    {
        if (t1 > 10 && count1 >= 0)
        {
            var obj = Instantiate(enemy1) as GameObject;
            obj.name = enemy1.name;
            t1 = 0;
            count1--;
        }
    }

    public void Create2()
    {
        if (t2 > 15 && count2>=0)
        {
            var obj = Instantiate(enemy2) as GameObject;
            obj.name = enemy2.name;
            t2 = 0;
            count2--;
        }
    }

    public void Create3()
    {
        if (t3 > 20)
        {
            var obj = Instantiate(enemy3) as GameObject;
            obj.name = enemy3.name;
            t3 = 0;
        }
    }

    public void Create4()
    {
        if (t4 > 25)
        {
            var obj = Instantiate(enemy4) as GameObject;
            obj.name = enemy4.name;
            t4 = 0;
        }
    }
    public void MoveScene()
    {
        if (HP < 0)
        {
            //Destroy(this.gameObject);
            SceneManager.LoadScene("GameClearScene6");
        }
    }
}
