namespace Mono;

[DefaultMember("Item")]
[Token(Token = "0x2000045")]
internal struct SafeGPtrArrayHandle : IDisposable
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400013C")]
	private RuntimeGPtrArrayHandle handle; //Field offset: 0x0

	[Token(Token = "0x1700000E")]
	internal IntPtr Item
	{
		[Address(RVA = "0x12DDA20", Offset = "0x12DCC20", Length = "0x8")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
		[DeduplicatedMethod]
		[Token(Token = "0x6000078")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000D")]
	internal int Length
	{
		[Address(RVA = "0x12DDA30", Offset = "0x12DCC30", Length = "0x19")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000077")]
		internal get { } //Length: 25
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000075")]
	internal SafeGPtrArrayHandle(IntPtr ptr) { }

	[Address(RVA = "0x12DD970", Offset = "0x12DCB70", Length = "0x1E")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A330")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000076")]
	public override void Dispose() { }

	[Address(RVA = "0x12DDA20", Offset = "0x12DCC20", Length = "0x8")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	[Token(Token = "0x6000078")]
	internal IntPtr get_Item(int i) { }

	[Address(RVA = "0x12DDA30", Offset = "0x12DCC30", Length = "0x19")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000077")]
	internal int get_Length() { }

}

