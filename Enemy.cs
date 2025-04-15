using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 6f; //скорость движения соперника
    public Transform[] checkpoints; //массив чек-поинтов
    private int checkpointId = 0; //номер чек-поинта
    float step; //шаг, с которым движется персонаж на сцене

    void Start()
    {
        step = speed * Time.deltaTime;
        // checkpoints = GameObject.FindGameObjectsWithTag("checkPoint");
    }

    void Update()
    {
        if(checkpointId < checkpoints.Length)
        {
            Transform currentCheckpoint = checkpoints[checkpointId];

            transform.position = Vector3.MoveTowards(transform.position, currentCheckpoint.position, step);

            if (Vector3.Distance(transform.position, currentCheckpoint.position) < 0.25f)
            {
                checkpointId++;
            }
        }
        else
        {
            checkpointId = checkpoints.Length;
            //нанесение урона
            //эффект
            //перемещение к замку 
            //проигрывание анимации
        }
    }
}
