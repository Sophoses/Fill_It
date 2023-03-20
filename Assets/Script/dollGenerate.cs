using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dollGenerate : MonoBehaviour
{
    public GameObject originallD;
    public GameObject[] dolls = new GameObject[2];

    private Vector3 pos;
    public static int ratio = 2;

    void Start()
    {
        pos = originallD.transform.position;
    }

    public void generate()
    {
        //�ҷ�ǰ, ���� ���� ����
        int dice = Random.Range(1, 24);

        if (dice <= ratio)
        {
            Instantiate(dolls[0], new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
        }
        else
        {
            Instantiate(dolls[1], new Vector3(pos.x, pos.y, pos.z), Quaternion.identity);
        }

    }

}
