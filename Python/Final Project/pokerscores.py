from random import choice

def BuildDeck():
    numbers=list(range(2,15))
    suits = ['H','S','C','D']
    deck = []
    for i in numbers:
        for s in suits:
            card = s+str(i)
            deck.append(card)
    return deck

def DrawCard(deck):
    return choice(deck)

def FourOfAKind(hand,suits,numbers,rnum,rlet):
    for i in numbers:
            if numbers.count(i) == 4:
                four = i
            elif numbers.count(i) == 1:
                card = i
    score = 105 + four + card/100
    return score

def FullHouse(hand,suits,numbers,rnum,rlet):
    for i in numbers:
        if numbers.count(i) == 3:
            full = i
        elif numbers.count(i) == 2:
            p = i
    score = 90 + full + p/100  
    return score

def ThreeOfAKind(hand,suits,numbers,rnum,rlet):
    cards = []
    for i in numbers:
        if numbers.count(i) == 3:
            three = i
        else: 
            cards.append(i)
    score = 45 + three + max(cards) + min(cards)/1000
    return score

def TwoPair(hand,suits,numbers,rnum,rlet):
    pairs = []
    cards = []
    for i in numbers:
        if numbers.count(i) == 2:
            pairs.append(i)
        elif numbers.count(i) == 1:
            cards.append(i)
            cards = sorted(cards,reverse=True)
    score = 30 + max(pairs) + min(pairs)/100 + cards[0]/1000
    return score

def Pair(hand,suits,numbers,numberMatches,suitMatches):    
    pair = []
    cards  = []
    for i in numbers:
        if numbers.count(i) == 2:
            pair.append(i)
        elif numbers.count(i) == 1:    
            cards.append(i)
            cards = sorted(cards,reverse=True)
    score = 15 + pair[0] + cards[0]/100 + cards[1]/1000 + cards[2]/10000
    return score

def HandScore(name, hand):
    suits =[]
    for i in range(7):
        suits.append(hand[i][:1]) # We get the suit for each card in the hand
    
    uNumbers = [int(hand[i][1:])]
    uNumbers = sorted(uNumbers)
    numbers = []
    for i in range(5):
        numbers.append(int(hand[i][1:])) # We get the suit for each card in the hand
    
    numberMatches = [numbers.count(i) for i in numbers]  # We count repetitions for each number
    suitMatches = [suits.count(i) for i in suits]  # We count repetitions for each suit

    cardDiff = numbers[0] - numbers[4] # The difference between the greater and smaller number in the hand
    handtype = ''
    score = 0
    if 5 in suitMatches:
        #We have some kind of flush as all the suits match.
        if 14 in numbers and 13 in numbers and 12 in numbers and 11 in numbers and 10 in numbers:
            #We have a royal flush because, all the cards are face cards |(i.e eqto or above 10)
            handtype = 'Royal Flush'
            score = 135
          # print('this hand is a %s:, with score: %s' % (handtype,score))  I comment the prints so the script runs faster 
        elif cardDiff == 4 and max(numberMatches) == 1:
            #We have a straight flush because, no card matches and there is a diffence of 4
            handtype = 'Straight Flush'
            score = 120 + max(numbers)
            hand2 = ['H7', 'H7', 'H7', 'H7', 'H7']
          # print('this hand is a %s:, with score: %s' % (handtype,score)) 
        elif 4 in numberMatches:
            # We have a four of a k9ind because 4 of the number match
            handtype == 'Four of a Kind'
            score = FourOfAKind(hand,suits,numbers,numberMatches,suitMatches)
          # print('this hand is a %s:, with score: %s' % (handtype,score)) 
        elif sorted(numberMatches) == [2,2,3,3,3]:
            # We have a full house because we have 2 and 3 sets of cards matching
            handtype == 'Full House'
            score = FullHouse(hand,suits,numbers,numberMatches,suitMatches)
          # print('this hand is a %s:, with score: %s' % (handtype,score)) 
        elif 3 in numberMatches:
            handtype = 'Three of a Kind'
            score = ThreeOfAKind(hand,suits,numbers,numberMatches,suitMatches)
          # print('this hand is a %s:, with score: %s' % (handtype,score)) 
        elif numberMatches.count(2) == 4:
            handtype = 'Two Pair'
            score = TwoPair(hand,suits,numbers,numberMatches,suitMatches)
          # print('this hand is a %s:, with score: %s' % (handtype,score)) 
        elif numberMatches.count(2) == 2:
            handtype = 'Pair'
            score = Pair(hand,suits,numbers,numberMatches,suitMatches)
        else:
            handtype = 'Flush'
            score = 75 + max(numbers)/100
    elif 4 in numberMatches:
        handtype = 'Four of a Kind'
        score = FourOfAKind(hand,suits,numbers,numberMatches,suitMatches)
    elif sorted(numberMatches) == [2,2,3,3,3]:
       handtype = 'Full House'
       score = FullHouse(hand,suits,numbers,numberMatches,suitMatches)
    elif 3 in numberMatches:
        handtype = 'Three of a Kind' 
        score = ThreeOfAKind(hand,suits,numbers,numberMatches,suitMatches)
    elif numberMatches.count(2) == 4:
        handtype = 'Two Pair'
        score = TwoPair(hand,suits,numbers,numberMatches,suitMatches)
    elif numberMatches.count(2) == 2:
        handtype = 'Pair'
        score = Pair(hand,suits,numbers,numberMatches,suitMatches)
    elif cardDiff == 4:
        handtype = 'Straight'
        score = 65 + max(numbers)
    else:
        handtype= 'High Card'
        n = sorted(numbers,reverse=True)
        score = n[0] + n[1]/100 + n[2]/1000 + n[3]/10000 + n[4]/100000     
        
    print(f"{name} has a {handtype}")
    return score