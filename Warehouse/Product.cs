﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse {
    class Product {

        private static int index = 0;

        private int id;
        private string name;
        private double weight;
        private List<ProductInfo> productInfos;

        public Product(string name, double weight) {
            id = index++;
            this.name = name;
            this.weight = weight;
        }

        public string getName() {
            return name;
        }

        public double getWeight() {
            return weight;
        }

        public List<ProductInfo> getProductInfos() {
            return productInfos;
        }

    }
}
