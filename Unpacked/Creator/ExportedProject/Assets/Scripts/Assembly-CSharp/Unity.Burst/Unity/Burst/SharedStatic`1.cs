namespace Unity.Burst;

[IsReadOnly]
[Token(Token = "0x200001C")]
public struct SharedStatic
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000042")]
	private readonly Void* _buffer; //Field offset: 0x0

	[Token(Token = "0x1700000F")]
	public T Data
	{
		[Address(RVA = "0xF15310", Offset = "0xF14510", Length = "0x24")]
		[CallerCount(Count = 14)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000077")]
		 get { } //Length: 36
	}

	[Address(RVA = "0xC498F0", Offset = "0xC48AF0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	private SharedStatic`1(Void* buffer) { }

	[Address(RVA = "0xF15310", Offset = "0xF14510", Length = "0x24")]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	public T get_Data() { }

	[Address(RVA = "0x605E20", Offset = "0x605020", Length = "0xC2")]
	[CalledBy(Type = "Unity.Jobs.IJobParallelForBatchExtensions+JobParallelForBatchProducer`1", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Unity.Burst.SharedStatic`1<System.IntPtr>), Member = "GetOrCreateUnsafe", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(long), typeof(long)}, ReturnType = typeof(Unity.Burst.SharedStatic`1<System.IntPtr>))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	public static SharedStatic<T> GetOrCreate(uint alignment = 0) { }

	[Address(RVA = "0xF15280", Offset = "0xF14480", Length = "0x84")]
	[CalledBy(Type = "Unity.Collections.AllocatorManager+SharedStatics+TableEntry", Member = ".cctor", ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(SharedStatic), Member = "GetOrCreateSharedStaticInternal", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(long), typeof(long), typeof(uint), typeof(uint)}, ReturnType = typeof(Void*))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000079")]
	public static SharedStatic<T> GetOrCreateUnsafe(uint alignment, long hashCode, long subHashCode) { }

}

