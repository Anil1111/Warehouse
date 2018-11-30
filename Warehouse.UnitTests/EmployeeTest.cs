﻿using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Warehouse.UnitTests {
    [TestClass]
    public class EmployeeTest {
        
        private List<Employee> employees = new List<Employee>();
        private IDataSource dataSource;

        [TestInitialize]
        public void TestInitialize() {
            dataSource = new TestDataSource();
        }

        [TestMethod]
        public void Employee_FirstValidId() {
            // Arrange
            Employee employee = dataSource.GetEmployees()[0];
            // Assert
            Assert.AreEqual(employee.GetId(), 0);
        }

        [TestMethod]
        public void Employee_ValidIdIncrease() {
            // Arrange
            Employee employee = new Employee("Galen", "Erso");
            // Assert
            Assert.AreEqual(employee.GetId(), 1);
        }
    }
}
