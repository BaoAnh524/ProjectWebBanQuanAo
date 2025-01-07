namespace ProjectBanQuanAo.Models
{
    public class CartItem
    {
        public long id { get; set; }
        public string ProductName { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
        public string Image { get; set; }
        public decimal total
        {
            get { return quantity * price; }
        }
        public CartItem()
        {

        }
        public CartItem(Product product)
        {
           id = product.id;
            ProductName = product.name;
            price = product.Price;
            quantity = 1;   
            Image = product.fileNameImg;
        }
    }
}
