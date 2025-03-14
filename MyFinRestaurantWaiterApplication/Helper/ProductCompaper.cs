using MyFinCassa.Model;
using System.Collections.Generic;


namespace MyFinCassa.Helper
{
    public class ProductCompaper : IEqualityComparer<Product>
    {
        public bool Equals(Product x, Product y)
        {
            // Сравниваем два объекта Order по какому-то уникальному свойству, например Id.
            return x.prod_id == y.prod_id && x.prod_status == y.prod_status && x.prod_total == y.prod_total;
        }

        public int GetHashCode(Product obj)
        {
            return obj.prod_id.GetHashCode() ^ obj.prod_status.GetHashCode() ^ obj.prod_total.GetHashCode();
        }
    }
}
