using Microsoft.VisualStudio.TestTools.UnitTesting;
using Strategy.Sorting;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Tests
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void Should_Sort_Using_Quick_Sort()
        {
            // Arrange
            var records = new SortableList();
            records.SetSortingStrategy(new QuickSort());
            records.Add("C");
            records.Add("B");
            records.Add("A");
            Assert.IsTrue(records.List[0] == "C");

            // Act
            records.Sort();

            // Assert
            Assert.IsTrue(records.List[0] == "A");
        }

        [TestMethod]
        public void Should_Sort_Using_Shell_Sort()
        {
            // Arrange
            var records = new SortableList();
            records.SetSortingStrategy(new ShellSort());
            records.Add("Clara");
            records.Add("Bella");
            records.Add("Abigail");
            Assert.IsTrue(records.List[0] == "Clara");

            // Act
            records.Sort();

            // Assert
            Assert.IsTrue(records.List[0] == "Abigail");
        }
    }
}
