using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Cors;
using System.Web.Http.Cors;

namespace Web.API.CORS
{
    public class EnableCustomCorsAttribute : Attribute, ICorsPolicyProvider
    {
        readonly CorsPolicy corsPolicy;
        public EnableCustomCorsAttribute()
        {
            this.corsPolicy = new CorsPolicy()
            {
                AllowAnyHeader=true,
                AllowAnyMethod=true,
            };

            //corsPolicy.Origins.Add("http://localhost:49639");
            corsPolicy.Origins.Add("http://localhost:49639/");

        }
        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(corsPolicy);
        }
    }
}