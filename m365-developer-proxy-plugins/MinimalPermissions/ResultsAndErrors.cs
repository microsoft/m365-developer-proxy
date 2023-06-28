using System.Text.Json.Serialization;

namespace Microsoft365.DeveloperProxy.Plugins.RequestLogs.MinimalPermissions;

internal class ResultsAndErrors
{
  [JsonPropertyName("results")]
  public PermissionInfo[]? Results { get; set; }
  [JsonPropertyName("errors")]
  public PermissionError[]? Errors { get; set; }
}