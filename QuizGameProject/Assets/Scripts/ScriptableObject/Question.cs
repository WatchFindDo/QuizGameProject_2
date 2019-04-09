using System;
using System.Collections.Generic;

public enum AnswerType { Multi, Single }

[Serializable()]
public class Answer
{
    public string       Info        = string.Empty;
    public bool         IsCorrect   = false;

    public Answer () { }
}
[Serializable()]
public class Question {

    public String       Info        = null;
    public Answer[]     Answers     = null;
    public Boolean      UseTimer    = false;
    public Int32        Timer       = 0;
    public AnswerType   Type        = AnswerType.Single;
    public Int32        AddScore    = 0;

    public Question () { }

    /// <summary>
    /// Function that is called to collect and return correct answers indexes.
    /// </summary>
    public List<int> GetCorrectAnswers ()
    {
        List<int> CorrectAnswers = new List<int>();
        for (int i = 0; i < Answers.Length; i++)
        {
            if (Answers[i].IsCorrect)
            {
                CorrectAnswers.Add(i);
            }
        }
        return CorrectAnswers;
    }
}