     <summary>
            Removes all keys and values from the cache.
            </summary>
        </member>
        <member name="M:Microsoft.Extensions.Caching.Memory.MemoryCache.GetCurrentStatistics">
            <summary>
            Gets a snapshot of the current statistics for the memory cache.
            </summary>
            <returns>Returns <see langword="null"/> if statistics are not being tracked because <see cref="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.TrackStatistics" /> is <see langword="false"/>.</returns>
        </member>
        <member name="M:Microsoft.Extensions.Caching.Memory.MemoryCache.UpdateCacheSizeExceedsCapacity(Microsoft.Extensions.Caching.Memory.CacheEntry,Microsoft.Extensions.Caching.Memory.MemoryCache.CoherentState)">
            <summary>
            Returns true if increasing the cache size by the size of entry would
            cause it to exceed any size limit on the cache, otherwise, returns false.
            </summary>
        </member>
        <member name="M:Microsoft.Extensions.Caching.Memory.MemoryCache.Compact(System.Double)">
            Remove at least the given percentage (0.10 for 10%) of the total entries (or estimated memory?), according to the following policy:
            1. Remove all expired items.
            2. Bucket by CacheItemPriority.
            3. Least recently used objects.
            ?. Items with the soonest absolute expiration.
            ?. Items with the soonest sliding expiration.
            ?. Larger objects - estimated by object graph size, inaccurate.
        </member>
        <member name="M:Microsoft.Extensions.Caching.Memory.MemoryCache.Dispose">
            <inheritdoc />
        </member>
        <member name="M:Microsoft.Extensions.Caching.Memory.MemoryCache.Dispose(System.Boolean)">
            <summary>
            Dispose the cache and clear all entries.
            </summary>
            <param name="disposing">Dispose the object resources if true; otherwise, take no action.</param>
        </member>
        <member name="T:Microsoft.Extensions.Caching.Memory.MemoryCache.CoherentState">
             <summary>
             Wrapper for the memory cache entries collection.
            
             Entries may have various sizes. If a size limit has been set, the cache keeps track of the aggregate of all the entries' sizes
             in order to trigger compaction when the size limit is exceeded.
            
             For performance reasons, the size is not updated atomically with the collection, but is only made eventually consistent.
            
             When the memory cache is cleared, it replaces the backing collection entirely. This may occur in parallel with operations
             like add, set, remove, and compact which may modify the collection and thus its overall size.
            
             To keep the overall size eventually consistent, therefore, the collection and the overall size are wrapped in this CoherentState
             object. Individual operations take a local reference to this wrapper object while they work, and make size updates to this object.
             Clearing the cache simply replaces the object, so that any still in progress updates do not affect the overall size value for
             the new backing collection.
             </summary>
        </member>
        <member name="T:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions">
            <summary>
            Options class for <see cref="T:Microsoft.Extensions.Caching.Memory.MemoryCache"/>.
            </summary>
        </member>
        <member name="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.Clock">
            <summary>
            Gets or sets the clock used by the cache for expiration.
            </summary>
        </member>
        <member name="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.ExpirationScanFrequency">
            <summary>
            Gets or sets the minimum length of time between successive scans for expired items.
            </summary>
        </member>
        <member name="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.SizeLimit">
            <summary>
            Gets or sets the maximum size of the cache.
            </summary>
        </member>
        <member name="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.CompactOnMemoryPressure">
            <summary>
            Enables ot disables the option to compact the cache when the maximum size is exceeded.
            </summary>
        </member>
        <member name="P:Microsoft.Extensions.Caching.Memory.MemoryCacheOptions.CompactionPercentage">
            <summary>
            Gets or sets the amount t