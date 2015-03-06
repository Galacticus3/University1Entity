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
                Assert.IsInstanceOfType(item.Name, typeof(string), "Group name is not int");
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
            Assert.IsInstanceOfType(actualGroup.Name, typeof(string), "Group name is not int");
        }

        public void InsertGroupTest()
        {
            var group = new Group() { Name = "KRYTAH"};

            groupManager.InsertGroup(group);


        }
    }
}
