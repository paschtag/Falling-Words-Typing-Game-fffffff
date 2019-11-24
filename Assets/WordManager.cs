using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WordManager : MonoBehaviour {

	public List<Word> words;
    public static int score;
    public int count = 0;
	public WordSpawner wordSpawner;
    public AudioSource mySound;
    public TextAlignment Score;
    public Text Score1;
    private bool hasActiveWord;
	private Word activeWord;
    public Text NumWords;
    public static int WordCount;
    public void AddWord ()
	{
		Word word = new Word(WordGenerator.GetRandomWord(), wordSpawner.SpawnWord());
		Debug.Log(word.word);
        WordCount++;
        NumWords.text = "Number of Words:  " + WordCount.ToString();
		words.Add(word);
	}

	public void TypeLetter (char letter)
	{
		if (hasActiveWord)
		{
			if (activeWord.GetNextLetter() == letter)
			{
				activeWord.TypeLetter();
			}
		} else
		{
			foreach(Word word in words)
			{
				if (word.GetNextLetter() == letter)
				{
					activeWord = word;
					hasActiveWord = true;
					word.TypeLetter();
					break;
				}
			}
		}

		if (hasActiveWord && activeWord.WordTyped())
		{

            count += 1;
            score = count;
            Score1.text = "score: " + count.ToString();
            hasActiveWord = false;
            words.Remove(activeWord);
        }
	}

}
