namespace Mirror;

[Token(Token = "0x2000077")]
public class SnapshotInterpolationSettings
{
	[FieldOffset(Offset = "0x10")]
	[Header("Buffering")]
	[Token(Token = "0x400018B")]
	[Tooltip("Local simulation is behind by sendInterval * multiplier seconds.\n\nThis guarantees that we always have enough snapshots in the buffer to mitigate lags & jitter.\n\nIncrease this if the simulation isn't smooth. By default, it should be around 2.")]
	public double bufferTimeMultiplier; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400018C")]
	[Tooltip("If a client can't process snapshots fast enough, don't store too many.")]
	public int bufferLimit; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Header("Catchup / Slowdown")]
	[Token(Token = "0x400018D")]
	[Tooltip("Slowdown begins when the local timeline is moving too fast towards remote time. Threshold is in frames worth of snapshots.\n\nThis needs to be negative.\n\nDon't modify unless you know what you are doing.")]
	public float catchupNegativeThreshold; //Field offset: 0x1C
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400018E")]
	[Tooltip("Catchup begins when the local timeline is moving too slow and getting too far away from remote time. Threshold is in frames worth of snapshots.\n\nThis needs to be positive.\n\nDon't modify unless you know what you are doing.")]
	public float catchupPositiveThreshold; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Range(0, 1)]
	[Token(Token = "0x400018F")]
	[Tooltip("Local timeline acceleration in % while catching up.")]
	public double catchupSpeed; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Range(0, 1)]
	[Token(Token = "0x4000190")]
	[Tooltip("Local timeline slowdown in % while slowing down.")]
	public double slowdownSpeed; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000191")]
	[Tooltip("Catchup/Slowdown is adjusted over n-second exponential moving average.")]
	public int driftEmaDuration; //Field offset: 0x38
	[FieldOffset(Offset = "0x3C")]
	[Header("Dynamic Adjustment")]
	[Token(Token = "0x4000192")]
	[Tooltip("Automatically adjust bufferTimeMultiplier for smooth results.\nSets a low multiplier on stable connections, and a high multiplier on jittery connections.")]
	public bool dynamicAdjustment; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000193")]
	[Tooltip("Safety buffer that is always added to the dynamic bufferTimeMultiplier adjustment.")]
	public float dynamicAdjustmentTolerance; //Field offset: 0x40
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000194")]
	[Tooltip("Dynamic adjustment is computed over n-second exponential moving average standard deviation.")]
	public int deliveryTimeEmaDuration; //Field offset: 0x44

	[Address(RVA = "0x12A30D0", Offset = "0x12A22D0", Length = "0x5F")]
	[CalledBy(Type = typeof(NetworkClient), Member = ".cctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(NetworkManager), Member = ".ctor", ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60003F6")]
	public SnapshotInterpolationSettings() { }

}

