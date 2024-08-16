using BusinessLogicLayer.Models;
using DataContext.Data;
using DataContext.TableEntities;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_NP_PracticeCMS.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("Candidate/Submit")]
        public async Task<IActionResult> Submit([FromBody] CandidateVM model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    using (ApplicationDbContext db = new ApplicationDbContext())
                    {
                        Candidate candidate = new Candidate
                        {
                            CandidateId = model.CandidateId,
                            FirstName = model.FirstName,
                            LastName = model.LastName,
                            Email = model.Email,
                            PhoneNumber = model.PhoneNumber,
                            Gender = model.Gender,
                            Address = model.Address,
                            Resumefile = model.Resumefile,
                            AppliedPosition = model.AppliedPosition,
                            Skills = model.Skills,
                            CurrentLocation = model.CurrentLocation,
                            PreferedLocation = model.PreferedLocation,
                            CurrentCtc = model.CurrentCtc,
                            ExpectedCtc = model.ExpectedCtc,
                            References = model.References,
                            ReferencesEmpId = model.ReferencesEmpId,
                            LinkedInLink = model.LinkedInLink,
                            RegistrationDate = DateOnly.FromDateTime(DateTime.Now), 

                        };
                        db.Candidates.Add(candidate);
                        int cnt = await db.SaveChangesAsync();

                        if (cnt > 0)
                        {
                            CandidatesDetail candidatesDetail = new CandidatesDetail
                            {
                                PreviousEmp = model.PreviousEmp,
                                FromDate = DateOnly.FromDateTime((DateTime)model.FromDate),
                                ToDate = DateOnly.FromDateTime((DateTime)model.ToDate),
                                Education = model.Education,
                                EduFromDate = DateOnly.FromDateTime((DateTime)model.EduFromDate),
                                EduToDate = DateOnly.FromDateTime((DateTime)model.EduToDate)
                            };

                            db.Candidates.Add(candidate);
                            int cnt1 = await db.SaveChangesAsync();
                            if (cnt > 0)
                            {
                                return Json(new { success = true, message = "Candidate information submitted successfully!" });
                            }
                            else
                            {
                                return Json(new { success = false, message = "Candidate information submission failed!" });
                            }

                        }
                        else
                        {
                            return Json(new { success = false, message = "Candidate information submission failed!" });
                        }

                    }

                    
                }
                catch (Exception ex)
                {
                    return Json(new { success = false, message = $"An error occurred: {ex.Message}" });
                }
            }
            else
            {
                return Json(new { success = false, message = "Validation failed.", errors = ModelState.Values });
            }
        }
    }
}
