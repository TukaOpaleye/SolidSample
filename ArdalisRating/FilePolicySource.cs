using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRating
{
    public class FilePolicySource
    {
        public string ReadPolicy()
        {
            return File.ReadAllText("policy.json"); 
            
            //why not just pass the filename as a parameter ? 
        }
    }
}
