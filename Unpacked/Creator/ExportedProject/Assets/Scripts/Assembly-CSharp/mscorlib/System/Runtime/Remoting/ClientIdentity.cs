namespace System.Runtime.Remoting;

[Token(Token = "0x200033D")]
internal class ClientIdentity : Identity
{
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000DC9")]
	private WeakReference _proxyReference; //Field offset: 0x48

	[Token(Token = "0x170002C6")]
	public MarshalByRefObject ClientProxy
	{
		[Address(RVA = "0x135F0E0", Offset = "0x135E2E0", Length = "0x8A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019DC")]
		 get { } //Length: 138
		[Address(RVA = "0x135F1A0", Offset = "0x135E3A0", Length = "0x6D")]
		[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
		[CalledBy(Type = typeof(RemotingProxy), Member = "AttachIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x60019DD")]
		 set { } //Length: 109
	}

	[Token(Token = "0x170002C7")]
	public string TargetUri
	{
		[Address(RVA = "0x135F170", Offset = "0x135E370", Length = "0x2A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x60019DF")]
		 get { } //Length: 42
	}

	[Address(RVA = "0x135F000", Offset = "0x135E200", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60019DB")]
	public ClientIdentity(string objectUri, ObjRef objRef) { }

	[Address(RVA = "0x309610", Offset = "0x308810", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60019DE")]
	public virtual ObjRef CreateObjRef(Type requestedType) { }

	[Address(RVA = "0x135F0E0", Offset = "0x135E2E0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019DC")]
	public MarshalByRefObject get_ClientProxy() { }

	[Address(RVA = "0x135F170", Offset = "0x135E370", Length = "0x2A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x60019DF")]
	public string get_TargetUri() { }

	[Address(RVA = "0x135F1A0", Offset = "0x135E3A0", Length = "0x6D")]
	[CalledBy(Type = typeof(RemotingServices), Member = "GetOrCreateClientIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ObjRef), typeof(Type), typeof(Object&)}, ReturnType = typeof(ClientIdentity))]
	[CalledBy(Type = typeof(RemotingProxy), Member = "AttachIdentity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Identity)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60019DD")]
	public void set_ClientProxy(MarshalByRefObject value) { }

}

