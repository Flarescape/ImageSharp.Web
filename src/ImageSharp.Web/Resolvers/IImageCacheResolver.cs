// Copyright (c) Six Labors and contributors.
// Licensed under the GNU Affero General Public License, Version 3.

using System.IO;
using System.Threading.Tasks;

namespace SixLabors.ImageSharp.Web.Resolvers
{
    /// <summary>
    /// Specifies the contract for resolving image buffers from different cached locations.
    /// </summary>
    public interface IImageCacheResolver
    {
        /// <summary>
        /// Asynchronously gets metadata associated with this image.
        /// </summary>
        /// <returns>The <see cref="ImageCacheMetadata"/>.</returns>
        Task<ImageCacheMetadata> GetMetaDataAsync();

        /// <summary>
        /// Asynchronously gets the input image stream.
        /// </summary>
        /// <returns>The <see cref="Task{Stream}"/>.</returns>
        Task<Stream> OpenReadAsync();
    }
}
