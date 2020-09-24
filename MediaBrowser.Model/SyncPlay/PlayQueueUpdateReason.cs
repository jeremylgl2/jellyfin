namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Enum PlayQueueUpdateReason.
    /// </summary>
    public enum PlayQueueUpdateReason
    {
        /// <summary>
        /// A user is requesting to play a new playlist.
        /// </summary>
        NewPlaylist = 0,

        /// <summary>
        /// A user is changing the playing item.
        /// </summary>
        SetCurrentItem = 1,

        /// <summary>
        /// A user is removing items from the playlist.
        /// </summary>
        RemoveItems = 2,

        /// <summary>
        /// A user is moving an item in the playlist.
        /// </summary>
        MoveItem = 3,

        /// <summary>
        /// A user is making changes to the queue.
        /// </summary>
        Queue = 4,

        /// <summary>
        /// A user is making changes to the queue.
        /// </summary>
        QueueNext = 5,

        /// <summary>
        /// A user is requesting the next item in queue.
        /// </summary>
        NextTrack = 6,

        /// <summary>
        /// A user is requesting the previous item in queue.
        /// </summary>
        PreviousTrack = 7,

        /// <summary>
        /// A user is changing repeat mode.
        /// </summary>
        RepeatMode = 8,

        /// <summary>
        /// A user is changing shuffle mode.
        /// </summary>
        ShuffleMode = 9
    }
}
