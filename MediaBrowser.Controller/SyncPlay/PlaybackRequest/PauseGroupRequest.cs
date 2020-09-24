using System.Threading;
using MediaBrowser.Model.SyncPlay;
using MediaBrowser.Controller.Session;

namespace MediaBrowser.Controller.SyncPlay
{
    /// <summary>
    /// Class PauseGroupRequest.
    /// </summary>
    public class PauseGroupRequest : IPlaybackGroupRequest
    {
        /// <inheritdoc />
        public PlaybackRequestType GetRequestType()
        {
            return PlaybackRequestType.Pause;
        }

        /// <inheritdoc />
        public void Apply(ISyncPlayStateContext context, ISyncPlayState state, SessionInfo session, CancellationToken cancellationToken)
        {
            state.HandleRequest(context, state.GetGroupState(), this, session, cancellationToken);
        }
    }
}
