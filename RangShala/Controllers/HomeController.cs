using System.Collections.Generic;
using System.Linq; // Add this line for LINQ
using System.Web.Mvc;

public class HomeController : Controller
{
    public ActionResult Search(string query)
    {
        // Perform search logic here. For simplicity, we'll assume a list of items to search through.
        var allItems = new List<string>
        {
            "Acrylic Painting", "Oil Painting", "Drawings", "Artist", "Anime", "Mandala Art"
        };

        // Filter the items based on the query (case-insensitive)
        var filteredItems = allItems.Where(item => item.ToLower().Contains(query.ToLower())).ToList();

        // Pass the search results to the view
        ViewBag.SearchResults = filteredItems;
        ViewBag.Query = query;

        return View();
    }

    public ActionResult Index()
    {
        return View();
    }

    public ActionResult About()
    {
        ViewBag.Title = "About Us";
        return View("Index"); // This will load the same view as your home page.
    }

    public ActionResult Artwork()
    {
        return View();
    }

    public ActionResult Artist()
    {
        return View();
    }

    public ActionResult Bespoke()
    {
        return View();
    }

    public ActionResult Join()
    {
        return View();
    }

    public ActionResult Consult()
    {
        return View();
    }
    public ActionResult AcrylicPaintings()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult Drawings()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult MandalaArt()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult Anime()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult OilPainting()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult ArtworkGallery()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult LoginRegister()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult BeSpokeservice()
    {
        // You can fetch painting data dynamically from a database here.
        return View();
    }
    public ActionResult Ayushi()
    {
        return View();
    }
    public ActionResult Niyati()
    {
        return View();
    }
    
}
