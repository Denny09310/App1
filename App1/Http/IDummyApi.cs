using App1.Http.Models;
using App1.Models;
using Refit;

namespace App1.Http;

internal interface IDummyClient
{
    [Get("/posts")]
    Task<ApiResponse<GetPostsResponse>> GetPostsAsync(int limit = 25, int skip = 0);

    [Get("/users/{id}")]
    Task<ApiResponse<User>> GetUserAsync(int id);
}


