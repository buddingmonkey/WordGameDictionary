using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class WordGameDict {
	private List<string> words = new List<string>();

	public WordGameDict(){
		InitializeDictionary("ospd.txt");
	}

	public WordGameDict(string filename){
		InitializeDictionary(filename);
	}

	//FIXME fix the file path for the stream reader
	protected void InitializeDictionary(string filename){
		try{
			StreamReader sr = new StreamReader(filename);
			string dict = sr.ReadToEnd();
			words.AddRange(dict.Split('\n'));
			sr.Close();
		} catch (FileNotFoundException e){
			Debug.LogException(e);
		}
	}

	//FIXME fix the find method
	public bool CheckWord(string word, int minLength){
		if (word.Length < minLength){
			return false;
		}

		return (words.Find(word) != null);
	}
}
