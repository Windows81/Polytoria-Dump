namespace Mirror;

[Token(Token = "0x200001C")]
public class HistoryBounds
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000042")]
	private readonly int boundsPerBucket; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000043")]
	private readonly Queue<MinMaxBounds> fullBuckets; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000044")]
	private readonly int bucketLimit; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000045")]
	private Nullable<MinMaxBounds> currentBucket; //Field offset: 0x24
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000046")]
	private int currentBucketSize; //Field offset: 0x40
	[CompilerGenerated]
	[FieldOffset(Offset = "0x44")]
	[Token(Token = "0x4000047")]
	private int <boundsCount>k__BackingField; //Field offset: 0x44
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000048")]
	private MinMaxBounds totalMinMax; //Field offset: 0x48

	[Token(Token = "0x17000015")]
	public private int boundsCount
	{
		[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A1")]
		 get { } //Length: 4
		[Address(RVA = "0x124FA60", Offset = "0x124EC60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x60000A2")]
		private set { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	public Bounds total
	{
		[Address(RVA = "0x124F9E0", Offset = "0x124EBE0", Length = "0x7D")]
		[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.HistoryCollider", Member = "OnDrawGizmos", ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Token(Token = "0x60000A3")]
		 get { } //Length: 125
	}

	[Address(RVA = "0x124F940", Offset = "0x124EB40", Length = "0x96")]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "Awake", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x60000A4")]
	public HistoryBounds(int boundsLimit, int boundsPerBucket) { }

	[Address(RVA = "0x1060130", Offset = "0x105F330", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A1")]
	public int get_boundsCount() { }

	[Address(RVA = "0x124F9E0", Offset = "0x124EBE0", Length = "0x7D")]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "ProjectBounds", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "OnDrawGizmos", ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Token(Token = "0x60000A3")]
	public Bounds get_total() { }

	[Address(RVA = "0x124F2B0", Offset = "0x124E4B0", Length = "0x611")]
	[CalledBy(Type = "Mirror.HistoryCollider", Member = "CaptureBounds", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Mirror.MinMaxBounds>), Member = "Enqueue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MinMaxBounds)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1<Mirror.MinMaxBounds>), Member = "Dequeue", ReturnType = typeof(MinMaxBounds))]
	[Calls(Type = typeof(Queue`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Queue`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.Queue`1+Enumerator<Mirror.MinMaxBounds>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Enumerator), Member = "get_Current", ReturnType = "T")]
	[Calls(Type = typeof(Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A5")]
	public void Insert(Bounds bounds) { }

	[Address(RVA = "0x124F8D0", Offset = "0x124EAD0", Length = "0x61")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Queue`1), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60000A6")]
	public void Reset() { }

	[Address(RVA = "0x124FA60", Offset = "0x124EC60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x60000A2")]
	private void set_boundsCount(int value) { }

}

