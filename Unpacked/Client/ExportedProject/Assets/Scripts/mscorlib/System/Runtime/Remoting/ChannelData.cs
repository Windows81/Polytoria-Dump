namespace System.Runtime.Remoting;

[Token(Token = "0x2000342")]
internal class ChannelData
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000DE8")]
	internal string Ref; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000DE9")]
	internal string Type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000DEA")]
	internal string Id; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000DEB")]
	internal string DelayLoadAsClientChannel; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000DEC")]
	private ArrayList _serverProviders; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000DED")]
	private ArrayList _clientProviders; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000DEE")]
	private Hashtable _customProperties; //Field offset: 0x40

	[Token(Token = "0x170002D1")]
	public ArrayList ClientProviders
	{
		[Address(RVA = "0x1359C90", Offset = "0x1358E90", Length = "0x69")]
		[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001A21")]
		 get { } //Length: 105
	}

	[Token(Token = "0x170002D2")]
	public Hashtable CustomProperties
	{
		[Address(RVA = "0x1359D00", Offset = "0x1358F00", Length = "0x69")]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001A22")]
		 get { } //Length: 105
	}

	[Token(Token = "0x170002D0")]
	internal ArrayList ServerProviders
	{
		[Address(RVA = "0x1359D70", Offset = "0x1358F70", Length = "0x69")]
		[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Token(Token = "0x6001A20")]
		internal get { } //Length: 105
	}

	[Address(RVA = "0x1359BC0", Offset = "0x1358DC0", Length = "0xC4")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001A24")]
	public ChannelData() { }

	[Address(RVA = "0x1359280", Offset = "0x1358480", Length = "0x93B")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(ProviderData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ProviderData)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802D83A0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(ChannelData), Member = "get_CustomProperties", ReturnType = typeof(Hashtable))]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001A23")]
	public void CopyFrom(ChannelData other) { }

	[Address(RVA = "0x1359C90", Offset = "0x1358E90", Length = "0x69")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001A21")]
	public ArrayList get_ClientProviders() { }

	[Address(RVA = "0x1359D00", Offset = "0x1358F00", Length = "0x69")]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ReadChannel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IAttrList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ChannelData), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ChannelData)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001A22")]
	public Hashtable get_CustomProperties() { }

	[Address(RVA = "0x1359D70", Offset = "0x1358F70", Length = "0x69")]
	[CalledBy(Type = typeof(RemotingConfiguration), Member = "RegisterChannels", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ArrayList), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ConfigHandler), Member = "ParseElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(IAttrList)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001A20")]
	internal ArrayList get_ServerProviders() { }

}

