using DogGo.Models;
using DogGo.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DogGo.Controllers
{
    public class OwnersController : Controller
    {
        //impoement details & index methods
        private readonly IOwnerRepository _ownerRepository;

        public OwnersController(IOwnerRepository ownerRepository)
        {
            _ownerRepository = ownerRepository;
        }
        // GET: OwnersController
        public ActionResult Index()
        {
            List<Owner> owners = _ownerRepository.GetAllOwners();
            return View(owners);
        }

        // GET: OwnersController/Details/5
        public ActionResult Details(int id)
        {
            Owner owner = _ownerRepository.GetOwnerById(id);

            if (owner == null)
            {
                return NotFound();
            }

            return View(owner);
        }

        // GET: OwnersController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: OwnersController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OwnersController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: OwnersController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: OwnersController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: OwnersController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
