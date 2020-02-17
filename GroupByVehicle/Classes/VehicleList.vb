Imports GroupByVehicle.Classes

Public Class VehicleList
    Public Function Vehicles() As List(Of Vehicle)
        Return New List(Of Vehicle)() From {
            New Vehicle With {
                .Id = 1,
                .Category = "Sports car",
                .Year = 2016,
                .Color = "Black",
                .Manufacturer = "Mazada",
                .Model = "Miata",
                .Retail = 30000D
            },
            New Vehicle With {
                .Id = 2,
                .Category = "Pick up",
                .Year = 2015,
                .Color = "White",
                .Manufacturer = "Chevrolet",
                .Model = "Sliverado 1500 Double Cab",
                .Retail = 37000D
            },
            New Vehicle With {
                .Id = 3,
                .Category = "Pick up",
                .Year = 2015,
                .Color = "Black",
                .Manufacturer = "Ford",
                .Model = "F-150 Crew Cab",
                .Retail = 55000D
            },
            New Vehicle With {
                .Id = 4,
                .Category = "Sedan",
                .Year = 2016,
                .Color = "Black",
                .Manufacturer = "BMW",
                .Model = "328d",
                .Retail = 42000D
            },
            New Vehicle With {
                .Id = 5,
                .Category = "Sports car",
                .Year = 2016,
                .Color = "Red",
                .Manufacturer = "Ford",
                .Model = "Mustang",
                .Retail = 41000D
            },
            New Vehicle With {
                .Id = 6,
                .Category = "Sports car",
                .Year = 2016,
                .Color = "Green",
                .Manufacturer = "Mazada",
                .Model = "CX-5",
                .Retail = 20000D
            },
            New Vehicle With {
                .Id = 7,
                .Category = "Sedan",
                .Year = 2015,
                .Color = "Black",
                .Manufacturer = "Nissan",
                .Model = "Altima",
                .Retail = 30000D
            },
            New Vehicle With {
                .Id = 8,
                .Category = "Sedan",
                .Year = 2016,
                .Color = "Grey",
                .Manufacturer = "Mazada",
                .Model = "Mazda 6",
                .Retail = 24000D
            },
            New Vehicle With {
                .Id = 9,
                .Category = "Sedan",
                .Year = 2016,
                .Color = "Black",
                .Manufacturer = "Toyota",
                .Model = "Camry XLE",
                .Retail = 34000D
            },
            New Vehicle With {
                .Id = 10,
                .Category = "Sports car",
                .Year = 2015,
                .Color = "Black",
                .Manufacturer = "Mazada",
                .Model = "Miata",
                .Retail = 25000D
            },
            New Vehicle With {
                .Id = 11,
                .Category = "Sedan",
                .Year = 2015,
                .Color = "Red",
                .Manufacturer = "Ford",
                .Model = "Escape",
                .Retail = 26000D
            }
        }
    End Function

End Class
