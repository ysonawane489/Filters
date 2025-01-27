﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filters.Bussness
{
    public class CustomExceptionFilter:IExceptionFilter
    {
        private readonly IModelMetadataProvider _ModelMetadataProvider;
        public CustomExceptionFilter(IModelMetadataProvider ModelMetadataProvider)
        {
            _ModelMetadataProvider = ModelMetadataProvider;
        }
        public void OnException(ExceptionContext context)
        {
            var result = new ViewResult { ViewName = "CustmoError" };
            result.ViewData = new ViewDataDictionary(_ModelMetadataProvider, context.ModelState);
            result.ViewData.Add("Exception", context.Exception);

            context.ExceptionHandled = true;
            context.Result = result;
        }
    }
}
