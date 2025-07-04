using LinqToDB;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MySql.Data;
using System.Linq;
using TeachingLoadApp.BusinessLogic.Interfaces;
using TeachingLoadApp.BusinessLogic.Services;
using TeachingLoadApp.Context;
using TeachingLoadApp.DataAccess.Repositories;
using TeachingLoadApp.Models;

namespace UnitTestProject
{
    [TestClass]
    public class TeacherServiceTests
    {
        private DbContext _context;
        private IUserService _userService;
        private ITeacherService _teacherService;
        private ILoadService _loadService;

        private string _testLogin;

        [TestInitialize]
        public void Setup()
        {
            _context = DbHandler.CreateContext();

            var userRepository = new UserRepository(_context);
            var teacherRepository = new TeacherRepository(_context);
            var loadRepository = new LoadRepository(_context);
            var classInLoadRepository = new ClassInLoadRepository(_context);

            _userService = new UserService(userRepository, teacherRepository, loadRepository, classInLoadRepository);
            _teacherService = new TeacherService(teacherRepository, loadRepository, classInLoadRepository);
            _loadService = new LoadService(loadRepository, classInLoadRepository);

            _testLogin = "test_user_" + Guid.NewGuid().ToString().Substring(0, 8);


            _userService.GetAll()
                .Where(u => u.Login.StartsWith("test_user_"))
                .ToList()
                .ForEach(u => _userService.Delete(u.Id));
        }

        [TestCleanup]
        public void Cleanup()
        {
            _userService.GetAll()
                .Where(u => u.Login.StartsWith("test_user_"))
                .ToList()
                .ForEach(u => _userService.Delete(u.Id));
        }

        [TestMethod]
        public void DeleteTeacher_WithCascade_RemovesTeacherAndLoads()
        {
            var user = new AppUser
            {
                Login = _testLogin,
                Password = "test123",
                Role = "user"
            };
            int userId = _userService.Add(user);

            var teacher = new Teacher
            {
                FirstName = "Test",
                MiddleName = "T",
                LastName = "Teacher",
                LoadLimit = 100,
                UserId = userId
            };
            int teacherId = _teacherService.Add(teacher);

            var load = new Load
            {
                TeacherId = teacherId,
                Semestr = "winter",
                LoadHours = 50
            };
            int loadId = _loadService.Add(load);

            Assert.IsNotNull(_teacherService.GetById(teacherId));
            Assert.IsTrue(_loadService.GetByTeacherId(teacherId).Any());

            _teacherService.Delete(teacherId);

            Assert.IsNull(_teacherService.GetById(teacherId));
            Assert.IsFalse(_loadService.GetByTeacherId(teacherId).Any());
        }
    }
}