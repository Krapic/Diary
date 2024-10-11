using DiaryApp.Data;
using DiaryApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryApp.Controllers
{
    public class DiaryEntriesController : Controller
    {
        private readonly ApplicationDbContext _db; // Ovo je privatno polje koje koristimo za pristup bazi podataka u kontroleru (ApplicationDbContext je klasa koja predstavlja bazu podataka) 

        public DiaryEntriesController(ApplicationDbContext db) { // Ovo nam omogućava da pristupimo bazi podataka u kontroleru
            _db = db; // Postavljamo privatno polje na vrijednost koju smo dobili kao argument konstruktora (db) 
        }

        public IActionResult Index() {
            List<DiaryEntry> objDiaryEntryList = _db.DiaryEntries.ToList(); // Dohvaćamo sve unose iz baze podataka i pretvaramo ih u listu (ToList() metoda)
            return View(objDiaryEntryList);
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DiaryEntry obj) // Ova metoda se poziva kada se podaci pošalju sa forme, a argumenti su podaci koje smo dobili sa forme (DiaryEntry obj) iz Create.cshtml
        {
            if (obj != null && obj.Title.Length < 3) {
                ModelState.AddModelError("Title", "The title is too short!");
            }

            if (ModelState.IsValid) {
                _db.DiaryEntries.Add(obj); // Dodajemo objekt u bazu podataka 
                _db.SaveChanges(); // Spremamo promjene u bazi podataka
                return RedirectToAction("Index"); // Redirektamo korisnika na Index akciju
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Edit(int? id) {
            if (id == null || id == 0) {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null) {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Edit(DiaryEntry obj)
        {
            if (obj != null && obj.Title.Length < 3)
            {
                ModelState.AddModelError("Title", "The title is too short!");
            }

            if (ModelState.IsValid)
            {
                _db.DiaryEntries.Update(obj); // Ažuriramo objekt u bazi podataka 
                _db.SaveChanges(); // Spremamo promjene u bazi podataka
                return RedirectToAction("Index"); // Redirektamo korisnika na Index akciju
            }

            return View(obj);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            DiaryEntry? diaryEntry = _db.DiaryEntries.Find(id);

            if (diaryEntry == null)
            {
                return NotFound();
            }

            return View(diaryEntry);
        }

        [HttpPost]
        public IActionResult Delete(DiaryEntry obj)
        {
            _db.DiaryEntries.Remove(obj); // Brišemo objekt u bazi podataka 
            _db.SaveChanges(); // Spremamo promjene u bazi podataka
            return RedirectToAction("Index"); // Redirektamo korisnika na Index akciju
        }
    }
}
