using System.Globalization;
using ToolsBazaar.Domain.CustomerAggregate;
using ToolsBazaar.Domain.OrderAggregate;
using ToolsBazaar.Domain.ProductAggregate;

namespace ToolsBazaar.Tests
{
    public static class TestData
    {
        public static readonly List<Customer> AllCustomers =
           new()
           {
                new Customer
                {
                    Id = 1,
                    Name = "Brown Nikolaus",
                    Email = "Modesto97@hotmail.com",
                    Address = "68628 Shanie Loop, Raymondshire, Wallis and Futuna"
                },

                new Customer
                {
                    Id = 3,
                    Name = "Evie Hintz",
                    Email = "Savanna.Corwin@hotmail.com",
                    Address = "146 Myron Junctions, West Jovanny, San Marino"
                },

                new Customer
                {
                    Id = 5,
                    Name = "Madyson Cruickshank",
                    Email = "Brionna.Little@hotmail.com",
                    Address = "4441 Kade Ridges, Wiltonville, Rwanda"
                },

                new Customer
                {
                    Id = 7,
                    Name = "Shemar Christiansen",
                    Email = "Kara.Mann37@hotmail.com",
                    Address = "606 Blick Heights, Beattyview, Czech Republic"
                },

                new Customer
                {
                    Id = 9,
                    Name = "Deanna Ernser",
                    Email = "Eldred_Hand94@yahoo.com",
                    Address = "95334 Eric Terrace, Boehmland, Faroe Islands"
                },

                new Customer
                {
                    Id = 11,
                    Name = "Antwon Corkery",
                    Email = "Marlene.Botsford@gmail.com",
                    Address = "61055 Nicolette Island, North Walton, Italy"
                },

                new Customer
                {
                    Id = 13,
                    Name = "Jude Zulauf",
                    Email = "Hollie.Streich78@hotmail.com",
                    Address = "72404 Keebler Brook, Brennanberg, Equatorial Guinea"
                }
           };

        public static readonly List<Product> AllProducts =
            new()
            {
                new Product
                {
                    Id = 1,
                    Name = "Mac Allister Aluminium 6-Treads Stepladder",
                    Price = 1m
                },
                new Product
                {
                    Id = 2,
                    Name = "Spacepro Opaque Internal Sliding Glass Door Kit",
                    Price = 2m
                },
                new Product
                {
                    Id = 3,
                    Name = "Corrapol-BT AC110BL Corrugated Bitumen Roof Sheet Black",
                    Price =3m
                },
                new Product
                {
                    Id = 4,
                    Name = "Stormguard Heavy Duty Around Door Strips Aluminium",
                    Price = 4m
                },
                new Product
                {
                    Id = 5,
                    Name = "Woodgrain Melamine Shelves",
                    Price = 5m
                },
                new Product
                {
                    Id = 6,
                    Name = "Pest-Stop Rodent Wax Blocks",
                    Price =6m
                },
            };

        public static readonly List<Order> TopOrdersListVersion1 =
         new()
         {
                new Order
                {
                    Id = 1,
                    Customer = GetCustomerById(1),
                    Date =
                        DateTime
                           .ParseExact("10/09/2010","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 1,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 3,
                                    Product =
                                        GetProductById(2)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 5,
                                    Product =
                                        GetProductById(3)
                                },
                            }

                },

                new Order
                {
                    Id = 2,
                    Customer = GetCustomerById(1),
                    Date =
                        DateTime
                           .ParseExact("04/17/2022","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 5,
                                    Id = 7,
                                    Product =
                                        GetProductById(2)
                                }
                            }

                },

