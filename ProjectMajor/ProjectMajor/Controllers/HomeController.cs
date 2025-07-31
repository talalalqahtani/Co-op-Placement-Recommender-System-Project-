using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectMajor.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Security.Principal;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Net.Mail;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography.Xml;

namespace ProjectMajor.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProjectMajorDB _context;

        
        
            
        public HomeController(ILogger<HomeController> logger,ProjectMajorDB context)
        {
            _logger = logger;
            _context = context;
        }
      
        public IActionResult Index()
        {
            return View();
        }
    
        public IActionResult About()
        {
            return View();
        }
      
        public IActionResult Contact()
        {
            return View();
        }
        
        public IActionResult Report(IFormCollection form)
        {
            int x=form.Count;
            double total = 0;
            double prsent =0;
            double Count = 0;
            string Mid = form["mid"];
            string UserName = User.FindFirst(ClaimTypes.Name).Value; //Get USer Name
            var StuData=_context.Students.Where(x=>x.Email==UserName).FirstOrDefault(); // Get student data from the user
            int studentid = StuData.Id;
            int CollegeID = StuData.CollegeId;
            string CollegeName = _context.Colleges.Where(x => x.Id == CollegeID).FirstOrDefault().Name;
            string student = _context.Students.Where(x => x.Email == UserName).FirstOrDefault().Name;
            string MajoName = "";
            if (Mid != null)
            {
                //execute if this comes from Quiz

                 MajoName = _context.Majors.Where(x => x.Id == int.Parse(Mid)).FirstOrDefault().Name;

                //Calculate Score
                for (int i = 0; i < x; i++)
                {
                    string gg = form["op" + i.ToString()];
                    if (gg != null)
                    {
                        Count++;
                        total = total + double.Parse(form["op" + i.ToString()]);
                    }
                    int u = 0;
                }

                if (total > 0)
                {
                    prsent = (total / Count) * 100;
                }

                var data = new Report
                {
                    StudentId = studentid,
                    MajorChoosenId = int.Parse(Mid),
                    Result = total,
                    Recommendation = Count.ToString()

                };
                _context.Add(data);
                _context.SaveChanges(); //Save Results
            }

            var Reportdata = _context.Reports.Where(x => x.StudentId == studentid).ToList();
            int ReportdataCount = _context.Reports.Where(x => x.StudentId == studentid).Count();


            string Status = "";
            var PassData = new List<ReportsDTO>();

            for (int i = 0; i < ReportdataCount; i++)
            {
                double Pre =(double)((double)Reportdata[i].Result / (double)int.Parse(Reportdata[i].Recommendation))*100;
                if (Pre > 50)
                {
                    Status = "Pass";
                }
                else
                {
                    Status = "Fail";
                }
                MajoName = _context.Majors.Where(x => x.Id == Reportdata[i].MajorChoosenId).FirstOrDefault().Name;
                PassData.Add( new ReportsDTO
                {
                    StudentName=student,
                    CollegeName=CollegeName,
                    MajorChoosen=MajoName,
                     Result = Reportdata[i].Result,
                     Total = int.Parse(Reportdata[i].Recommendation),
                     Pre= Pre,
                     Status=Status
                });
            }

            return View(PassData);
        }

      
        /*   public IActionResult LogIn()
           {
               return View();
           }

           [HttpPost]
           public IActionResult LogIn(string email, string password)
           {
               var check = _context.Students.Where(Students => Students.Email == email && Students.Password == password).SingleOrDefault();
               var checkk = _context.Users.Where(Users => Users.Email == email && Users.Password == password).SingleOrDefault();
               if (check == null)
               {
                   ViewBag.ERROR = "INVALID STUDENT";
                 return View();
               }
               else 
               {
                   return RedirectToAction(nameof(Index));
               }
           */
       
        #region Login/Logout
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            try
            {
                string UserName =  User.FindFirst(ClaimTypes.Name).Value;
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }

        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Login(string email, string password)
        {
            try
            {
                var check = _context.Students.Where(Students => Students.Email == email && Students.Password == password).SingleOrDefault();
                var checkk = _context.Users.Include(R => R.Role).Where(Users => Users.Email == email && Users.Password == password).SingleOrDefault();
                if (check != null)
                {
                    var identity = new ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.Name, check.Email),
                    new Claim(ClaimTypes.Role, "Student"),
                    new Claim(ClaimTypes.NameIdentifier, check.Id.ToString()),
                    new Claim(ClaimTypes.GivenName, check.Name)

                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);


                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        principal);
                    if (principal.FindFirst(ClaimTypes.Role).Value == "Admin")
                    {
                        return RedirectToAction(nameof(Admin1));
                    }
                    else
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
                else if (checkk != null)
                {
                    var identity = new ClaimsIdentity(new[]
                   {
                    new Claim(ClaimTypes.Name, checkk.Email),
                    new Claim(ClaimTypes.Role, checkk.Role.Name),
                    new Claim(ClaimTypes.NameIdentifier, checkk.Id.ToString()),
                    new Claim(ClaimTypes.GivenName, checkk.Name)

                }, CookieAuthenticationDefaults.AuthenticationScheme);

                    var principal = new ClaimsPrincipal(identity);

                    await HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        principal);

                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    ViewBag.ERROR = "INVALID email or password";
                    
                    return View();
                }
              
            }
            catch
            {
                ViewBag.ERROR = "INVALID Email or Password"; 
                return View();
            }

        }

       
        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction(nameof(Login));
        }
        #endregion Login/Logout
       
        public IActionResult Quiz(int MajorId)
        {
            ViewBag.Majorid=MajorId;
            return View(_context.Questions.Where(Q => Q.MajorId == MajorId));
        }
   
        public IActionResult Admin1()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgetPass()
        {
            try
            {
                string UserName = User.FindFirst(ClaimTypes.Name).Value;
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }


        }

        [HttpPost]
        [AllowAnonymous]
        public IActionResult ForgetPass(string Email)
        {

            var emailCheck = _context.Students.Where(s => s.Email == Email).FirstOrDefault();
            // Get the email address to send the message to
            if (emailCheck == null)
            {
                ViewBag.email = "This email does not exist!";
                return View();
            }
            else
            {
                try
                {
                    //// Get the student's email
                    var emailTo = Email;

                    var mailMessage = new MailMessage
                    {
                        From = new MailAddress("cooptraning@gmail.com"),
                        Subject = "Thank you for your request",
                        Body = "Enter This link to change your password https://localhost:44329/Home/changePass/" + emailCheck.Id,
                        IsBodyHtml = false,
                    };

                    var MailClient = new SmtpClient("smtp.gmail.com", 587)
                    {

                        EnableSsl = true,

                        Credentials = new System.Net.NetworkCredential("cooptraning@gmail.com", "vsstbvnrhgmgshzs"),

                    };

                    mailMessage.To.Add(emailTo);
                    MailClient.Send(mailMessage);
                    ViewBag.succ = "Email sent succefully.";
                    return View();
                }
                catch
                {
                    // Handle the error
                    ViewBag.fail = "Failed to send email!";

                }
            }


            return View();

        }

        public IActionResult changePass(int? id)
        {


            if (id == null)
            {
                return NotFound();
            }

            var student = _context.Students.Include(x => x.College).Where(x => x.Id == id).FirstOrDefault();
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }   

            [HttpPost]
            [ValidateAntiForgeryToken]
            public async Task<IActionResult> changePass(int? id, string pass1, string pass2, [Bind("Id,Name,Email,UserName,Password,CollegeId")] Student student)
            {
                if (id == null)
                {
                    return NotFound();
                }

                if (pass1 == pass2)
                {
                    try
                    {
                        var pass = _context.Students.Include(x => x.College).Where(x => x.Id == id).FirstOrDefault();
                        _context.Attach(pass);
                        _context.Entry(pass).Property(x => x.Password).CurrentValue = (pass1);
                        await _context.SaveChangesAsync();
                        ViewBag.succ = "Your password has been changed succefully";
                        return View(student);
                    }
                    catch
                    {
                        ViewBag.fail = "Somthing went wrong!";
                        return View(student);
                    }
                }
                else
                {
                    ViewBag.wrong = "Passwords do not match! Please, enter the same password.";
                    return View(student);
                }



            }
        

        public IActionResult Form()
        {
            {
                ViewData["CollegeId"] = new SelectList(_context.Colleges, "Id", "Name");
                ViewData["MajorId"] = new SelectList(_context.Majors, "Id", "Name");
                return View();
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
