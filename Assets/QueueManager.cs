using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class QueueManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI queueDebug;

    // Start is called before the first frame update
    void Start()
    {
        Queue queue = new Queue();

        int firstPlayer = 14;
        int secondPlayer = 10;
        int thirdPlayer = 30;

        queue.Enqueue(firstPlayer);
        queue.Enqueue(secondPlayer);
        queue.Enqueue(thirdPlayer);

        ShowInfo(queue);
        queue.Dequeue();
        ShowInfo(queue);
        queue.Dequeue();
        ShowInfo(queue);
    }
    void ShowInfo(Queue stack)
    {
        queueDebug.text += "..............\n";
        foreach (var item in stack)
        {
            //Debug.Log("QWAESBD");
            queueDebug.text += $"{item}\n";
            //stackDebug.text = item.ToString();
        }
    }
}
