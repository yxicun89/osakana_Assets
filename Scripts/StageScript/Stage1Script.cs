using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Script : MonoBehaviour
{

    public int stage_num; // �X�R�A�ϐ�
    public GameObject ni;
    public GameObject san;
    public GameObject yon;
    public GameObject go;

    // Use this for initialization
    void Start()
    {
        //���݂�stage_num���Ăяo��
        stage_num = PlayerPrefs.GetInt("SCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
        //stage_num���Q�ȏ�̂Ƃ��A�X�e�[�W�Q���������B�ȉ����l
        if (stage_num >= 2)
        {
            ni.SetActive(true);
        }

        if (stage_num >= 3)
        {
            san.SetActive(true);
        }

        if (stage_num >= 4)
        {
            yon.SetActive(true);
        }

        if (stage_num >= 5)
        {
            go.SetActive(true);
        }

    }
}
