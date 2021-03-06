//===============================================================================
// Microsoft patterns & practices
// Smart Client Software Factory 2010
//===============================================================================
// Copyright (c) Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================
// The example companies, organizations, products, domain names,
// e-mail addresses, logos, people, places, and events depicted
// herein are fictitious.  No association with any real company,
// organization, product, domain name, email address, logo, person,
// places, or events is intended or should be inferred.
//===============================================================================
using System;
using System.Data;

namespace GlobalBankServices
{
	public class CustomerFinderService : IBasicHttpBinding_ICustomerFinder
	{
		public string AddCustomer(Customer customer)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest customerToDelete)
		{
			throw new Exception("The method or operation is not implemented.");
		}

		public FindCustomerResponse FindCustomer(CustomerSearchCriteria searchCriteria)
		{
			GlobalBankDataServices db = new GlobalBankDataServices();
			DataSet dbResult = db.FindCustomer(searchCriteria);
			return db.CreateFindCustomerResponse(dbResult);
		}
	}
}

