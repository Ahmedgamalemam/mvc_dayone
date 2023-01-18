using Microsoft.AspNetCore.Mvc;
using mvc_dayone.models;

namespace mvc_dayone.controllers
{
    public class partyController : Controller
    {
        public IActionResult allfriend()
        {
            var p = party.Member.Where(x => x.willattend == "yes").ToList();
            return View("homepage", p);
        }


        public IActionResult addfriend()
        {
            return View("form");
        }
        public IActionResult adddata(members members)
        {
            party.addmembers(members);
            List<members> p = party.Member.Where(x => x.willattend == "yes").ToList();
            if (p != null)
            {
                return View("validation");
            }
            else
            {
                return Content("see you later");
            }

        }
        public IActionResult showfriend()
        {
            return View("memberscoming");
        }
    }
}
