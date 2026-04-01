using OrderProcessingMembersBL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OrderProcessingMembersDL;


namespace OrderProcessingUtil
{


    public class RepositoryFactory
    {

        public static IRepository GeefRepository(string repoType, string connectionString)
        {
            switch (repoType)
            {
                case "ADO": return new SQLRepository(connectionString);
                case "Memory": return new MemoryRepository();
                default: return null;
            }
        }

    }
}


