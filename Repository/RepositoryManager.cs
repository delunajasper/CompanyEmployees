using System;
using CompanyEmployees.Contracts;

namespace Repository;

public class RepositoryManager : IRepositoryManager
{
 private readonly RepositoryContext _repositoryContext;
 private Lazy<ICompanyRepository> _companyRepository;
 private Lazy<IEmployeeRepository> _employeeRepository;

 /// <summary>
 /// Leveraged Lazy class to ensure lazy initialization of repos.
 /// Repo instances are only created when accessed for the first time.
 /// </summary>
 /// <param name="repositoryContext"></param>
 public RepositoryManager(RepositoryContext repositoryContext)
 {
  _repositoryContext = repositoryContext;
  _companyRepository = new Lazy<ICompanyRepository>(() => new CompanyRepository(repositoryContext));
  _employeeRepository = new Lazy<IEmployeeRepository>(() => new EmployeeRepository(repositoryContext));
 }

 public ICompanyRepository Company => _companyRepository.Value;
 public IEmployeeRepository Employee => _employeeRepository.Value;

 public void Save() => _repositoryContext.SaveChanges();

}