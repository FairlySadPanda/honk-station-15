using Robust.Shared.Serialization;

namespace Content.Shared.Doors.V2
{
    [Serializable, NetSerializable]
    public enum AirlockWireStatus
    {
        BoltIndicator,
        BoltLightIndicator,
        AiControlIndicator,
        AiVisionIndicator,
        TimingIndicator,
        SafetyIndicator,
    }
}
