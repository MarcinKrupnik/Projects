using System;
using Xunit;
using System.Collections.Generic;
using Xunit.Abstractions;
using MarcinKrupnikLab2Zadanie;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void CalculateRange()
        {
            Weapon sut = new Axe();
            sut.strange = (12);

            Assert.InRange(sut.strange, 0, 99);
        }
        [Fact]
        public void CalculateFullNameStartsWithLastName()
        {
            Champion sut = new Elise();
            sut.FirstName = "Elise";
            sut.LastName = "Brawl";
            Assert.EndsWith("Brawl", sut.FullName);
        }
    }
}
