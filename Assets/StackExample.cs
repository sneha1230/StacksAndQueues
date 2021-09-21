using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StackExample : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI stackDebug;
    // Start is called before the first frame update
    void Start()
    {
        //define our stack;
        Stack stack = new Stack();

        //our data
        int firstPlayer = 14;
        int secondPlayer = 10;
        int thirdPlayer = 30;
        stack.Push(firstPlayer);
        stack.Push(secondPlayer);
        stack.Push(thirdPlayer);

        //Showing information
        ShowInfo(stack);

        //Removing top most score
        stack.Pop();
        ShowInfo(stack);
        stack.Pop();
        ShowInfo(stack);
        stack.Pop();
        ShowInfo(stack);

    }

    void ShowInfo(Stack stack)
    {
        stackDebug.text += "..............\n";

        foreach (var item in stack)
        {
            //Debug.Log("QWAESBD");
            stackDebug.text += $"{item}\n";
            //stackDebug.text = item.ToString();
        }
    }
}
