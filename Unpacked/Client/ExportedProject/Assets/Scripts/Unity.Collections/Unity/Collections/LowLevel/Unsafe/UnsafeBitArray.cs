namespace Unity.Collections.LowLevel.Unsafe;

[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[GenerateTestsForBurstCompatibility]
[Token(Token = "0x2000040")]
public struct UnsafeBitArray : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	[Token(Token = "0x4000084")]
	public UInt64* Ptr; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000085")]
	public int Length; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x4000086")]
	public int Capacity; //Field offset: 0xC
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000087")]
	public AllocatorHandle Allocator; //Field offset: 0x10

	[Token(Token = "0x17000010")]
	public bool IsCreated
	{
		[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
		[CallerCount(Count = 16)]
		[ContainsUnimplementedInstructions]
		[DeduplicatedMethod]
		[IsReadOnly]
		[Token(Token = "0x6000071")]
		 get { } //Length: 8
	}

	[Address(RVA = "0x1820FC0", Offset = "0x18201C0", Length = "0x96")]
	[CalledBy(Type = typeof(NativeBitArrayDispose), Member = "Dispose", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UnsafeBitArray), Member = "Free", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeBitArray*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ulong)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UInt64*), typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000072")]
	public override void Dispose() { }

	[Address(RVA = "0x1821060", Offset = "0x1820260", Length = "0x9D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnsafeBitArray), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmanaged), Member = "Free", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T*", typeof(AllocatorHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Token(Token = "0x6000070")]
	internal static void Free(UnsafeBitArray* data, AllocatorHandle allocator) { }

	[Address(RVA = "0x845340", Offset = "0x844540", Length = "0x8")]
	[CallerCount(Count = 16)]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[IsReadOnly]
	[Token(Token = "0x6000071")]
	public bool get_IsCreated() { }

}

