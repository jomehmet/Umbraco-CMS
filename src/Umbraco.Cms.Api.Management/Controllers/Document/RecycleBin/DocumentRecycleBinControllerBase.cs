﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core;
using Umbraco.Cms.Core.Models;
using Umbraco.Cms.Core.Models.Entities;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Api.Management.Controllers.RecycleBin;
using Umbraco.Cms.Api.Management.Filters;
using Umbraco.Cms.Api.Management.ViewModels.RecycleBin;
using Umbraco.New.Cms.Web.Common.Routing;

namespace Umbraco.Cms.Api.Management.Controllers.Document.RecycleBin;

[ApiVersion("1.0")]
[ApiController]
[VersionedApiBackOfficeRoute($"{Constants.Web.RoutePath.RecycleBin}/{Constants.UdiEntityType.Document}")]
[RequireDocumentTreeRootAccess]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
[ApiExplorerSettings(GroupName = nameof(Constants.UdiEntityType.Document))]
public class DocumentRecycleBinControllerBase : RecycleBinControllerBase<RecycleBinItemViewModel>
{
    public DocumentRecycleBinControllerBase(IEntityService entityService)
        : base(entityService)
    {
    }

    protected override UmbracoObjectTypes ItemObjectType => UmbracoObjectTypes.Document;

    protected override int RecycleBinRootId => Constants.System.RecycleBinContent;

    protected override RecycleBinItemViewModel MapRecycleBinViewModel(Guid? parentKey, IEntitySlim entity)
    {
        RecycleBinItemViewModel viewModel = base.MapRecycleBinViewModel(parentKey, entity);

        if (entity is IDocumentEntitySlim documentEntitySlim)
        {
            viewModel.Icon = documentEntitySlim.ContentTypeIcon ?? viewModel.Icon;
        }

        return viewModel;
    }
}