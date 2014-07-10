# Word Game Dictionary
The aim of the project is to provide a simple way for game developers to check a standard or custom dictionary for word matches.

I have included the OSPD English scrabble dictionary, but realistically any dictionary (or even multiple) could be used.

## Why create this project?
There are a few reasons to have a game development specific set of dictionaries

* Using device dictionaries may yield undesired results. Many device dictionaries contain proper nouns, user saved words, or slang.
* Device dictionaries are typically designed for spellchecking. This means developers have to implement or subvert complex methods to yield the desired result.
* A custom library can help localization without requiring a user's device is in a specific language to access other dictionaries.
* I couldn't already find one on the internet.

## Usage
### iOS & OSX
**Default usage of the OSPD Dictionary**

Objective-C

```Objective-C
WordGameDictionary* wgd = [[WordGameDictionary alloc] init];
[wgd checkWord:wordToCheck minimumLength:3]
```
Swift

```Swift
var wgd = WordGameDictionary();
wgd.checkWord(wordToCheck, minimumLength: 3);
```

**Using a custom dictionary**

Objective-C

```Objective-C
WordGameDictionary* wgd = [[WordGameDictionary alloc] initWithDictionaryFile:@"SPDR"];
[wgd checkWord:wordToCheck minimumLength:3]
```

Swift

```Swift
var wgd = WordGameDictionary("SPDR");
wgd.checkWord(wordToCheck, minimumLength: 3);
```

### Unity

**Default usage of the OSPD Dictionary**

C#

```CSharp
WordGameDict wgd = new WordGameDict();
wgd.CheckWord(wordToCheck, 3);
```
UnityScript

```UnityScript
var wgd:WordGameDict = WordGameDict();
wgd.checkWord(wordToCheck, 3);
```

**Using a custom dictionary**

C#

```CSharp
WordGameDict wgd = new WordGameDict("SPDR.txt");
wgd.CheckWord(wordToCheck, 3);
```

UnityScript

```UnityScript
var wgd:WordGameDict = WordGameDict("SPDR.txt");
wgd.checkWord(wordToCheck, 3);
```

### Java
Coming Soon
### C++
Coming Soon

## Closing thoughts
Hopefully this library helps simplify your word game development. Let me know if you use it in your game!