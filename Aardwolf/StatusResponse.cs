﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aardwolf
{
    public abstract class StatusResponse : IHttpResponseAction
    {
        protected readonly int statusCode;
        protected readonly string statusDescription;

        protected StatusResponse(int statusCode, string statusDescription)
        {
            this.statusCode = statusCode;
            this.statusDescription = statusDescription;
        }

        protected void SetStatus(IHttpRequestResponseContext context)
        {
            context.Response.StatusCode = statusCode;
            if (statusDescription != null)
                context.Response.StatusDescription = statusDescription;
        }

        public abstract Task Execute(IHttpRequestResponseContext context);
    }
}
