using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    [TestFixture]
    class Tests
    {
      

        [Test]
        public void DreieckKannErstelltWerden()
        {
            var x = new Rechteck("Rechteck_1",1,1,1);
            Assert.IsTrue(x.nameRechteck != null && x.nameRechteck != "");
            Assert.IsTrue(x.laengeRechteck > 0 && x.laengeRechteck < 1000);
            Assert.IsTrue(x.hoeheRechteck > 0 && x.hoeheRechteck < 1000);
            Assert.IsTrue(x.breiteRechteck > 0 && x.breiteRechteck < 1000);
        }

        [Test]
        public void LeangeIstNegativ()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1",-1,1,1);
            });

        }

        [Test]
        public void LeangeIstZuLang()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1", 1000, 1, 1);
            });

        }

        [Test]
        public void breiteIstNegativ()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1", 1, -1, 1);
            });

        }

        [Test]
        public void breiteIstZuLang()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1", 1, 1000, 1);
            });

        }

        [Test]
        public void hoeheIstNegativ()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1", 1, 1, -1);
            });

        }

        [Test]
        public void hoeheIstZuBreit()
        {
            Assert.Catch(() =>
            {
                var x = new Rechteck("Rechteck_1", 1, 1, 1000);
            });

        }


        [Test] 
        public void CannotCreateRecheckWithEmptyName()
        { 
            Assert.Catch(() => 
            { 
                var x = new Rechteck(null, 1, 1, 1); 
            }); 
        } 

 
        [Test] 
        public void CannotCreateRecheckWithEmptyName2()
        { 
            Assert.Catch(() => 
            { 
                var x = new Rechteck("", 1, 1, 1); 
            }); 
        } 

    } 
    
}
