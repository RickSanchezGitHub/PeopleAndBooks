using AutoMapper;
using NUnit.Framework;
using PeopleAndBooks.BLL.config;
using PeopleAndBooks.BLL.Service;
using PeopleAndBooks.BLL.Tests.TestCaseSourse;

namespace PeopleAndBooks.BLL.Tests
{
    public class HumanTests
    {
        private HumanTestCaseSourse _mockHuman;
        private HumanService _service;
        [SetUp]
        public void Setup()
        {
            _mockHuman = new HumanTestCaseSourse();
        }

        [Test]
        public void GetAllTest_ShouldReturnAllHumans()
        {
            var expected = _mockHuman.GetHumans();
            var actual = _service.GetAllHuman();
            Assert.Equals(expected, actual);
        }
    }
}