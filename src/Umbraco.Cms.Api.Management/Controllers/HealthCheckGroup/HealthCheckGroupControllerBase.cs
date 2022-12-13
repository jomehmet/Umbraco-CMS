using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Management.Routing;
using Constants = Umbraco.Cms.Core.Constants;

namespace Umbraco.Cms.Api.Management.Controllers.HealthCheckGroup;

[ApiController]
[VersionedApiBackOfficeRoute($"{Constants.HealthChecks.RoutePath.HealthCheck}-group")]
[ApiExplorerSettings(GroupName = "Health Check Group")]
[ApiVersion("1.0")]
public abstract class HealthCheckGroupControllerBase : ManagementApiControllerBase
{
}
