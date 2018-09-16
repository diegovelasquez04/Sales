namespace Sales.ViewModels
{
    using Common.Models;
    public class EditProductViewModel
    {
        #region Atributes
        private Product product;
        #endregion

        #region Constructors
        public EditProductViewModel(Product product)
        {
            this.product = product;
        } 
        #endregion
    }
}
