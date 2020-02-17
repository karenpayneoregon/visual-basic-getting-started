Namespace Classes
    Public Class VehicleExamples
        ''' <summary>
        ''' I want to group by manufacturer, then list cars
        ''' </summary>
        ''' <remarks>
        ''' This is a very simply demo where the demo below this one
        ''' becomes more complex with sub groupings and order by clauses 
        ''' and as we become more detailed in groupings it's better to
        ''' resort to linq unlike this demo which is using lambda for
        ''' readability.
        ''' </remarks>
        Public Shared Sub GroupByManufacturerOrderByManufacturer()
            Dim carList As New VehicleList()

            Dim query = carList.Vehicles().
                    GroupBy(Function(car) car.Manufacturer).
                    Select(Function(item) New With {
                              Key .Key = item.Key,
                              Key .Vehicles = item
                              }).
                    OrderBy(Function(car) car.Key)

            For Each car In query
                Console.WriteLine(car.Key)
                For Each vehicle In car.Vehicles
                    Console.WriteLine($"  {vehicle.Year} {vehicle.Model}")
                Next

            Next
        End Sub
        ''' <summary>
        ''' I want to list by manufacturer, then by year and order 
        ''' by year then by model a-z.
        ''' </summary>
        Public Shared Sub GroupByManufacturerThenByYear()
            Dim carList As New VehicleList()

            Dim query = (
                    From cars In carList.Vehicles()
                    Group cars By cars.Manufacturer Into manufacturerGroup =
                    Group Select New With
                    {
                        Key Manufacturer,
                        Key .Count = manufacturerGroup.Count(),
                        Key .SubGroup = (
                        From item In manufacturerGroup
                        Group item By item.Year Into yearGroup = Group
                        Select yearGroup).
                        OrderBy(Function(iGroup) iGroup.FirstOrDefault().Year)})

            For Each manufacturerItem In query

                ' first show manufacturer and total count
                Console.WriteLine("{0} count:{1}", manufacturerItem.Manufacturer, manufacturerItem.Count)

                ' here is our group by year
                For Each yearItem In manufacturerItem.SubGroup
                    Console.WriteLine($"    {yearItem.FirstOrDefault().Year}")

                    ' display cars for specific year
                    For Each Vehicle In yearItem.OrderBy(Function(x) x.Model)
                        Console.WriteLine($"      {Vehicle.Model} {Vehicle.Retail:C} {Vehicle.Color}")
                    Next
                Next
            Next

        End Sub

    End Class
End Namespace