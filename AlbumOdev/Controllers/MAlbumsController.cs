using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlbumOdev.Data;
using AlbumOdev.Models;

namespace AlbumOdev.Controllers
{
    public class MAlbumsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MAlbumsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MAlbums
        public async Task<IActionResult> Index()
        {
            return View(await _context.Album.ToListAsync());
        }

        // GET: MAlbums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mAlbum = await _context.Album
                .FirstOrDefaultAsync(m => m.AlbumID == id);
            if (mAlbum == null)
            {
                return NotFound();
            }

            return View(mAlbum);
        }

        // GET: MAlbums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MAlbums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlbumID,AlbumNo,AlbumTur,SanatciBilgi,AlbumAdi,AlbumFiyat,Yerli")] MAlbum mAlbum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mAlbum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mAlbum);
        }

        // GET: MAlbums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mAlbum = await _context.Album.FindAsync(id);
            if (mAlbum == null)
            {
                return NotFound();
            }
            return View(mAlbum);
        }

        // POST: MAlbums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlbumID,AlbumNo,AlbumTur,SanatciBilgi,AlbumAdi,AlbumFiyat,Yerli")] MAlbum mAlbum)
        {
            if (id != mAlbum.AlbumID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mAlbum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MAlbumExists(mAlbum.AlbumID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(mAlbum);
        }

        // GET: MAlbums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mAlbum = await _context.Album
                .FirstOrDefaultAsync(m => m.AlbumID == id);
            if (mAlbum == null)
            {
                return NotFound();
            }

            return View(mAlbum);
        }

        // POST: MAlbums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mAlbum = await _context.Album.FindAsync(id);
            if (mAlbum != null)
            {
                _context.Album.Remove(mAlbum);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MAlbumExists(int id)
        {
            return _context.Album.Any(e => e.AlbumID == id);
        }
    }
}
