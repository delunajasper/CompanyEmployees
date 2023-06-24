using System;
using System.Collections.Generic;
using CompanyEmployees.Contracts;
using CompanyEmployees.Entities;

namespace Service;

internal sealed class CompanyService : ICompanyService
{
    private readonly IRepositoryManager _repository;
    private readonly IloggerManager _logger;

    public CompanyService(IRepositoryManager repository, IloggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IEnumerable<Company> GetAllCompanies(bool trackChanges)
    {
        try
        {
            return _repository.Company.GetAllCompanies(trackChanges);
        }
        catch (Exception e)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllCompanies)} service method {e}");
            throw;
        }
    }
}