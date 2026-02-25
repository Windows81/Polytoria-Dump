namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x2000361")]
public class StringValue : ValueBase
{
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "OnValueChanged")]
	[Token(Token = "0x4000E5A")]
	private string val; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000E5B")]
	public Action<String, String> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	[Token(Token = "0x17000AA7")]
	public string Networkval
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x600235F")]
		 get { } //Length: 8
		[Address(RVA = "0x475A70", Offset = "0x474C70", Length = "0x67")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Token(Token = "0x6002360")]
		 set { } //Length: 103
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000AA6")]
	public string Value
	{
		[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002359")]
		 get { } //Length: 8
		[Address(RVA = "0x475AE0", Offset = "0x474CE0", Length = "0x83")]
		[CalledBy(Type = typeof(StringValue), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StringValue), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(StringValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
		[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x600235A")]
		 set { } //Length: 131
	}

	[Address(RVA = "0x4759E0", Offset = "0x474BE0", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600235D")]
	public StringValue() { }

	[Address(RVA = "0x4757E0", Offset = "0x4749E0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(StringValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x600235B")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x475880", Offset = "0x474A80", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object&), typeof(System.Action`2<System.Object, System.Object>), typeof(object)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6002362")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x600235F")]
	public string get_Networkval() { }

	[Address(RVA = "0x3F58D0", Offset = "0x3F4AD0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002359")]
	public string get_Value() { }

	[Address(RVA = "0x475920", Offset = "0x474B20", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(StringValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600235C")]
	private void OnValueChanged(string oldValue, string newValue) { }

	[Address(RVA = "0x475980", Offset = "0x474B80", Length = "0x5C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Instance), Member = "SerializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Token(Token = "0x6002361")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x475A70", Offset = "0x474C70", Length = "0x67")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Token(Token = "0x6002360")]
	public void set_Networkval(in string value) { }

	[Address(RVA = "0x475AE0", Offset = "0x474CE0", Length = "0x83")]
	[CalledBy(Type = typeof(StringValue), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringValue), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(StringValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001C130")]
	[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600235A")]
	public void set_Value(string value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x600235E")]
	public virtual bool Weaved() { }

}

