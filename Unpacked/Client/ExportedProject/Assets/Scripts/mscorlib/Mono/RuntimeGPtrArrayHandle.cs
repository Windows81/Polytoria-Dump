namespace Mono;

[DefaultMember("Item")]
[Token(Token = "0x2000036")]
internal struct RuntimeGPtrArrayHandle
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000112")]
	private GPtrArray* value; //Field offset: 0x0

	[Token(Token = "0x1700000C")]
	internal IntPtr Item
	{
		[Address(RVA = "0x12DDA20", Offset = "0x12DCC20", Length = "0x8")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
		[DeduplicatedMethod]
		[Token(Token = "0x600006B")]
		internal get { } //Length: 8
	}

	[Token(Token = "0x1700000B")]
	internal int Length
	{
		[Address(RVA = "0x12DDA30", Offset = "0x12DCC30", Length = "0x19")]
		[CallerCount(Count = 6)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600006A")]
		internal get { } //Length: 25
	}

	[Address(RVA = "0x9E2BC0", Offset = "0x9E1DC0", Length = "0x1F")]
	[CallerCount(Count = 11)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000069")]
	internal RuntimeGPtrArrayHandle(IntPtr ptr) { }

	[Address(RVA = "0x12DD970", Offset = "0x12DCB70", Length = "0x1E")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A330")]
	[DeduplicatedMethod]
	[Token(Token = "0x600006E")]
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

	[Address(RVA = "0x12DDA20", Offset = "0x12DCC20", Length = "0x8")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[DeduplicatedMethod]
	[Token(Token = "0x600006B")]
	internal IntPtr get_Item(int i) { }

	[Address(RVA = "0x12DDA30", Offset = "0x12DCC30", Length = "0x19")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600006A")]
	internal int get_Length() { }

	[Address(RVA = "0x12DD990", Offset = "0x12DCB90", Length = "0x5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18020A330")]
	[Token(Token = "0x600006D")]
	private static void GPtrArrayFree(GPtrArray* value) { }

	[Address(RVA = "0x12DD9A0", Offset = "0x12DCBA0", Length = "0x70")]
	[CalledBy(Type = typeof(RuntimeGPtrArrayHandle), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CalledBy(Type = typeof(SafeGPtrArrayHandle), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(IntPtr))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600006C")]
	internal IntPtr Lookup(int i) { }

}

