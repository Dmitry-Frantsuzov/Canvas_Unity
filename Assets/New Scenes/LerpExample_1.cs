using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class LerpExample_1 : MonoBehaviour
{
    [SerializeField] private Transform _start; //��������� �������(����� �������)
    [SerializeField] private Transform _end; // �������� ����� (����� �������)
    [SerializeField, Range(0, 1)] private float _time;
    private float time = 10f;

    private void Update()
    {

        // �����, �����, ��������� ����������
        transform.position = Vector3.Lerp(_start.position, _end.position, _time);
        transform.Rotate(new Vector3(5, 8, 2));

        // _time += Time.deltaTime - 1 ������� �������
        _time += Time.deltaTime / time;

    }






}

