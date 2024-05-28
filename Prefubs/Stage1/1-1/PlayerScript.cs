using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
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
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemy = GameObject.FindWithTag("Enemy");
        cenemy = GameObject.FindWithTag("EnemyCastle");
        animator = this.gameObject.GetComponent<Animator>();
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
            animator.SetBool("attack", true);
        }
        if (collision.gameObject.tag == "EnemyCastle")
        {
            Moving = false;
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            ToCastleAttacking = true;
            animator.SetBool("attack", true);
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Moving = true;
            ToEnemyAttacking = false;
            animator.SetBool("attack", false);
        }
    }

    private IEnumerator ToEnemyAttack()
    {
        yield return new WaitForSeconds(1.5f);
        if (enemy != null)
        {
            enemy.GetComponent<EnemyScript>().enemyHP -= attack;
        }
        //animator.SetBool("attack", true);
        ToEnemyAttacking = true;
        
        
    }

    private IEnumerator ToCastleAttack()
    {
        yield return new WaitForSeconds(CoroutineTime);
        cenemy.GetComponent<EnemyCastleScript>().HP-=attack;
        //animator.SetBool("attack", true);
        ToCastleAttacking = true;
    }
}
