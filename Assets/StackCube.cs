using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackCube : MonoBehaviour
{
    [SerializeField] GameObject[] cubes;
    // Start is called before the first frame update
    void Start()
    {
        Stack stack = new Stack();
        for (int i = 0; i < cubes.Length; i++)
        {
            GameObject temp =cubes[i];
            stack.Push(temp);
        }
        ShowInfo(stack);
        stack.Pop();
        ShowInfo(stack);
        stack.Pop();
        ShowInfo(stack);
    }
    void ShowInfo(Stack stack)
    {
        foreach (GameObject item in stack)
        {
           Instantiate(item);
        }
    }
}
