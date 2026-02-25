namespace System;

[Token(Token = "0x2000175")]
internal sealed class LocalDataStoreHolder
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000588")]
	private LocalDataStore m_Store; //Field offset: 0x10

	[Token(Token = "0x1700011C")]
	public LocalDataStore Store
	{
		[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
		[CallerCount(Count = 50)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000D17")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x3694D0", Offset = "0x3686D0", Length = "0x31")]
	[CallerCount(Count = 72)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D15")]
	public LocalDataStoreHolder(LocalDataStore store) { }

	[Address(RVA = "0x14DEE30", Offset = "0x14DE030", Length = "0x79")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LocalDataStoreMgr), Member = "DeleteLocalDataStore", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LocalDataStore)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6000D16")]
	protected virtual void Finalize() { }

	[Address(RVA = "0x2DD2C0", Offset = "0x2DC4C0", Length = "0x5")]
	[CallerCount(Count = 50)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000D17")]
	public LocalDataStore get_Store() { }

}

