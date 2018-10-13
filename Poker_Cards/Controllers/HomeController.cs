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
        
        public HomeController ()
        {
            Suit suitObj = new Suit();
            Rank rankObj = new Rank();
            char[] charTemp =  new char[] { 'S', 'D', 'H', 'C' } ;
            string[] stringTemp = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<string> lstSuitChar = new List<string>();
            List<string> lstRankStr = new List<string>();
            for (int i = 0; i < charTemp.Length; i++)
            {
                lstSuitChar.Add(charTemp[i].ToString());
            }
            suitObj.suitList = lstSuitChar;
            for (int i = 0; i < stringTemp.Length; i++)
            {
                lstRankStr.Add(stringTemp[i]);
            }
            rankObj.rankList = lstRankStr;
            ShuffleCards(suitObj, rankObj);
        }
        private string ShuffleCards(Suit suitObj, Rank rankObj)
        {
            Random rnd = new Random();
            int suitRndNum = rnd.Next(1, suitObj.suitList.Count);
            int rankRndNum = rnd.Next(1, rankObj.rankList.Count);
            string suitTemp = string.Empty;
            string rankTemp = string.Empty;
            for (int i = 0; i < suitObj.suitList.Count; i++)
            {   
                if (i == suitRndNum)
                    suitTemp = suitObj.suitList[i];
            }
            for (int i = 1; i < rankObj.rankList.Count; i++)
            {
                if (i == rankRndNum)
                    suitTemp = rankObj.rankList[i];
            }
            
            return "";
        }

        public ActionResult Index()
        {
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