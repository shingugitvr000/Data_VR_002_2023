using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstArray : MonoBehaviour
{
    //�迭�� �����Ѵ�. 
    public int[] numbers = new int[] { 9, -11, 6, -12, 1 };
    
    void Start()
    {
        numbers[1] = 11;
        numbers[2] = 12;
        Debug.Log(numbers[0]);  // �迭�� 0��° ��Ҹ� Log â�� �����ش�. 
    }

}
