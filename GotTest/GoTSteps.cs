using System;
using GoT;
using TechTalk.SpecFlow;

namespace GotTest
{
    using NUnit.Framework;

    [Binding]
    public class GoTSteps
    {
        private Panier panier;

        [Given(@"Mon panier est vide")]
        public void GivenMonPanierEstVide()
        {
            panier = new Panier();
        }

        [Then(@"Le panier vaut (.*) euros")]
        public void ThenLePanierVautEuros(decimal total)
        {
            Assert.AreEqual(total, panier.Total);
        }

        [When(@"J'ajoute le tome (.*) valant (.*) euros")]
        public void WhenJAjouteLeTomeValantEuros(int tomeOpus, decimal prix)
        {
            panier.AjouterTome(new Tome(tomeOpus, prix));
        }

    }
}
