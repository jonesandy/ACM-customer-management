namespace ACM.BusinessLayer
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public Product(string name)
        {
            Name = name;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }
    }
}
