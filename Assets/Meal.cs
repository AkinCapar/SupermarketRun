using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class Meal : ScriptableObject
{
    [SerializeField] public List<GameObject> Ingredients;
    //int akin;

    private void ShoppingList()
    {
        for(int i = 0; i < Ingredients.Count; i++ )
        {
             int  = 1;
        }
    }
}
