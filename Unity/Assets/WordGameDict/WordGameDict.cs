using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGameDict {
	// In C# using a HashSet is an O(1) operation. It's a dictionary without the keys!
	private HashSet<string> words = new HashSet<string>();

	private TextAsset dictText;

	public WordGameDict(){
		InitializeDictionary("ospd");
	}

	public WordGameDict(string filename){
		InitializeDictionary(filename);
	}
	
	protected void InitializeDictionary(string filename){
		dictText = (TextAsset) Resources.Load(filename, typeof (TextAsset));
		var text = dictText.text;

		foreach (string s in text.Split('\n')){
			words.Add(s);
		}
	}
	
	public bool CheckWord(string word, int minLength){
		if (word.Length < minLength){
			return false;
		}

		return (words.Contains(word));
	}
}
