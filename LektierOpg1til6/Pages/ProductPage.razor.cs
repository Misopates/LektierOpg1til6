using LektierOpg1til6.Models;
using Microsoft.AspNetCore.Components.Forms;
namespace LektierOpg1til6.Pages
{
    public partial class ProductPage
    {
        // Objektet som formularen binder til. Indeholder input fra brugeren.
        private Product ProductModel = new Product();

        // EditContext bruges af Blazor til at holde styr på formularens state og validering
        private EditContext EditContext;

        // Tekst til at vise statusbeskeder, fx succes eller fejl
        private string? StatusMessage;

        // CSS-klasse til statusbeskeden (info, success, error osv.)
        private string AlertClass = "alert info";

        // Liste af produkter, som er tilføjet via formularen
        private List<Product> Products = new List<Product>();

        // Array af mulige produkttyper til dropdown-menuen
        private string[] ProductTypes = { "Glas", "Metal", "Plastik", "Træ" };


        // Metode, der køres når komponenten initialiseres
        protected override void OnInitialized()
        {
            // ikke med taget da jeg har
            // "-- Vælg produkttype --"
            // som auto første valgmulighed
            //ProductModel = new Product
            //{
            //    ProductType = ProductTypes[0]  // <-- første element som default
            //};

            // Initialiser EditContext med den nuværende ProductModel
            EditContext = new EditContext(ProductModel);
        }

        // Metode der kaldes når formularen valideres korrekt
        private void HandleValidSubmit()
        {
            // Tilføj det nye produkt til listen, inklusive alle properties
            StatusMessage = "Product saved successfully!"; // Statusbesked til brugeren


            Products.Add(new Product
            {
                Name = ProductModel.Name,
                Price = ProductModel.Price,
                PublishedDate = ProductModel.PublishedDate,
                Description = ProductModel.Description,
                IsPublished = ProductModel.IsPublished,
                ProductType = ProductModel.ProductType
            });

            // Nulstil formularen og EditContext, så der kan tilføje et nyt produkt
            ProductModel = new Product();
            EditContext = new EditContext(ProductModel);
        }

        // Metode der kaldes, hvis formularen ikke er valid
        private void HandleInvalidSubmit()
        {
            StatusMessage = "There are some validation errors. Please try again.";
            AlertClass = "alert error";// Sæt alert-style til fejl
        }

        // Metode til at rydde hele produktlisten
        private void ClearProducts()
        {
            Products.Clear();
            StatusMessage = "Produktlisten er ryddet."; // Vis besked til brugeren
            AlertClass = "alert-info"; // Info-stil til beskeden
        }
    }
}
