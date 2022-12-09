using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Api.Management.Routing;

namespace Umbraco.Cms.Api.Management.Controllers.HealthCheck;

[ApiController]
[VersionedApiBackOfficeRoute("health-check")]
[ApiExplorerSettings(GroupName = "Health Check")]
[ApiVersion("1.0")]
public abstract class HealthCheckGroupControllerBase : ManagementApiControllerBase
{
}
