using System.Threading;
using MediaBrowser.Model.SyncPlay;
using MediaBrowser.Controller.Session;

namespace MediaBrowser.Controller.SyncPlay
{
    /// <summary>
    /// Class RemoveFromPlaylistGroupRequest.
    /// </summary>
    public class RemoveFromPlaylistGroupRequest : IPlaybackGroupRequest
    {
        /// <summary>
        /// Gets or sets the playlist ids ot the items.
        /// </summary>
        /// <value>The playlist ids ot the items.</value>
        public string[] PlaylistItemIds { get; set; }

        /// <inheritdoc />
        public PlaybackRequestType GetRequestType()
        {
            return PlaybackRequestType.Queue;
        }

        /// <inheritdoc />
        public void Apply(ISyncPlayStateContext context, ISyncPlayState state, SessionInfo session, CancellationToken cancellationToken)
        {
            state.HandleRequest(context, state.GetGroupState(), this, session, cancellationToken);
        }
    }
}
