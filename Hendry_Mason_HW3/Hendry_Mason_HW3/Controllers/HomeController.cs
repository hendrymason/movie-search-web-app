using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Hendry_Mason_HW3.DAL;
using Hendry_Mason_HW3.Models;

namespace Hendry_Mason_HW3.Controllers
{
    public class HomeController : Controller
    {

        // CREATE A PRIVATE INSTANCE OF APPDB CONTEXT
        private AppDbContext _context;
        public HomeController(AppDbContext dbContext) { _context = dbContext; } // GET: /<controller>/

        public IActionResult Index(String SearchString)
        {
            //Query the database for specified searchstring from the quick search on the index
            var query = from s in _context.Shows select s;

            //check for null or empty values in the searchstring
            if (SearchString != null && SearchString != "")
            {
                //checks both titles and description for the aforementioned search string
                query = query.Where(s => s.Title.Contains(SearchString) ||
                                     s.Description.Contains(SearchString));
            }

            //// INTENDED FOR DISPLAYING X OF 275 ON THE DISPLAY SEARCH RESULTS VIEW
            // populate viewbag with all shows by counting every show in the show dataset
            ViewBag.AllShows = _context.Shows.Count();
            
            // populate the viewbag with all the selected shows underneath the category that it was just filtered for
            List<Show> SelectedShows = query.Include(s => s.Category).ToList();
            ViewBag.SelectedShows = SelectedShows.Count;
            
            return View(SelectedShows.OrderBy(s => s.Title));
        }

        public IActionResult Details (int? id) //id is the show id you want to see
        {
            if (id == null) // ShowID not specified
            {
                //user did not specify a ShowID – take them to the error view
                // You return the empty string list in order to prevent your method from crashing
                return View("Error", new String[] { "ShowID not specified - which show do you want to view?" });
            }

            //look up the show in the database based on the id; be sure to include the category
            //It must utilize the "Include" Statement in order to incorporate information from the category model
            Show show = _context.Shows.Include(s => s.Category).FirstOrDefault(s => s.ShowID == id);

            if (show == null) // No show with this ID exists in the Database
            {
                //there is not a show with this id in the database – show the user an error view
                // You return the empty string list in order to prevent your method from crashing
                return View("Error", new String[] { "Show not found in database" });
            }
            

            //if code gets this far, all is well – display the details
            return View(show);
        }

        //Create a function that wil generate all of the category options and store them into a list
        //This list will be used to populate the Viewbag and transfer alongside the controller's direction
        private SelectList ListCategories()
        {
            //Creates a new instance of the list
            //_context.categories.ToList() converts the 'Class'(Dataset) in the database into a list
            List<Category> categoryList = _context.Categories.ToList();

            //Creates a new, empty instance of a category object and adds a row to the dataset for display purposes
            //this row is stored with similar characteristics to that of a list
            Category SelectNone = new Category() { CategoryID = 0, CategoryName = "All Categories" };
            //Adds the prior dataset with the list of categories
            categoryList.Add(SelectNone);

            //convert the categoryList (list of categories with the new row) into a new a selectList
            //on the tail of the instance, it is ordered by "CategoryID" as m.CategoryID
            //it also calls the value CategoryID and the text, CategoryName, so as to display text and sort by Value
            SelectList categorySelectList = new SelectList(categoryList.OrderBy(m => m.CategoryID), "CategoryID", "CategoryName");

            //send list back to function call
            return categorySelectList;
        }

        //When the User Clicks the Detailed Search Button on the Index
        public IActionResult DetailedSearch()
        {
            //ViewBag calls the ListCategories function so as to store it in a Viewbag to be transferred to the view
            ViewBag.AllCategories = ListCategories();
            //Generate a new instance of the ViewModel that stores the temporary search data
            SearchViewModel svm = new SearchViewModel();

            //pass the ViewModel into the View to capture temporary data from the user
            return View(svm);
        }

        public IActionResult DisplaySearchResults(SearchViewModel svm)
        {
            //search the database for all shows and store them in a query
            var query = from s in _context.Shows select s;

            //FILTERING & RE-QUERYING
            //Check for null & empty values
            //then re-query for the user-specified SVM Title

            //DISPLAY TITLE
            if (svm.Title != null && svm.Title != "")
            { query = query.Where(s => s.Title.Contains(svm.Title)); }

            //DISPLAY CAST
            if (svm.Cast != null && svm.Cast != "")
            { query = query.Where(s => s.Cast.Contains(svm.Cast)); }

            //DISPLAY DATE ADDED
            if (svm.DateAdded != null)
            { query = query.Where(s => s.DateAdded >= svm.DateAdded); }

            //DISPLAY YEAR RELEASED
            //if mentioned, this filters for the before/after enum
            if (svm.YearReleased != null)
            {
                if (svm.SearchType == Typeof.Before)
                {
                    query = query.Where(s => s.ReleaseYear <= svm.YearReleased);
                }
                else
                {
                    query = query.Where(s => s.ReleaseYear >= svm.YearReleased);
                }
            }

            //DISPLAY CATEGORY
            if (svm.Category != 0)
            {
                Category CategoryPick = _context.Categories.Find(svm.Category);
                query = query.Where(s => s.Category.CategoryID == svm.Category);
            }

            //DISPLAY SEARCH RATING
            if (svm.searchRating != null)
            {
                query = query.Where(s => s.Rating.Equals(svm.searchRating));
            }

            //DISPLAY DESCRIPTION
            if (svm.Description != null && svm.Description != "")
            {
                query = query.Where(s => s.Description.Equals(svm.Description));
            }

            //CREATE LIST OF NEW SELECTED SHOWS FROM QUERY
            List<Show> SelectedShows = query.Include(s => s.Category).ToList();

            // POPULATE VIEWBAG WITH SHOW TOTAL
            ViewBag.AllShows = _context.Shows.Count();

            // POPULATE VIEWBAG WITH THE COUNT OF THE QUERIED SHOWS
            ViewBag.SelectedShows = SelectedShows.Count;

            //RETURN RESULTS IN THE INDEX
            return View("Index", SelectedShows.OrderBy(s => s.Title));
        }
    }
}
