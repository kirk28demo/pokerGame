using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Poker_Cards.Models;

namespace Poker_Cards.Controllers
{
    public class HomeController : Controller
    {
        Random rnd = new Random();
        public HomeController()
        {
        }
        private Card[] myCard = new Card[5];
        DeckOfCards deckCardsObj = new DeckOfCards();
        List<Card> card123 = new List<Card>();
        private void Deal()
        {
            for (int j = 0; j < 5; j++)
            {
                myCard[j] = deckCardsObj.GetDeck[j];
            }
        }
        private string DisplaySuit()
        {
            string tempSuit = string.Empty;
            foreach (Card item in myCard)
            {
                tempSuit += item.CardSuit.ToString() + "-";
            }
            return tempSuit;
        }
        private string DisplayRank()
        {
            string tempRank = string.Empty;
            foreach (Card item in myCard)
            {
                tempRank += item.CardRank.ToString() + "-";
            }
            return tempRank;
        }
        public ActionResult Index()
        {
            deckCardsObj.SetupCard();
            Deal();
            PokerLogic pokerObj = new PokerLogic();
            pokerObj.MyCards = myCard;
            ViewBag.MessageCards = DisplaySuit();
            ViewBag.MessageRank = DisplayRank();
            ViewBag.MessageResult = pokerObj.EvaluateCard().ToString();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}