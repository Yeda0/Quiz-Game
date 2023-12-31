using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


[CreateAssetMenu(menuName = "Quiz Question", fileName = "New Question")]
public class QuestionSO : ScriptableObject
{
   [TextArea(2,6)]
   [SerializeField] private string question = "Enter new question here";

   [SerializeField] private string[] answers = new string[4];

   [SerializeField] private int correctAnswerIndex;

   public string GetQuestion()
   {
      return question;
   }

   public string GetAnswer(int index)
   {
      return answers[index];
   }
   public int GetCorrectAnswerIndex()
   {
      return correctAnswerIndex;
   }

 
}
