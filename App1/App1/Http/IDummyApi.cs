using App1.Http.Models;
using Refit;

namespace App1.Http;

internal interface IDummyClient
{
    [Get("/posts")]
    Task<ApiResponse<GetPostsResponse>> GetPostsAsync(int limit = 25, int skip = 0);
}


