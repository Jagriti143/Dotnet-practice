using System;
using securityModule;
using System.Collections.Generic;
using System.Linq;
namespace PolicyData{
    class Indexer{
        private List<InsurancePolicy> policies=new List<InsurancePolicy>();

        public void AddPolicy(InsurancePolicy policy)
        {
            policies.Add(policy);
        }

        public InsurancePolicy this[int index]{
            get{return policies[index];}
        }
        public InsurancePolicy this[string name]{
            get{return policies.FirstOrDefault(p => p.holdername == name); }
        }

    }
}