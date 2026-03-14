using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace MyRazorApp.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> CategoryList { get; set; } = new();

        // Razor Pages expects the handler to be named OnGet (capital G).
        // Provide defaults so the page shows items when no query parameters are supplied.
        public void OnGet(int skip = 0, int take = 20)
        {
            var temp = new List<Category>();
            for (var i = 0; i <= 1787; i++)
            {
                // add to temp, not directly to CategoryList
                temp.Add(new Category(i, $"Categoria{i}", i * 18.95M));
            }

            CategoryList = temp.Skip(skip).Take(take).ToList();
        }

        // Correct handler name casing
        public void OnPost()
        {
        }
    }
}

public record Category(int Id, string Title, decimal Price);
