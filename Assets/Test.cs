using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int mp = 53;

    public void Magic()
    {
        if(this.mp >= 5)
        {
            this.mp = mp - 5;
            Debug.Log("���@�U���������B�c��MP��" + this.mp);
        }
        else
        {
            Debug.Log("MP������Ȃ����߁A���@���g���Ȃ�");
        }
    }
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ��������Ă�������//
        int[] array = {1,2,3,4,5};

        //for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\�����Ă�������//
        for (int i = 0; i <= array.Length - 1; i++)
        {
            Debug.Log(array[i]);
        }

        //for�����g���A�z��̊e�v�f�̒l���t���ɕ\�����Ă�������//
        for (int i = array.Length - 1; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //���W�ۑ�FBoss�N���X�ɁA�ϐ�mp��Magic�֐����쐬����Start�֐�����Ăяo����//
        Boss lastboss = new Boss();
        for (int i = 0; i <= 10; i++)
        {
            int kaisuu = i + 1;
            Debug.Log(kaisuu + "���");
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
