using Firma.Data.Models;
using Firma.PortalWWW.Models.BusinessLogic;
using Firma.PortalWWW.Models.Koszyk;
using Microsoft.AspNetCore.Mvc;
using iTextSharp.text;
using iTextSharp.text.pdf;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using iTextSharp.text.pdf.draw;

namespace Firma.PortalWWW.Controllers
{
    public class UzytkownikController : Controller
    {
        private readonly TeaShopContext _context;
        public UzytkownikController(TeaShopContext context)
        {
            _context = context;
        }
        public IActionResult Index(LogowanieModel daneLogowania)
        {
            LogowanieModel model = new LogowanieModel();
            model.Login = daneLogowania.Login;
            return View(model);
        }
        public async Task<IActionResult> Logowanie(LogowanieModel model)
        {
            UzytkownikB uzytkownik = new UzytkownikB(this.HttpContext);
            var SesjaUzytkownika = uzytkownik.GetSesjaUzytkownika();
            if (SesjaUzytkownika != null)
            {
                return RedirectToAction("Index", "Uzytkownik");
            }
            if (model.Blad == null) return View();
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LogowanieModel loginData)
        {
            UzytkownikB uzytkownik = new UzytkownikB(this.HttpContext);
            uzytkownik.SetIdSesjiUzytkowniak();

            bool isExists = _context.DaneLogowania.Any(x => x.NazwaUzytkownika == loginData.Login);
            if (!isExists)
            {
                loginData.Blad = "Konto nie istnieje. Zarejestruj się";

                return View("Logowanie", loginData);
            }

            var loginResult = _context.DaneLogowania
                .Where(x => x.NazwaUzytkownika == loginData.Login && x.HasloUzytkownika == loginData.Haslo).FirstOrDefault();
            if (loginResult == null)
            {
                loginData.Blad = "Hasło, które wprowadziłeś, jest nieprawidłowe. Upewnij się, że używasz prawidłowego hasła.";
                return View("Logowanie", loginData);
            }
            return View("Index", loginData);
        }

        public async Task<IActionResult> Rejestracja(LogowanieModel model)
        {
            if (model.Blad == null) return View();
            return View(model);

        }

