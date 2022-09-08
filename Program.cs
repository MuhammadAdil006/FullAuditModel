// See https://aka.ms/new-console-template for more information
Console.WriteLine("Change Tracking Demo");

var c = new ApplicationDbContext();

Item i = new Item { Name="IPhone6", 
                    Description="This is a mobile",
                    PurchasePrice=99M,
                    Quantity=20,
                    IsActive=true
                  };

                  c.Items.Add(i);

c.SaveChanges();

var item = c.Items.FirstOrDefault();
item.Name="Laptop";
c.SaveChanges();