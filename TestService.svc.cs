﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TestWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "TestService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select TestService.svc or TestService.svc.cs at the Solution Explorer and start debugging.
    public class TestService : ITestService
    {
        public void DoWork()
        {
            throw new NotImplementedException();
        }

        public string Welcome(string name)
        {
            return "Welcome to the first WCF Web Service Application " + name;
        }
    }
}
