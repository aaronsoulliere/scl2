using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lab1.Data;
using Lab1.Models;
using System.Data;
using Microsoft.AspNetCore.Authorization;

namespace Lab1.Controllers
{
    public class DealershipsController : Controller
    {
        public DealershipsController()
        {
        }

        // GET: Dealerships
        [Authorize(Roles = "Manager, Employee")]
        public async Task<IActionResult> Index()
        {
            return View(DealershipMgr.GetDealerships());
        }

        // GET: Dealerships/Details/5
        [Authorize(Roles = "Manager, Employee")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = DealershipMgr.GetDealership(id.Value);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // GET: Dealerships/Create
        [Authorize(Roles = "Manager, Employee")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dealerships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager, Employee")]
        public async Task<IActionResult> Create([Bind("ID,Name,Email,PhoneNumber")] Dealership dealership)
        {
            if (ModelState.IsValid && DealershipMgr.CreateDealership(dealership))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Dealerships/Edit/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = DealershipMgr.GetDealership(id.Value);
            if (dealership == null)
            {
                return NotFound();
            }
            return View(dealership);
        }

        // POST: Dealerships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Email,PhoneNumber")] Dealership dealership)
        {
            if (id != dealership.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid && DealershipMgr.UpdateDealership(dealership))
            {
                return RedirectToAction(nameof(Index));
            }
            return View(dealership);
        }

        // GET: Dealerships/Delete/5
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dealership = DealershipMgr.GetDealership(id.Value);
            if (dealership == null)
            {
                return NotFound();
            }

            return View(dealership);
        }

        // POST: Dealerships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Manager")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dealership = DealershipMgr.GetDealership(id);
            if (dealership == null)
            {
                return NotFound();
            }

            DealershipMgr.DeleteDealership(dealership);
            return RedirectToAction(nameof(Index));
        }
    }
}
