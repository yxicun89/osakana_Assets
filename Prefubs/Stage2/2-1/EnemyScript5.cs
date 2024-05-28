using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript5 : MonoBehaviour
{
    public Rigidbody2D rb;
    public int Movespeed = 1;
    public int attack = 200;
    public float enemyHP = 260;
    public float CorutineTime = 2.0f;
    public bool Moving = true;
    public bool ToEnemyAttacking = false;
    public bool ToCastleAttacking = false;
    private GameObject enemy;
    private GameObject cenemy;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
        //enemy = GameObject.FindWithTag("Player");
        cenemy = GameObject.FindWithTag("PlayerCastle");
    }

    // Update is called once per frame
    void Update()
    {
        enemy = GameObject.FindWithTag("Player");
        cenemy = GameObject.FindWithTag("PlayerCastle");
        if (Moving == true)
        {
            rb.velocity = new Vector2(Movespeed, 0);
            rb.constraints = RigidbodyConstraints2D.None;
            rb.constraints = RigidbodyConstraints2D.FreezeRotation;
            //GetComponent<Animator>().SetBool("Attack", false);
        }
        else if (ToEnemyAttacking)  //== true && enemy != null)
        {
            ToEnemyAttacking = false;
            StartCoroutine(ToEnemyAttack());
        }
        else if (ToCastleAttacking == true)//&& enemy != null)
        {
            ToCastleAttacking = false;
            StartCoroutine(ToCastleAttack());
        }
        if (enemyHP < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && enemy != null)
        {
            Moving = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            ToEnemyAttacking = true;
        }
        if (collision.gameObject.tag == "PlayerCastle") //&& enemy != null)
        {
            Moving = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            ToCastleAttacking = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Moving = true;
            ToEnemyAttacking = false;
        }
    }

    private IEnumerator ToEnemyAttack()
    {
        yield return new WaitForSeconds(1.5f);
        if (enemy != null)
        {
            enemy.GetComponent<PlayerScript5>().playerHP -= attack; //Ç±Ç±Ç≈GetComponentÇµÇƒÇÈÅB
        }
        ToEnemyAttacking = true;
    }

    private IEnumerator ToCastleAttack()
    {
        yield return new WaitForSeconds(CorutineTime);
        cenemy.GetComponent<CastleScript5>().HP -= attack;
        ToCastleAttacking = true;
    }
}
