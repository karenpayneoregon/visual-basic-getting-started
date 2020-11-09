
Imports EntityFrameworkCoreNorthWind.Classes
Imports EntityFrameworkCoreNorthWind.Models
Imports Microsoft.EntityFrameworkCore
Imports Microsoft.Extensions.Logging

Namespace Contexts
    Partial Public Class CustomerContext
        Inherits DbContext

        Private _connectionString As String
        ''' <summary>
        ''' Get database connection string from app.config
        ''' </summary>
        Public Sub New()
            Dim configurationHelper = New ConfigurationHelper
            _connectionString = configurationHelper.ConnectionString
        End Sub

        Public Sub New(options As DbContextOptions(Of CustomerContext))
            MyBase.New(options)
        End Sub

        Public Overridable Property Customers() As DbSet(Of Customers)
        ''' <summary>
        ''' Connection string is obtained from app.config
        ''' Logging is only enabled with the Visual Studio debugger
        ''' </summary>
        ''' <param name="optionsBuilder"></param>
        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)

#If DEBUG Then
            If Not optionsBuilder.IsConfigured Then
                optionsBuilder.
                    UseSqlServer(_connectionString).
                    UseLoggerFactory(ConsoleLoggerFactory).
                    EnableSensitiveDataLogging()
            End If
#Else
            If Not optionsBuilder.IsConfigured Then
                optionsBuilder.UseSqlServer(ConnectionString)
            End If
#End If
        End Sub
        ''' <summary>
        ''' Configure logging for app
        ''' https://docs.microsoft.com/en-us/ef/core/miscellaneous/logging?tabs=v3
        ''' https://github.com/dotnet/EntityFramework.Docs/blob/master/entity-framework/core/miscellaneous/logging.md
        ''' </summary>
        Public Shared ReadOnly ConsoleLoggerFactory As ILoggerFactory = LoggerFactory.
            Create(Function(builder) As ILoggerFactory
                       builder.AddFilter(
                           Function(category, level)

                               Return category = DbLoggerCategory.Database.Command.Name AndAlso
                                      level = LogLevel.Information

                           End Function)

                       builder.AddConsole()

                       Return Nothing

                   End Function)
        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)

            modelBuilder.Entity(Of Customers)(
                Sub(entity)

                    entity.HasKey(Function(customer) customer.CustomerIdentifier).
                                                 HasName("PK_Customers_1")

                    entity.Property(Function(customer) customer.ModifiedDate).
                                                 HasDefaultValueSql("(getdate())")

                    entity.HasOne(Function(customer) customer.Contact).
                                                 WithMany(Function(contacts) contacts.Customers).
                                                 HasForeignKey(Function(customer) customer.ContactId).
                                                 HasConstraintName("FK_Customers_Contacts")

                    entity.HasOne(Function(customer) customer.ContactTypeNavigation).
                                                 WithMany(Function(contactType) contactType.Customers).
                                                 HasForeignKey(Function(customer) customer.ContactTypeIdentifier).
                                                 HasConstraintName("FK_Customers_ContactType")

                    entity.HasOne(Function(customer) customer.CountryIdentifierNavigation).
                                                 WithMany(Function(countries) countries.Customers).
                                                 HasForeignKey(Function(customer) customer.CountryIdentifier).
                                                 HasConstraintName("FK_Customers_Countries")
                End Sub)

            OnModelCreatingPartial(modelBuilder)

        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace