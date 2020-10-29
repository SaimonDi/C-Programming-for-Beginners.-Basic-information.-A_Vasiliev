using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Go_Fish_ {
    class Deck {
        private List<Card> cards;
        private Random random = new Random();

        //Конструктор создаёт колоду из 52 карт
        public Deck() {
            cards = new List<Card>();
            for(int suit = 0; suit <= 3; suit++) {
                for(int value = 1; value <= 13; value++) 
                    cards.Add(new Card(((Suit)suit), (Value)value));
                }
            }

        public Deck(IEnumerable<Card> initialCards) { cards = new List<Card>(initialCards); }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd) { cards.Add(cardToAdd); }

        //Берет определённую по порядку карту из колоды
        public Card Deal(int index) {
            Card CardToDeal = cards[index];
            cards.RemoveAt(index);
            return CardToDeal;
            }
        //Берет верхнюю карту из колоды
        public Card Deal() {
            return Deal(0);
            }
        //Позволяет взять карту из колоды
        public Card Peek (int cardNumber) {
            return cards[cardNumber];
            }
        //Перемешивает карты в колоде
        public void Shuffle() {
            List<Card> NewCards = new List<Card>();
            while(cards.Count>0) {
                int CardToMove = random.Next(cards.Count);
                NewCards.Add(cards[CardToMove]);
                cards.RemoveAt(CardToMove);
                }
            cards = NewCards;
            }
        //Ищет в колоде карты определнного старшенства и, 
        //находя их, возвращает значение true
        public bool ContainsValue(Value value) {
            foreach(Card card in cards) 
                if(card.Value == value)
                    return true;
                return false;
            }
        //Позволяет получить наборы по четыре одинаковые карты,
        //совпадающие по старшенству, извлекает их из колоды
        //и возвращает новый вариант колоды, в который включена
        //и взятка
        public Deck PullOutValues(Value value) {
            Deck deckToReturn = new Deck(new Card[] { });
            for(int i = cards.Count - 1; i >= 0; i--)
                if(cards[i].Value == value)
                    deckToReturn.Add(Deal(i));
            return deckToReturn;
            }
        //Получив в качестве параметра карту, начинает искать взятки.
        //Обнаружив четыре одинаковые карты, он возвращает значение true.
        public bool HasBook (Value value) {
            int NumberOfCards = 0;
            foreach(Card card in cards)
                if(card.Value == value)
                    NumberOfCards++;
            if(NumberOfCards == 4)
                return true;
            else
                return false;
            }

        public IEnumerable<string> GetCardNames() {
            string[] CardNames = new string[cards.Count];
            for(int i = 0; i < cards.Count; i++) 
                CardNames[i] = cards[i].Name;
            return CardNames;
            }

        public void SortBySuit() { cards.Sort(new CardComparer_bySuit()); }
        public void SortByValue() { cards.Sort(new CardComparer_byValue()); }
        }
    }
