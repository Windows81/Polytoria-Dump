namespace UnityEngine.Bindings;

[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001D6")]
[VisibleToOtherModules]
internal struct BlittableArrayWrapper
{
	[Token(Token = "0x20001D7")]
	public enum UpdateFlags
	{
		NoUpdateNeeded = 0,
		SizeChanged = 1,
		DataIsNativePointer = 2,
		DataIsNativeOwnedMemory = 3,
		DataIsEmpty = 4,
		DataIsNull = 5,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400066B")]
	internal Void* data; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400066C")]
	internal int size; //Field offset: 0x8
	[FieldOffset(Offset = "0xC")]
	[Token(Token = "0x400066D")]
	internal UpdateFlags updateFlags; //Field offset: 0xC

	[Address(RVA = "0x197B850", Offset = "0x197AA50", Length = "0xF")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6000C81")]
	public BlittableArrayWrapper(Void* data, int size) { }

	[Address(RVA = "0x683C50", Offset = "0x682E50", Length = "0x140")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002AC10")]
	[Calls(Type = typeof(BindingsAllocator), Member = "GetNativeOwnedDataPointer", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(Void*))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(BindingsAllocator), Member = "FreeNativeOwnedMemory", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180029B10")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C82")]
	internal void Unmarshal(ref T[] array) { }

}

