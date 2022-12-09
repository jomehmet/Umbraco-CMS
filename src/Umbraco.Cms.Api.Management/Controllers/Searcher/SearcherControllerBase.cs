﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.New.Cms.Web.Common.Routing;

namespace Umbraco.Cms.Api.Management.Controllers.Searcher;

[ApiController]
[VersionedApiBackOfficeRoute("searcher")]
[ApiExplorerSettings(GroupName = "Searcher")]
public class SearcherControllerBase : ManagementApiControllerBase
{
}