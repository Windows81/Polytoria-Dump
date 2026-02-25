namespace System;

[Token(Token = "0x2000177")]
internal sealed class LocalDataStore
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400058B")]
	private LocalDataStoreElement[] m_DataTable; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400058C")]
	private LocalDataStoreMgr m_Manager; //Field offset: 0x18

	[Address(RVA = "0x14E0070", Offset = "0x14DF270", Length = "0x7B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000D1C")]
	public LocalDataStore(LocalDataStoreMgr mgr, int InitialCapacity) { }

	[Address(RVA = "0x14DFAD0", Offset = "0x14DECD0", Length = "0x24")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStore)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000D1D")]
	internal void Dispose() { }

	[Address(RVA = "0x14DFB00", Offset = "0x14DED00", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000D20")]
	internal void FreeData(int slot, long cookie) { }

	[Address(RVA = "0x14DFB60", Offset = "0x14DED60", Length = "0x126")]
	[CalledBy(Type = typeof(Context), Member = "GetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(object))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D1E")]
	public object GetData(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x14DFC90", Offset = "0x14DEE90", Length = "0x291")]
	[CalledBy(Type = typeof(LocalDataStore), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D21")]
	private LocalDataStoreElement PopulateElement(LocalDataStoreSlot slot) { }

	[Address(RVA = "0x14DFF30", Offset = "0x14DF130", Length = "0x139")]
	[CalledBy(Type = typeof(Context), Member = "SetData", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot), typeof(object)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(LocalDataStore), Member = "PopulateElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStoreSlot)}, ReturnType = typeof(LocalDataStoreElement))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000D1F")]
	public void SetData(LocalDataStoreSlot slot, object data) { }

}

