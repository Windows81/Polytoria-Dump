namespace System.Collections.Generic;

[Token(Token = "0x20001B4")]
internal sealed class BitHelper
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40006AE")]
	private readonly int _length; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40006AF")]
	private readonly Int32* _arrayPtr; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40006B0")]
	private readonly Int32[] _array; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40006B1")]
	private readonly bool _useStackAlloc; //Field offset: 0x28

	[Address(RVA = "0x15CE000", Offset = "0x15CD200", Length = "0x3A")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A96")]
	internal BitHelper(Int32* bitArrayPtr, int length) { }

	[Address(RVA = "0x15CE040", Offset = "0x15CD240", Length = "0x42")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A97")]
	internal BitHelper(Int32[] bitArray, int length) { }

	[Address(RVA = "0x15CDEF0", Offset = "0x15CD0F0", Length = "0x7C")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A99")]
	internal bool IsMarked(int bitPosition) { }

	[Address(RVA = "0x15CDF70", Offset = "0x15CD170", Length = "0x6F")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A98")]
	internal void MarkBit(int bitPosition) { }

	[Address(RVA = "0x15CDFE0", Offset = "0x15CD1E0", Length = "0x16")]
	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A9A")]
	internal static int ToIntArrayLength(int n) { }

}

