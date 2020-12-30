from pokerscores import HandScore, BuildDeck, DrawCard

def ShowCallFoldHelp():
    print("At this point in the game, the other player has raised.")
    print("If you beleive you are still winning you can call by pressing C and the game will continue.")
    print("Or you can forfeit by pressing F and the game will end and you lose.")
    
def ShowCheckRaiseHelp():
    print("At this point in the game, no bet has been made.")
    print("If you beleive you are still winning you can raise by pressing R and the other player will have to decide what to do.")
    print("Or simply do nothing (and make a check) by pressing C, contining the game to the next round.")
    
def BettingRound(p1, p2):
    result = 0;
    action = input(f'{p1} will you check (C) or raise (R).')
    while (action != 'C' and action != 'R' and action != '--help'):
        action = input(f'{p1} will you check (C) or raise (R).')
    if (action == 'C'):
        action = input(f'{p2} will you check (C) or raise (R).')
        while (action != 'C' and action != 'R' and action != '--help'):
            action = input(f'{p2} will you check (C) or raise (R).')
        if (action == 'C'):
            result = 0
        elif (action == 'R'):
            action = input(f'{p1} will you call (C) or Fold (F):')
            while (action != "C" and action != "F" and action != "--help"):
                action = input(f'{p1} will you call (C) or Fold (F):')
            if (action == 'C'):
                result =  0
            elif (action == 'F'):
                result = 2
            else:
                ShowCallFoldHelp();
        else:
            ShowCheckRaiseHelp();
    else:
        action = input(f'{p2} will you call (C) or Fold (F):')
        while (action != 'C' and action != 'F' and action != '--help'):
            action = input(f'{p2} will you call (C) or Fold (F):')
        if (action == 'C'):
            result = 0
        elif (action == 'F'):
            result = 1
        else:
            ShowCallFoldHelp();
    return result
        
player1 = input('Enter Player 1s name:')
player2 = input('Enter Player 2s name:')

deck = BuildDeck() # Create our deck

table = []
p1cards = [];
p2cards = [];

card = DrawCard(deck)
p1cards.append(card)
deck.remove(card)

card = DrawCard(deck)
p2cards.append(card)
deck.remove(card)

card = DrawCard(deck)
p1cards.append(card)
deck.remove(card)

card = DrawCard(deck)
p2cards.append(card)
deck.remove(card)

#Show Cards
print(f"{player1} has the following cards: ", p1cards)
print(f"{player2} has the following cards: ", p2cards)

#Betting Round
winner = BettingRound(player1, player2)
if (winner == 1):
    print(f"{player2} Folded, {player1} wins.")
elif (winner == 2):
    print(f"{player1} Folded, {player2} wins.")

#Draw Flop
for i in range(0,3):
    card = DrawCard(deck)
    table.append(card)
    deck.remove(card)
    
#Show Table
print("The Table has the following cards: ", table)
    
#Betting Round
winner = BettingRound(player1, player2)
if (winner == 1):
    print(f"{player2} Folded, {player1} wins.")
elif (winner == 2):
    print(f"{player1} Folded, {player2} wins.")

# Draw Turn
card = DrawCard(deck)
table.append(card)
deck.remove(card)

#Show Table
print("The Table has the following cards: ", table)

#Betting Round
winner = BettingRound(player1, player2)
if (winner == 1):
    print(f"{player2} Folded, {player1} wins.")
elif (winner == 2):
    print(f"{player1} Folded, {player2} wins.")
    
# Draw River
card = DrawCard(deck)
table.append(card)
deck.remove(card)
    
#Show Table
print("The Table has the following cards: ", table)

#Betting Round
winner = BettingRound(player1, player2)
if (winner == 1):
    print(f"{player2} Folded, {player1} wins.")
elif (winner == 2):
    print(f"{player1} Folded, {player2} wins.")

#Declare Winner
p1hand = []
for c in p1cards:
    p1hand.append(c)
for c in table:
    p1hand.append(c)
p1score = HandScore(player1, p1hand)

p2hand = table + p2cards
p2score = HandScore(player2, p2hand)

if (p1score > p2score):
    print(f"{player1} wins")
else:
    print(f"{player2} wins")
    