using System.Collections.Generic;
using CompanyEmployees.Entities;

namespace Service;

public interface ICompanyService
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}