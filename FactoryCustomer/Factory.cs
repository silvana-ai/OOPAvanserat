using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BusinessLayer;
using Microsoft.Practices.Unity;
using InterfaceCustomer;
using ValidationAlgorithms;
using InterfaceDal;
namespace FactoryCustomer
{
    public static class Factory<AnyType> // Design pattern :- Simple factory pattern
    {
        private static IUnityContainer ObjectsofOurProjects = null;
            
        
        public static AnyType Create(string Type)
        {
            // Design pattern :- Lazy loading. Eager loading
            if (ObjectsofOurProjects == null)
            {
                ObjectsofOurProjects = new UnityContainer();

                IValidation<ICustomer> custValidation = new PhoneValidation(
                                                        new CustomerBasicValidation());
                ObjectsofOurProjects.RegisterType<CustomerBase, Customer>
                                    ("Admin"
                                    , new InjectionConstructor(
                                        custValidation,"Admin"));
                custValidation = new CustomerBasicValidation();
                ObjectsofOurProjects.RegisterType<CustomerBase, Customer>
                                    ("SelfService"
                                    , new InjectionConstructor(
                                        custValidation, "SelfService"));
                custValidation = new CustomerAddressValidation(
                                    new CustomerBasicValidation());
                ObjectsofOurProjects.RegisterType<CustomerBase, Customer>
                                    ("HomeDelivery"
                                    , new InjectionConstructor(
                                        custValidation, "HomeDelivery"));
                custValidation = new PhoneValidation(
                                  new CustomerBillValidation(
                                  new CustomerAddressValidation(
                                    new CustomerBasicValidation())));
                ObjectsofOurProjects.RegisterType<CustomerBase, Customer>
                                    ("Customer"
                                    , new InjectionConstructor(
                                        custValidation, "Customer"));
                
                
               
            }
            //Design pattern :-  RIP Replace If with Poly
            return ObjectsofOurProjects.Resolve<AnyType>(Type); 
        }
    }
}
