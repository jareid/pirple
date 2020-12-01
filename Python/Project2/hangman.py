import random
import getpass

# This function randomly pulls a word out of my word bank random_wordbank and names it secret_word

hangman=['''
                 _____
                |     |
                      |
                      |
                      |
                     _|_''', '''
                 _____
                |     |
                O     |
                      |
                      |
                     _|_''', '''
                 _____
                |     |
                O     |
                |     |
                |     |
                     _|_''', '''
                 _____
                |     |
                O     |
               /|     |
                |     |
                     _|_''', '''
                 _____
                |     |
                O     |
               /|\    |
                |     |
                     _|_''', ''' 
                 _____
                |     |
                O     |
               /|\    |
                |     |
               /     _|_''', '''
                 _____
                |     |
                O     |
               /|\    |
                |     |
               / \   _|_''','''
       ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆
       ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆    
                
                    \O/      
          ~WINNER~   |   ~WINNER~        
                     |    
                    / \ 
                                       
       ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆
       ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆ ☆''']

def get_secret_word():
    word = input("Please choose a word for the player to attempt to guess:")
    onlyletters = word.isalpha();
    while (not onlyletters):
        print("You must choose a word that only contains letters!")
        word = input("Please choose a word for the player to attempt to guess:")
        onlyletters = word.isalpha();
    return word

def clear_screen():
    print(chr(27) + "[2J") 
    
def get_guess():
    guess=input("-> Guess A Letter: ")
    guess=guess.upper()
    print() 
    if guess in guessed_letters:
        print("-> " + guess + " has already been chosen, please try again.")
        get_guess()
    elif len(guess) !=1:
        print("-> You can only pick one letter at a time.")
        get_guess()
    elif guess not in 'ABCDEFGHIJKLMNOPQRSTUVWXYZ ':
        print("-> You can only pick letters, not numbers or other characters")
        get_guess()
    else:
        guessed_letters.append(guess)
    return guess
    
word=get_secret_word()
clear_screen()

loop=1
while loop==1:
    guessed_letters=[]
    word=word.upper()
    blanks='-' * len(word)  
    wrong=-1
    right=[]
    
    running=True
    while running==True: 
        right=[]  
        for i in range(len(word)):
           if word[i] in guessed_letters:
                blanks=blanks[:i] + word[i] + blanks[i+1:]                
                right.append(i)
   
        print("\n" * 3)
    
        if wrong < 5:
            print(hangman[wrong+1])
        else:
            print(hangman[wrong+1])
            print()
            print(" -> You lose")
            running=False
            
        if len(right)==len(word):
            print()
            print()
            print(hangman[7])
            running=False
    
        print()
        print()
        print("-> Word: " + blanks + "") 
        print("-> Incorrect Guesses: ", end='')
     
        for i in range(len(guessed_letters)):
             print("", end='')
             print(guessed_letters[i], end='')
         
        guess=get_guess()   
        if not guess in word:
            wrong=wrong+1