                new Order
                {
                    Id = 3,
                    Customer = GetCustomerById(5),
                    Date =
                        DateTime
                           .ParseExact("04/16/2021","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 3,
                                    Id = 9,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 11,
                                    Product =
                                        GetProductById(2)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 13,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 15,
                                    Product =
                                        GetProductById(4)
                                },
                            }

                },

                new Order
                {
                    Id = 4,
                    Customer = GetCustomerById(3),
                    Date =
                        DateTime
                           .ParseExact("09/26/2015","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 17,
                                    Product =
                                        GetProductById(3)
                                },
                            }

                },

                new Order
                {
                    Id = 5,
                    Customer = GetCustomerById(7),
                    Date =
                        DateTime
                           .ParseExact("03/10/2016","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 19,
                                    Product =
                                        GetProductById(4)
                                },
                            }

                },

                new Order
                {
                    Id = 6,
                    Customer = GetCustomerById(5),
                    Date =
                        DateTime
                           .ParseExact("08/31/2018","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 21,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 23,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 25,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 27,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 29,
                                    Product =
                                        GetProductById(5)
                                },
                            }

                },

                new Order
                {
                    Id = 7,
                    Customer = GetCustomerById(3),
                    Date =
                        DateTime
                           .ParseExact("10/17/2022","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 31,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 33,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 35,
                                    Product =
                                        GetProductById(1)
                                },
                            }

                },

                new Order
                {
                    Id = 8,
                    Customer = GetCustomerById(9),
                    Date =
                        DateTime
                           .ParseExact("07/15/2015","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 37,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 39,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 41,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 43,
                                    Product =
                                        GetProductById(6)
                                },
                            }

                },

                new Order
                {
                    Id = 9,
                    Customer = GetCustomerById(11),
                    Date =
                        DateTime
                           .ParseExact("10/24/2021","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 45,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 47,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 49,
                                    Product =
                                        GetProductById(3)
                                },

                                new OrderItem
                                {
                                    Quantity = 3,
                                    Id = 51,
                                    Product =
                                        GetProductById(4)
                                },
                            }

                },

                new Order
                {
                    Id = 10,
                    Customer = GetCustomerById(13),
                    Date =
                        DateTime
                           .ParseExact("09/25/2021","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 3,
                                    Id = 53,
                                    Product =
                                        GetProductById(4)
                                },

                                new OrderItem
                                {
                                    Quantity = 3,
                                    Id = 55,
                                    Product =
                                        GetProductById(3)
                                },
                            }

                },
         };

        public static readonly List<Order> TopOrdersListVersion2 =
      new()
      {
                new Order
                {
                    Id = 1,
                    Customer = GetCustomerById(1),
                    Date =
                        DateTime
                           .ParseExact("10/09/2010","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 1,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 3,
                                    Product =
                                        GetProductById(2)
                                },

                                new OrderItem
                                {
                                    Quantity = 1,
                                    Id = 5,
                                    Product =
                                        GetProductById(3)
                                },
                            }

                },

                new Order
                {
                    Id = 2,
                    Customer = GetCustomerById(1),
                    Date =
                        DateTime
                           .ParseExact("04/17/2022","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 5,
                                    Id = 7,
                                    Product =
                                        GetProductById(2)
                                }
                            }

                },

                new Order
                {
                    Id = 3,
                    Customer = GetCustomerById(5),
                    Date =
                        DateTime
                           .ParseExact("04/16/2021","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 3,
                                    Id = 9,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 11,
                                    Product =
                                        GetProductById(2)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 13,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 15,
                                    Product =
                                        GetProductById(4)
                                },
                            }

                },

                new Order
                {
                    Id = 4,
                    Customer = GetCustomerById(3),
                    Date =
                        DateTime
                           .ParseExact("09/26/2015","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 17,
                                    Product =
                                        GetProductById(3)
                                },
                            }

                },

                new Order
                {
                    Id = 5,
                    Customer = GetCustomerById(7),
                    Date =
                        DateTime
                           .ParseExact("03/10/2016","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 2,
                                    Id = 19,
                                    Product =
                                        GetProductById(4)
                                },
                            }

                },

                new Order
                {
                    Id = 6,
                    Customer = GetCustomerById(5),
                    Date =
                        DateTime
                           .ParseExact("08/31/2018","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 21,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 23,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 25,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 27,
                                    Product =
                                        GetProductById(5)
                                },

                                new OrderItem
                                {
                                    Quantity = 4,
                                    Id = 29,
                                    Product =
                                        GetProductById(5)
                                },
                            }

                },

                new Order
                {
                    Id = 7,
                    Customer = GetCustomerById(3),
                    Date =
                        DateTime
                           .ParseExact("10/17/2022","MM/dd/yyyy",CultureInfo.InvariantCulture),
                    Items = new List<OrderItem>
                            {
                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 31,
                                    Product =
                                        GetProductById(1)
                                },

                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 33,
                                    Product =
                                        GetProductById(6)
                                },

                                new OrderItem
                                {
                                    Quantity = 7,
                                    Id = 35,
                                    Product =
                                        GetProductById(1)
                                },
                            }

                }
      };

        private static Product GetProductById(int id) => AllProducts.FirstOrDefault(p => p.Id == id);
        private static Customer GetCustomerById(int id) => AllCustomers.FirstOrDefault(c => c.Id == id);
    }
}
