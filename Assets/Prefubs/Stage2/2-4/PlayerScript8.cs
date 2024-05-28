using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript8 : MonoBehaviour
{
    public Rigidbody2D rb;
    public int Movespeed = 1;
    public int attack = 1;
    public float playerHP = 5;
    public float CoroutineTime = 1.5f;
    public bool Moving = true;
    public bool ToEnemyAttacking = false;
    public bool ToCastleAttacking = false;
    private GameObject enemy;
    private GameObject cenemy;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindWithTag("Enemy");
        cenemy = GameObject.FindWithTag("EnemyCastle");
    }

    // Update is called once per frame
    void Update()
    {  
        enemy = GameObject.FindWithTag("Enemy");
        cenemy = GameObject.FindWithTag("EnemyCastle");
        if (Moving == true)
        {
            rb.velocity = new Vector2(-Movespeed, 0);
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            //GetComponent<Animator>().SetBool("Attack", false);
        } else if(ToEnemyAttacking==true && ToCastleAttacking == true) {
            ToEnemyAttacking = false;
            ToCastleAttacking = false;
            StartCoroutine(ToEnemyAttack());
            StartCoroutine(ToCastleAttack());
        }
        else if (ToEnemyAttacking == true) {
            ToEnemyAttacking = false;
            StartCoroutine(ToEnemyAttack());
        } else if(ToCastleAttacking == true)
        {
            ToCastleAttacking = false;
            StartCoroutine(ToCastleAttack());
        }

        if (playerHP < 0)
        {
            Destroy(this.gameObject);

        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Moving = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            ToEnemyAttacking = true;
        }
        if (collision.gameObject.tag == "EnemyCastle")
        {
            Moving = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            ToCastleAttacking = true;
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Moving = true;
            ToEnemyAttacking = false;
        }
    }

    private IEnumerator ToEnemyAttack()
    {
        yield return new WaitForSeconds(1.5f);
        
        if(enemy == null)
        {
            enemy.GetComponent<EnemyScript8>().enemyHP -= attack;
        }
        //cenemy.GetComponent<CastleScript>().HP--;
        ToEnemyAttacking = true;
    }

    private IEnumerator ToCastleAttack()
    {
        yield return new WaitForSeconds(CoroutineTime);
        cenemy.GetComponent<EnemyCastleScript8>().HP-=attack;
        ToCastleAttacking = true;
    }
}