        [HttpPost]
        public async Task<IActionResult> Zarejestruj(LogowanieModel loginData)
        {
            if (string.IsNullOrWhiteSpace(loginData.Login))
            {
                loginData.Blad = "Proszę podać login.";
                return View("Rejestracja", loginData);
            }

            if (string.IsNullOrWhiteSpace(loginData.Haslo))
            {
                loginData.Blad = "Proszę podać hasło.";
                return View("Rejestracja", loginData);
            }

            bool isExists = _context.DaneLogowania.Any(x => x.NazwaUzytkownika == loginData.Login);
            if (isExists)
            {
                loginData.Blad = "Ten login jest już zajęty. Proszę wybrać inny login.";
                return View("Rejestracja", loginData);
            }

            DaneLogowania nowyUzytkownik = new DaneLogowania()
            {
                CzyAktywny = true,
                DataUtworzenia = DateTime.Now,
                HasloUzytkownika = loginData.Haslo,
                NazwaUzytkownika = loginData.Login,
            };
            _context.Add(nowyUzytkownik);
            _context.SaveChanges();
            TempData["KontoUtworzone"] = "Twoje konto zostało utworzone.";
            return RedirectToAction("Logowanie", "Uzytkownik");
        }
        public async Task<IActionResult> ZmienHaslo(LogowanieModel model)
        {
            var Uzytkownik = _context.DaneLogowania.Where(x => x.NazwaUzytkownika == model.Login).FirstOrDefault();
            Uzytkownik.HasloUzytkownika = model.Haslo;
            _context.Update(Uzytkownik);
            _context.SaveChanges();
            TempData["ZmianaHasla"] = "Hasło zostało zmienione.";
            return View("Index", model);
        }
        public async Task<IActionResult> UsunKonto(LogowanieModel model)
        {
            var Uzytkownik = _context.DaneLogowania.Where(x => x.NazwaUzytkownika == model.Login).FirstOrDefault();
            _context.Remove(Uzytkownik);
            _context.SaveChanges();
            TempData["UsunKonto"] = "Konto zostało usunięte.";
            return RedirectToAction("Index", "Home");
        }
        //RAPORT PDF(iTextSharp)
        [HttpPost]
        public IActionResult PDF(LogowanieModel model)
        {
            var Uzytkownik = _context.DaneLogowania.FirstOrDefault(x => x.NazwaUzytkownika == model.Login);

            using (MemoryStream ms = new MemoryStream())
            {
                Document document = new Document(PageSize.A4, 25, 25, 30, 30);
                PdfWriter writer = PdfWriter.GetInstance(document, ms);
                document.Open();
                //polskie znaki
                BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1250, BaseFont.EMBEDDED);
                Font font = new Font(baseFont, 15);
                //tworzy paragrafy
                Paragraph para1 = new Paragraph("Raport danych użytkownika:", font);
                para1.Alignment = Element.ALIGN_CENTER;
                document.Add(para1);
                //linia -------
                Paragraph spacingLine = new Paragraph(new Chunk(new LineSeparator(1, 100, BaseColor.BLACK, Element.ALIGN_CENTER, -1)));
                document.Add(spacingLine);

                Paragraph para2 = new Paragraph("Nazwa użytkownika: " + Uzytkownik.NazwaUzytkownika, font);
                para2.Alignment = Element.ALIGN_CENTER;
                document.Add(para2);

                Paragraph para3 = new Paragraph("Data utworzenia: " + Uzytkownik.DataUtworzenia, font);
                para3.Alignment = Element.ALIGN_CENTER;
                document.Add(para3);

                Paragraph para4 = new Paragraph("ID: " + Uzytkownik.IdDaneLogowania, font);
                para4.Alignment = Element.ALIGN_CENTER;
                document.Add(para4);

                document.Close();
                writer.Close();

                var constant = ms.ToArray();
                return File(constant, "application/pdf", "Raport.pdf");
            }
        }
        //RAPORT EXL (EPPlus)
        [HttpPost]
        public IActionResult Excel(LogowanieModel model)
        {
            var Uzytkownik = _context.DaneLogowania.FirstOrDefault(x => x.NazwaUzytkownika == model.Login);

            using (MemoryStream ms = new MemoryStream())
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                using (ExcelPackage package = new ExcelPackage(ms))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Raport");
                    //do komórki przypisuje wartosc i stylizacje
                    worksheet.Cells["A1"].Value = "Raport danych użytkownika";
                    worksheet.Cells["A1"].Style.Font.Size = 20;
                    worksheet.Cells["A1"].Style.Font.Bold = true;
                    worksheet.Cells["A1"].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    worksheet.Cells["A1:C1"].Merge = true;

                    worksheet.Cells["A2"].Value = "Nazwa użytkownika:";
                    worksheet.Cells["B2"].Value = Uzytkownik.NazwaUzytkownika;
                    worksheet.Cells["A3"].Value = "Data utworzenia:";
                    worksheet.Cells["B3"].Value = Uzytkownik.DataUtworzenia.ToString(); // Formatuj datę
                    worksheet.Cells["A4"].Value = "ID:";
                    worksheet.Cells["B4"].Value = Uzytkownik.IdDaneLogowania;
                    // Dodaj dodatkowe style lub formatowanie w miarę potrzeb
                    worksheet.Cells["A1:C1"].Style.Border.BorderAround(ExcelBorderStyle.Thin);
                    worksheet.Cells["A2:A4"].Style.Font.Bold = true;

                    package.Save();
                }
                ms.Seek(0, SeekOrigin.Begin);
                var content = ms.ToArray();
                return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "Raport.xlsx");
            }
        }
    }
}