using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace MathTests.Unit
{
    [TestFixture]
    class MathTests
    {
        [Test]
        public void Factorielle_Avec3_Retourne6() {

            int valeur = 3;
            int resultat = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(6, resultat); 
        }

        [Test]
        public void Factorielle_Avec5_Retourne120() {
            int valeur = 5;
            int resultat = MaBibliothequeATester.Math.Factorielle(valeur);
            Assert.AreEqual(120, resultat, "La valeur doit être égale à 120"); 
        }

        [Test]
        [ExpectedException(typeof(FormatException))]
        public void ToOnt32_avecChaineNonNumerique() {
            Convert.ToInt32("ABC");
        }
    }
}
