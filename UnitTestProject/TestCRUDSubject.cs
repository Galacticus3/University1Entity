using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using BLL.Implementations;
using DTO;
using System.Linq;
using DBModels;

namespace UnitTestProject
{
    [TestClass]
    public class TestCRUDSubject
    {
        private UnitOfWork uOw;
        private SubjectManager subjectManager;

        [TestInitialize]
        public void CreateUOW()
        {
            uOw = new UnitOfWork();
            subjectManager = new SubjectManager(uOw);
        }

        [TestMethod]
        public void GetSubjectsTest()
        {
            var list = subjectManager.GetSubjects();

            Assert.IsNotNull(list, "Subjects list is null");

            foreach (var item in list)
            {
                Assert.IsInstanceOfType(item, typeof(SubjectDTO), "Object type is wrong!");
                Assert.IsInstanceOfType(item.Id, typeof(int), "Id is not int");
                Assert.IsInstanceOfType(item.Name, typeof(string), "Subject name is not string");
            }
        }

        [TestMethod]
        public void GetSubjectByIdTest()
        {
            var expectedSubject = subjectManager.GetSubjects().LastOrDefault();
            var actualSubject = subjectManager.GetSubjectByID(expectedSubject.Id);

            Assert.IsNotNull(actualSubject, "Subject is null");

            Assert.AreEqual(expectedSubject.Id, actualSubject.Id, "DB return different id");
            Assert.AreEqual(expectedSubject.Name, actualSubject.Name, "DB return different subject name");

            Assert.IsInstanceOfType(actualSubject, typeof(Subject), "Object type is wrong!");
            Assert.IsInstanceOfType(actualSubject.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualSubject.Name, typeof(string), "Subject name is not string");
        }

        [TestMethod]
        public void InsertSubjectTest()
        {
            var expectedCount = subjectManager.GetSubjects().Count();
            var expectedSubject = new Subject() { Name = "KRYTAH" };
            subjectManager.InsertSubject(expectedSubject);

            var actualCount = subjectManager.GetSubjects().Count();
            var actualSubject = subjectManager.GetSubjects().Last();

            Assert.IsNotNull(actualSubject, "Subject is null");
            Assert.AreEqual(expectedSubject.Name, actualSubject.Name, "DB return different subject name");
            Assert.IsInstanceOfType(actualSubject, typeof(SubjectDTO), "Object type is wrong!");
            Assert.IsInstanceOfType(actualSubject.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualSubject.Name, typeof(string), "Subject name is not string");
            Assert.AreEqual(expectedCount + 1, actualCount, "added to DB more then one value");
        }

        [TestMethod]
        public void UpdateSubjectTest()
        {
            var expectedSubject = subjectManager.GetSubjects().Last();
            var expectedId = expectedSubject.Id;
            expectedSubject.Name = "UpdateSubject";
            subjectManager.UpdateSubject(new Subject() { Id = expectedId, Name = expectedSubject.Name });

            var actualSubject = subjectManager.GetSubjects().Last();
            var actualId = actualSubject.Id;

            Assert.IsNotNull(actualSubject, "Subject is null");

            Assert.AreEqual(expectedId, actualId, "DB return different id");
            Assert.AreEqual(expectedSubject.Name, actualSubject.Name, "DB return different subject name");

            Assert.IsInstanceOfType(actualSubject, typeof(SubjectDTO), "Object type is wrong!");
            Assert.IsInstanceOfType(actualSubject.Id, typeof(int), "Id is not int");
            Assert.IsInstanceOfType(actualSubject.Name, typeof(string), "Subject name is not string");
        }

        [TestMethod]
        public void DeleteSubjectTest()
        {
            var expectedCount = subjectManager.GetSubjects().Count();
            var expectedSubject = subjectManager.GetSubjects().Last();
            var expectedId = expectedSubject.Id;

            subjectManager.DeleteSubject(expectedId);

            var actuaList = subjectManager.GetSubjects();
            var actualCount = actuaList.Count();

            Assert.AreEqual(expectedCount - 1, actualCount, "deleted from DB not one value. Its" + (expectedCount - actualCount).ToString());

            foreach (var item in actuaList)
            {
                Assert.AreNotEqual(expectedId, item.Id, "DB do not delete item with id: " + expectedId.ToString());
            }
        }

    }
}
