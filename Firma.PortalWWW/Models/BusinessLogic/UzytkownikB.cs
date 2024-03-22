namespace Firma.PortalWWW.Models.BusinessLogic
{
    public class UzytkownikB
    {
        private HttpContext httpContext;
        private string IdSesjiUzytkownika; 
        public UzytkownikB( HttpContext httpContext)
        {
            this.httpContext = httpContext;
        }
        private string getIdSesjiUzytkownika()
        {
            if (httpContext.Session.GetString("IdSesjiUzytkownika") == null)  // jeżeli nie mamy jeszcze sesji koszyka
            {
                if (!string.IsNullOrWhiteSpace(httpContext.User.Identity.Name))
                {
                    httpContext.Session.SetString("IdSesjiUzytkownika", httpContext.User.Identity.Name);
                }
                else
                {
                    Guid tempIdSesjiKoszyka = Guid.NewGuid();
                    httpContext.Session.SetString("IdSesjiUzytkownika", tempIdSesjiKoszyka.ToString());
                }
            }
            return httpContext.Session.GetString("IdSesjiUzytkownika").ToString();

        }
        public void SetIdSesjiUzytkowniak()
        {
            IdSesjiUzytkownika = getIdSesjiUzytkownika();
        }
        public string GetSesjaUzytkownika()
        {
            return IdSesjiUzytkownika;
        }
    }
}
