namespace _03.Orders
{
    internal class Program
    {
        public class Products
        {
            public Products(string name,decimal price,int quantity )
            {
                Name = name;
                Price = price;
                Quantity = quantity;
            }

          
            public string Name { get; set; }        
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public decimal TotalPrice=>Price*Quantity;
            
            public void Update(decimal price, int quantity)
            { 
                Price = price;
                Quantity += quantity;
            }
            public override string ToString() 
            {
                return $"{Name} -> {TotalPrice:f2}";
            }
        }
        static void Main(string[] args)
        {
            var productsCollection=new Dictionary<string, Products>();

            string input = "";
            while ((input=Console.ReadLine())!= "buy")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                decimal price = decimal.Parse(tokens[1]);
                int quantity = int.Parse(tokens[2]);

                Products product = new Products(name,price,quantity); 

                if(!productsCollection.ContainsKey(product.Name)) 
                { 
                productsCollection.Add(name, product);
                }

                else
                {
                    productsCollection[product.Name].Update(price,quantity);
                }
            }
            foreach (var kvp in productsCollection)
            { Console.WriteLine(kvp.Value); }
        }
    }
}/*
Beer 2.20 100
IceTea 1.50 50
NukaCola 3.30 80
Water 1.00 500
buy

Beer 2.40 350
Water 1.25 200
IceTea 5.20 100
Beer 1.20 200
IceTea 0.50 120
buy

  */