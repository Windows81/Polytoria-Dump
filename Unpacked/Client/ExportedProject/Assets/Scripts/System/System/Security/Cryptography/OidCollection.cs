namespace System.Security.Cryptography;

[DefaultMember("Item")]
[Token(Token = "0x2000114")]
public sealed class OidCollection : ICollection, IEnumerable
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40004E1")]
	private readonly List<Oid> _list; //Field offset: 0x10

	[Token(Token = "0x1700010B")]
	public override int Count
	{
		[Address(RVA = "0x177F6C0", Offset = "0x177E8C0", Length = "0x3C")]
		[CalledBy(Type = typeof(OidCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60006A3")]
		 get { } //Length: 60
	}

	[Token(Token = "0x1700010A")]
	public Oid Item
	{
		[Address(RVA = "0x177F700", Offset = "0x177E900", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x60006A2")]
		 get { } //Length: 81
	}

	[Token(Token = "0x1700010C")]
	public override object SyncRoot
	{
		[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
		[CallerCount(Count = 2057)]
		[DeduplicatedMethod]
		[Token(Token = "0x60006A7")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x177F640", Offset = "0x177E840", Length = "0x77")]
	[CalledBy(Type = typeof(X509ChainImplMono), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainPolicy), Member = ".ctor", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509ChainPolicy), Member = "Reset", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OidCollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "get_EnhancedKeyUsages", ReturnType = typeof(OidCollection))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x60006A0")]
	public OidCollection() { }

	[Address(RVA = "0x177F2B0", Offset = "0x177E4B0", Length = "0xD0")]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(OidCollection), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "get_EnhancedKeyUsages", ReturnType = typeof(OidCollection))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "Decode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Byte[])}, ReturnType = typeof(AsnDecodeStatus))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x60006A1")]
	public int Add(Oid oid) { }

	[Address(RVA = "0x177F6C0", Offset = "0x177E8C0", Length = "0x3C")]
	[CalledBy(Type = typeof(OidCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(X509EnhancedKeyUsageExtension), Member = "ToString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(string))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60006A3")]
	public override int get_Count() { }

	[Address(RVA = "0x177F700", Offset = "0x177E900", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60006A2")]
	public Oid get_Item(int index) { }

	[Address(RVA = "0x30E8E0", Offset = "0x30DAE0", Length = "0x4")]
	[CallerCount(Count = 2057)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A7")]
	public override object get_SyncRoot() { }

	[Address(RVA = "0x177F390", Offset = "0x177E590", Length = "0x67")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A4")]
	public OidEnumerator GetEnumerator() { }

	[Address(RVA = "0x177F400", Offset = "0x177E600", Length = "0x23A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(OidCollection), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x60006A6")]
	private override void System.Collections.ICollection.CopyTo(Array array, int index) { }

	[Address(RVA = "0x177F390", Offset = "0x177E590", Length = "0x67")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60006A5")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

