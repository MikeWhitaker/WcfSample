using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace SaleClassLibrary
{
  [ServiceContract]
  interface ISaleService
  {
    [OperationContract]
    bool TestConnection();

    [OperationContract]
    bool InsertCustomer(Customer obj);

    [OperationContract]
    List<Customer> GetAllCustomer();


    [OperationContract]
    bool DeleteCustomer(int Cid);


    [OperationContract]
    bool UpdateCustomer(Customer obj);

  }


}
