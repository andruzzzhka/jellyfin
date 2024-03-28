namespace MediaBrowser.Model.SyncPlay
{
    /// <summary>
    /// Class GroupStateUpdate.
    /// </summary>
    public class GroupStateUpdate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupStateUpdate"/> class.
        /// </summary>
        /// <param name="state">The state of the group.</param>
        /// <param name="reason">The reason of the state change.</param>
        /// <param name="initiator">The name of user who initiated the state change.</param>
        public GroupStateUpdate(GroupStateType state, PlaybackRequestType reason, string initiator)
        {
            State = state;
            Reason = reason;
            Initiator = initiator;
        }

        /// <summary>
        /// Gets the state of the group.
        /// </summary>
        /// <value>The state of the group.</value>
        public GroupStateType State { get; }

        /// <summary>
        /// Gets the reason of the state change.
        /// </summary>
        /// <value>The reason of the state change.</value>
        public PlaybackRequestType Reason { get; }

        /// <summary>
        /// Gets the name of user who initiated the state change.
        /// </summary>
        /// <value>The name of user who initiated the state change.</value>
        public string Initiator { get; }
    }
}
