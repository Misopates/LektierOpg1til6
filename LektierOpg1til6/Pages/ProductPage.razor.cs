using LektierOpg1til6.Models;
using Microsoft.AspNetCore.Components.Forms;  
namespace LektierOpg1til6.Pages
{
    public partial class ProductPage
    {
        private Product ProductModel = new Product();
        private EditContext EditContext;

        protected override void OnInitialized()
        {
            EditContext = new EditContext(ProductModel);
        }

        private void HandleValidSubmit()
        {
            Console.WriteLine("HandleValidSubmit Called...");

            ProductModel = new Product();
            EditContext = new EditContext(ProductModel);
        }

        private void HandleInvalidSubmit()
        {
            Console.WriteLine("HandleInvalidSubmit Called...");
        }


    }
}
