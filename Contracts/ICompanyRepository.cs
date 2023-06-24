using System.Collections.Generic;
using CompanyEmployees.Entities;

namespace CompanyEmployees.Contracts;

public interface ICompanyRepository
{
    IEnumerable<Company> GetAllCompanies(bool trackChanges);
}