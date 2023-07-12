namespace AgileShop.Domain.Exceptions.Companies;

public class CompanyNotFoundException : NotFoundException
{
    public CompanyNotFoundException()
    {
        TitleMessage = "Company Not Found!";
    }
}
