using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using BLL.Implementations;
using DTO;
using DBModels;
using System.Linq;

namespace UnitTestProject
{
    [TestClass]
    public class TestCRUDGroup
    {
        private UnitOfWork uOw;
        private GroupManager groupManager;

        [TestInitialize]
        public void CreateUOW()
        {
            uOw = new UnitOfWork();
            groupManager = new GroupManager(uOw);
        }

        [TestMethod]
        public void GetGroupsTest()
        {
            var list = groupManager.GetGroups();

            Assert.IsNotNull(list, "Groups list is null");

            foreach (var item in list)
            {
                Assert.IsInstanceOfType(item, typeof(GroupDTO), "Object type is wrong!");
                Assert.IsInstanceOfType(item.Id, typeof(int), "Id is not int");
                Assert.IsInstanceOfType(item.Name, typeof(string), "Group name is not string");
            }
        }

        [TestMethod]
        public void GetGroupByIdTest()
        {
            var expectedGroup = groupManager.GetGroups().LastOrDefault();
            var actualGroup = groupManager.GetGroupByID(expectedGroup.Id);

            Assert.IsNotNull(actualGroup, "Group is null");

            Assert.AreEqual(expectedGroup.Id, actualGroup.Id, "DB return different id");
            Assert.AreEqual(expectedGroup.Name, actualGroup.Name, "DB return different group name");

            Assert.IsInstanceOfType(actualGroup, typeof(Group), "Object type is wrong!");
            Assert.IsInstanceOfType(actualGroup.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualGroup.Name, typeof(string), "Group name is not string");
        }

        [TestMethod]
        public void InsertGroupTest()
        {
            var expectedCount = groupManager.GetGroups().Count();
            var expectedGroup = new Group() { Name = "KRYTAH" };
            groupManager.InsertGroup(expectedGroup);

            var actualCount = groupManager.GetGroups().Count();
            var actualGroup = groupManager.GetGroups().Last();

            Assert.IsNotNull(actualGroup, "Group is null");
            Assert.AreEqual(expectedGroup.Name, actualGroup.Name, "DB return different group name");
            Assert.IsInstanceOfType(actualGroup, typeof(GroupDTO), "Object type is wrong!");
            Assert.IsInstanceOfType(actualGroup.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualGroup.Name, typeof(string), "Group name is not string");
            Assert.AreEqual(expectedCount+1, actualCount, "added to DB more then one value");
        }

        [TestMethod]
        public void UpdateGroupTest()
        {


            var expectedGroup = groupManager.GetGroups().Last();
            var expectedId = expectedGroup.Id;
            expectedGroup.Name = "UpdateGroup";
            groupManager.UpdateGroup(new Group() { Id = expectedId, Name = expectedGroup.Name });

            var actualGroup = groupManager.GetGroups().Last();
            var actualId = actualGroup.Id;

            Assert.IsNotNull(actualGroup, "Group is null");

            Assert.AreEqual(expectedId, actualId, "DB return different id");
            Assert.AreEqual(expectedGroup.Name, actualGroup.Name, "DB return different group name");

            Assert.IsInstanceOfType(actualGroup, typeof(GroupDTO), "Object type is wrong!");
            Assert.IsInstanceOfType(actualGroup.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualGroup.Name, typeof(string), "Group name is not string");
        }

        [TestMethod]
        public void DeleteGroupTest()
        {
            var expectedCount = groupManager.GetGroups().Count();
            var expectedGroup = groupManager.GetGroups().Last();
            var expectedId = expectedGroup.Id;
            
            groupManager.DeleteGroup(expectedId);

            var actuaList = groupManager.GetGroups();
            var actualCount = actuaList.Count();

            Assert.AreEqual(expectedCount - 1, actualCount, "deleted from DB not one value. Its" + (expectedCount-actualCount).ToString());

            foreach (var item in actuaList)
            {
                Assert.AreNotEqual(expectedId, item.Id, "DB do not delete item with id: " + expectedId.ToString());
            }
        }
    }
}
