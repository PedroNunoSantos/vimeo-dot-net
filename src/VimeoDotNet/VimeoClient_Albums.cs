using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using VimeoDotNet.Constants;
using VimeoDotNet.Models;
using VimeoDotNet.Parameters;

namespace VimeoDotNet
{
    public partial class VimeoClient
    {
        /// <inheritdoc />
        public async Task<Album> GetAlbumAsync(UserId userId, long albumId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                userId.IsMe ? Endpoints.MeAlbum : Endpoints.UserAlbum,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"albumId", albumId.ToString()}
                }
            );

            return await ExecuteApiRequest<Album>(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<Paginated<Album>> GetAlbumsAsync(UserId userId, GetAlbumsParameters parameters = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                userId.IsMe ? Endpoints.MeAlbums : Endpoints.UserAlbums,
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<Paginated<Album>>(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<Album> CreateAlbumAsync(UserId userId, EditAlbumParameters parameters = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Post,
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbums),
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<Album>(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<Album> UpdateAlbumAsync(UserId userId, long albumId, EditAlbumParameters parameters = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                new HttpMethod("PATCH"),
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbum),
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"albumId", albumId.ToString()}
                },
                parameters
            );

            return await ExecuteApiRequest<Album>(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<bool> DeleteAlbumAsync(UserId userId, long albumId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Delete,
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbum),
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"albumId", albumId.ToString()}
                }
            );

            return await ExecuteApiRequest(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<bool> AddToAlbumAsync(UserId userId, long albumId, long clipId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Put,
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbumVideo),
                new Dictionary<string, string>
                {
                    {"userId", userId.ToString()},
                    {"albumId", albumId.ToString()},
                    {"clipId", clipId.ToString()}
                }
            );

            return await ExecuteApiRequest(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<bool> RemoveFromAlbumAsync(UserId userId, long albumId, long clipId)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Delete,
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbumVideo),
                new Dictionary<string, string>
                {
                    {"albumId", albumId.ToString()},
                    {"clipId", clipId.ToString()}
                }
            );

            return await ExecuteApiRequest(request).ConfigureAwait(false);
        }

        /// <inheritdoc />
        public async Task<Paginated<Video>> GetAllVideoInAlbumAsync(UserId userid, int albumId, int? page = null,
            int? perPage = null, GetVideoByTagSort? sort = null, GetVideoByTagDirection? direction = null)
        {
            var request = _apiRequestFactory.AuthorizedRequest(
                AccessToken,
                HttpMethod.Get,
                Endpoints.GetCurrentUserEndpoint(Endpoints.UserAlbumVideos),
                new Dictionary<string, string>
                {
                    {"albumId", albumId.ToString()}
                }
            );

            if (page.HasValue)
            {
                request.Query.Add("page", page.ToString());
            }

            if (perPage.HasValue)
            {
                request.Query.Add("per_page", perPage.ToString());
            }

            if (sort.HasValue)
            {
                request.Query.Add("sort", sort.Value.GetStringValue());
            }

            if (direction.HasValue)
            {
                request.Query.Add("direction", direction.Value.GetStringValue());
            }

            return await ExecuteApiRequest<Paginated<Video>>(request).ConfigureAwait(false);

        }

    }
}