using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NinthBlogApi.Extensions
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyTagDescriptions : IDocumentFilter
    {
        /// <summary>
        /// swagger汉化标签
        /// </summary>
        /// <param name="swaggerDoc"></param>
        /// <param name="context"></param>
        public void Apply(SwaggerDocument swaggerDoc, DocumentFilterContext context)
        {
            swaggerDoc.Tags = new List<Tag>
            {
                new Tag { Name = "Enterprise", Description = "XX相关接口" },
                new Tag { Name = "Ticket", Description = "XX相关接口" },
                new Tag { Name = "Power", Description = "权限相关接口" }
            };
        }
    }
}
