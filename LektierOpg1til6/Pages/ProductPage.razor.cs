using LektierOpg1til6.Models;
using Microsoft.AspNetCore.Components.Forms;
namespace LektierOpg1til6.Pages
{
    public partial class ProductPage
    {
        private Product ProductModel = new Product();
        private EditContext EditContext;
        private string? StatusMessage;
        private string AlertClass = "alert info";
        
        private List<Product> Products = new List<Product>();

        protected override void OnInitialized()
        {
            EditContext = new EditContext(ProductModel);
        }

        private void HandleValidSubmit()
        {
           StatusMessage = "Product saved successfully!";
            
            Products.Add(new Product
            {
                Name = ProductModel.Name,
                Price = ProductModel.Price,
                PublishedDate = ProductModel.PublishedDate,
                Description = ProductModel.Description,
                IsPublished = ProductModel.IsPublished
            });

            //Nulstil model og EditContext
            ProductModel = new Product();
            EditContext = new EditContext(ProductModel);
        }

        private void HandleInvalidSubmit()
        {
            StatusMessage = "There are some validation errors. Please try again.";
            AlertClass = "alert error";
        }
        private void ClearProducts()
        {
            Products.Clear();
            StatusMessage = "Produktlisten er ryddet.";
            AlertClass = "alert-info";
        }
    }
}
