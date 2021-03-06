﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse
{
    public class ConstantDataSource : IDataSource {
        private List<Employee> employees = new List<Employee>();
        private Dictionary<int, Product> products = new Dictionary<int, Product>();
        private ObservableCollection<ProductCopy> productCopies = new ObservableCollection<ProductCopy>();
        private ObservableCollection<Order> orders = new ObservableCollection<Order>();

        public ConstantDataSource() {
            FillEmployees();
            FillProducts();
            FillProductCopies();
            FillOrders();
        }

        // Data fill
        private void FillEmployees() {
            employees.Add(new Employee("Jan", "Kowalski"));
        }

        private void FillProducts() {
            products.Add(1, new Product("Monitor", 4.5));
        }

        private void FillProductCopies() {
            productCopies.Add(new ProductCopy(products[0], "Opis 1", 12.2, 1));
        }

        private void FillOrders() {
            orders.Add(new Order(employees[0], productCopies[0], 12.0, 1));
        }

        // Getters
        public List<Employee> GetEmployees() {
            return employees;
        }

        public Dictionary<int, Product> GetProducts() {
            return products;
        }

        public ObservableCollection<ProductCopy> GetProductCopies() {
            return productCopies;
        }

        public ObservableCollection<Order> GetOrders() {
            return orders;
        }

    }
}
