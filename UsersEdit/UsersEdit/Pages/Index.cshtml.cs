using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc;
using UsersEdit.Data;

namespace UsersEdit.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        UserManager<ApplicationUser> _userManager;        
        public IEnumerable<ApplicationUser> users;
        public string idUser;
        public IndexModel(ILogger<IndexModel> logger, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _userManager = userManager;
        }

        public void OnGet()
        {
            users = _userManager.Users.AsEnumerable();
            idUser = _userManager.GetUserId(User);
        }
        public RedirectToPageResult OnPostDeleteUser(string Id) 
        {
            var user = _userManager.FindByIdAsync(Id).Result;
            _userManager.DeleteAsync(user);
            _userManager.UpdateAsync(user);
            return RedirectToPage();
        }
    }
}