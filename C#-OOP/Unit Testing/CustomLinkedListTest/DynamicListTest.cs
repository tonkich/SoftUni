using System;
using System.Collections.Generic;
using System.Diagnostics;
using CustomLinkedList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomLinkedListTest
{
    [TestClass]
    public class DynamicListTest
    {
        [TestMethod]
        public void TestAdd_CheckIfElementIsAtCertainPoistion()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("asd");
            list.Add("dsa");
            list.Add("a");
            list.Add("b");
            Assert.AreEqual(list[2], "a", "Item doesnt equals the given position!");
        }

        [TestMethod]
        public void TestAdd_AddsElement()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("asd");
            Assert.AreEqual(list[0], "asd", "Item isnt added at end of list!");
        }

        [TestMethod]
        public void TestRemoveAt_RemovesElementAtPosition()
        {
            DynamicList<int> list = new DynamicList<int>();
            list.Add(0);
            list.Add(1);
            list.Add(2);
            list.RemoveAt(1);
            int secondNumber = list[1];
            Assert.AreEqual(2, secondNumber,
                "The second number should be the third entered after removing the second from the list!");
        }

        [TestMethod]
        public void TestRemove_RemoveElement()
        {

            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Add("third");

            list.Remove("second");
            int count = list.Count;

            Assert.AreEqual(2, count, "The count of elements of the list should be 2 after removing an element.");
        }

        [TestMethod]
        public void TestContains_CheckIfElementExistsInList()
        {
            DynamicList<string> list = new DynamicList<string>();
            list.Add("first");
            list.Add("second");
            list.Contains("second");
            Assert.AreEqual(list.Contains("second"),"second","The list should contain the added value.");
        }

}
}
