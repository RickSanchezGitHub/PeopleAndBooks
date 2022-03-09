using AutoMapper;
using Moq;
using NUnit.Framework;
using PeopleAndBooks.BLL.config;
using PeopleAndBooks.BLL.Model;
using PeopleAndBooks.BLL.Service;
using PeopleAndBooks.BLL.Service.Interface;
using PeopleAndBooks.BLL.Tests.TestCaseSourse;
using PeopleAndBooks.DAL.Interface;
using System.Collections.Generic;

namespace PeopleAndBooks.BLL.Tests
{
    public class HumanTests
    {
        private HumanTestCaseSourse _mockHuman;
        private Mock<IHumanReposotory> _repository;
        private HumanService _service;
        private IMapper _mapper;
        [SetUp]
        public void Setup()
        {
            _repository = new Mock<IHumanReposotory>();
            _mapper = new Mapper(new MapperConfiguration(cfg => cfg.AddProfile<PBMapper>()));
            _service = new HumanService(_mapper, _repository.Object);
            _mockHuman = new HumanTestCaseSourse();
        }

        [Test]
        public void GetAllTest_ShouldReturnAllHumans()
        {
            var entity = _mockHuman.GetHumans();
            _repository.Setup(r => r.GetAll()).Returns(entity);
            var expected = _mapper.Map<List<Human>>(entity);

            var actual = _service.GetAll();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [Test]
        public void GetAllAuthorsTest_ShouldReturnAllAuthors()
        {
            var entity = _mockHuman.GetHumans();
            _repository.Setup(r => r.GetAllAuthor()).Returns(entity);
            var expected = _mapper.Map<List<Human>>(entity);

            var actual = _service.GetAllAuthor();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void AddTest_ShouldReturnId()
        {
            var entity = _mockHuman.GetHumans();
            _repository.Setup(r => r.GetAll()).Returns(entity);
            var expected = _mapper.Map<List<Human>>(entity);

            var actual = _service.GetAll();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [Test]
        public void DeleteTest_ShouldNotReterns()
        {
            var entity = _mockHuman.GetHumans();
            _repository.Setup(r => r.GetAll()).Returns(entity);
            var expected = _mapper.Map<List<Human>>(entity);

            var actual = _service.GetAll();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);
        }

        [Test]
        public void FindHumansTest_ShouldReturnHumans()
        {
            var entity = _mockHuman.GetHumans();
            _repository.Setup(r => r.GetAll()).Returns(entity);
            var expected = _mapper.Map<List<Human>>(entity);

            var actual = _service.GetAll();

            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.Count, actual.Count);
        }

    }
}