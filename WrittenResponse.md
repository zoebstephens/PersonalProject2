# Wordle Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to guess five letter words for entertainment. 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

My video demonstrates that my program can perform a word guessing game. 

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. The user enters a 5 letter word. Then my program outputs the word the user inputted with colors that indicate whether each character is in the word and if it is then if it is in the correct position. If the user inputs a word that is not 5 letters, my program will output an error message. If all the characters are in the correct position the user would have guessed the word and won the game. 
## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
List<string> words = new List<string>();
            words.Add("candy");
            words.Add("roach");
            words.Add("ready");
            words.Add("ahead");
            words.Add("reach");
            words.Add("break");
            words.Add("glass");
            words.Add("chart");
            words.Add("truth");
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
Random generator = new Random();
            int index = generator.Next(0, words.Count);

            string randomWord = words[index];

```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

 "The list is stored in the variable "words".

### 3b iv.

Describes what the data contained in the list represents in your program

This list contains the different words that are randomly generated for the user to input/guess. 

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

My list manages complexity by allowing the words index to contain unlimited amounts of words instead of using multiple if/else if statements to generate random words. This makes the addition of more words simpler instead of having to write another variable for each one. 

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static void DisplayInfo(string guess, string correct)
        {
            if (guess == null)
            {
                throw new ArgumentNullException("Guess can not be null");

            }

            if (guess.Length != correct.Length)
            {
                throw new ArgumentException("The guess must be the same length as the correct word");
            }


            int ix = 0;
            foreach (char c in guess)
            {
                DisplayCharInfo(c, ix, correct);
                ix = ix + 1;

            }
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
while (guess != correct)
            {
                guess = GetGuess(correct);
                DisplayInfo(guess, correct);
                Console.WriteLine();
            }
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

Given a guess and the correct word to be guessed, this calls DisplayCharInfo to display the guess to the screen coloring each character based on its position and if it is in the correct word. This is the main functionality of my program because it is used each time the user makes a guess. 

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1. Validate that the guess and correct word are the same length
2. If the lengths do not match, throw an exception
3. If they match, iterate through each character:
4. Use the DisplayCharInfo method to determine what color to print the character

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

DisplayInfo(null,null);

Second call:

Program.DisplayInfo("rainy", "crazy");

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This tests that the method does not allow a null input and throws an exception.

Condition(s) tested by the second call:

This tests that given a valid guess, the method will display the result.

### 3d iii.

Result of the first call:

This method fails throwing an exception. 

Result of the second call:

This method displays a red r, a, i, n and green y. 