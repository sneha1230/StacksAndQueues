using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueCube : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();
        for (int i = 0; i < cubes.Length; i++)
        {
            queue.Enqueue(cubes[i]);
        }
        ShowInfo(queue);
        queue.Dequeue();
        ShowInfo(queue);
        queue.Dequeue();
        ShowInfo(queue);
    }

    void ShowInfo(Queue queue)
    {
        foreach (GameObject item in queue)
        {
            Instantiate(item);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
