﻿using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Management.Factories;
using Umbraco.Cms.Api.Management.ViewModels.RedirectUrlManagement;

namespace Umbraco.Cms.Api.Management.RedirectUrlManagement;

public class GetEnabledController : RedirectUrlManagementBaseController
{
    private readonly IRedirectUrlStatusViewModelFactory _redirectUrlStatusViewModelFactory;

    public GetEnabledController(
        IRedirectUrlStatusViewModelFactory redirectUrlStatusViewModelFactory) =>
        _redirectUrlStatusViewModelFactory = redirectUrlStatusViewModelFactory;

    [HttpGet("status")]
    public Task<ActionResult<RedirectUrlStatusViewModel>> GetStatus() =>
        Task.FromResult<ActionResult<RedirectUrlStatusViewModel>>(_redirectUrlStatusViewModelFactory.CreateViewModel());
}
