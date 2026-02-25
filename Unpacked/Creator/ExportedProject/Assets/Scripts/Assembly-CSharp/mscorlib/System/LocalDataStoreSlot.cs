namespace System;

[ComVisible(True)]
[Token(Token = "0x2000178")]
public sealed class LocalDataStoreSlot
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058D")]
	private LocalDataStoreMgr m_mgr; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400058E")]
	private int m_slot; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400058F")]
	private long m_cookie; //Field offset: 0x20

	[Token(Token = "0x17000121")]
	internal long Cookie
	{
		[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
		[CallerCount(Count = 11)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D25")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x1700011F")]
	internal LocalDataStoreMgr Manager
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D23")]
		internal get { } //Length: 5
	}

	[Token(Token = "0x17000120")]
	internal int Slot
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D24")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x14DFA70", Offset = "0x14DEC70", Length = "0x53")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D22")]
	internal LocalDataStoreSlot(LocalDataStoreMgr mgr, int slot, long cookie) { }

	[Address(RVA = "0x14DF9E0", Offset = "0x14DEBE0", Length = "0x80")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "FreeDataSlot", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(long)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D26")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2F72B0", Offset = "0x2F64B0", Length = "0x5")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D25")]
	internal long get_Cookie() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D23")]
	internal LocalDataStoreMgr get_Manager() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D24")]
	internal int get_Slot() { }

}

