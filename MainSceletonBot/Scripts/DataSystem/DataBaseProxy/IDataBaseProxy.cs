﻿using MainSceletonBot.Scripts.DataSystem.Model;

namespace MainSceletonBot.Scripts.DataSystem.DataBaseProxy
{
  public interface IDataBaseProxy
  {
    Task<Customer> GetCustomerByIDAsync(string _ID, CancellationToken _cancellationToken);
    Task<Customer> GetCustomerByNameAsync(string _Name, CancellationToken _cancellationToken);
    Task WriteNewCostomerAsync(Customer _customer, CancellationToken _cancellationToken);
    Task UpdateCustomerAsync(string _ID, Customer _customer, CancellationToken _cancellationToken);
    Task DeleteCustomerAsync(Customer _customer, CancellationToken _cancellationToken);

    Task AddCustomerTaskAsync(CustomerTask _customerTask, CancellationToken _cancellationToken);
    Task<CustomerTask> GetCustomerTaskByIDAsync(string _ID, CancellationToken _cancellationToken);
    Task UpdateCustomerTaskAsync(string _ID, CustomerTask _customerTask, CancellationToken _cancellationToken);
    Task DeleteCustomerTaskAsync(CustomerTask _customerTask, CancellationToken _cancellationToken);

    Task AddWorkerAsync(Worker _worker, CancellationToken _cancellationToken);
    Task<Worker> GetWorkerByIdAsync(string _ID, CancellationToken _cancellationToken);
    Task UpdateWorkerAsync(string _ID, Worker _worker, CancellationToken _cancellationToken);
    Task DeleteWorkerAsync(Worker _worker, CancellationToken _cancellationToken);
    
    Task<uint> GetCustomerIDAsync(CancellationToken _cancellationToken);
    Task WriteCustomerIDAsync(uint lastID, CancellationToken _cancellationToken);

    Task<uint> GetCustomerTaskIDAsync(CancellationToken _cancellationToken);
    Task WriteCustomerTaskIDAsync(uint lastID, CancellationToken _cancellationToken);
    Task<uint> GetWorkerIDAsync(CancellationToken _cancellationToken);
    Task WriteWorkerIDAsync(uint lastID, CancellationToken _cancellationToken);
  }
}
