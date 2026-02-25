namespace Polytoria.Datamodel;

[Instantiatable]
[Token(Token = "0x200032E")]
public class IntValue : ValueBase
{
	[FieldOffset(Offset = "0x100")]
	[SyncVar(hook = "OnValueChanged")]
	[Token(Token = "0x4000CBB")]
	private int val; //Field offset: 0x100
	[FieldOffset(Offset = "0x108")]
	[Token(Token = "0x4000CBC")]
	public Action<Int32, Int32> _Mirror_SyncVarHookDelegate_val; //Field offset: 0x108

	[Token(Token = "0x17000981")]
	public int Networkval
	{
		[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E8D")]
		 get { } //Length: 7
		[Address(RVA = "0x42DB10", Offset = "0x42CD10", Length = "0x65")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Token(Token = "0x6001E8E")]
		 set { } //Length: 101
	}

	[Archivable]
	[CreatorProperty]
	[Token(Token = "0x17000980")]
	public int Value
	{
		[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6001E87")]
		 get { } //Length: 7
		[Address(RVA = "0x42DB80", Offset = "0x42CD80", Length = "0x77")]
		[CalledBy(Type = typeof(IntValue), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IntValue), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(IntValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
		[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
		[Token(Token = "0x6001E88")]
		 set { } //Length: 119
	}

	[Address(RVA = "0x42DA70", Offset = "0x42CC70", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ValueBase), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Action`2), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(IntPtr)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001E8B")]
	public IntValue() { }

	[Address(RVA = "0x42D850", Offset = "0x42CA50", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "set_Name", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(IntValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001E89")]
	protected virtual void CopyProperties(Instance clone) { }

	[Address(RVA = "0x42D8F0", Offset = "0x42CAF0", Length = "0x9B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Instance), Member = "DeserializeSyncVars", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkReaderExtensions), Member = "ReadVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkReader)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(NetworkBehaviour), Member = "GeneratedSyncVarDeserialize", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32&), typeof(System.Action`2<System.Int32, System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E90")]
	public virtual void DeserializeSyncVars(NetworkReader reader, bool initialState) { }

	[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E8D")]
	public int get_Networkval() { }

	[Address(RVA = "0x42DB00", Offset = "0x42CD00", Length = "0x7")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E87")]
	public int get_Value() { }

	[Address(RVA = "0x42D990", Offset = "0x42CB90", Length = "0x4D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkBehaviour), Member = "get_isServer", ReturnType = typeof(bool))]
	[Calls(Type = typeof(IntValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
	[Token(Token = "0x6001E8A")]
	private void OnValueChanged(int oldValue, int newValue) { }

	[Address(RVA = "0x42D9E0", Offset = "0x42CBE0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarULong", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(ulong)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteString", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NetworkWriterExtensions), Member = "WriteVarInt", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NetworkWriter), typeof(int)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001E8F")]
	public virtual void SerializeSyncVars(NetworkWriter writer, bool forceAll) { }

	[Address(RVA = "0x42DB10", Offset = "0x42CD10", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Token(Token = "0x6001E8E")]
	public void set_Networkval(in int value) { }

	[Address(RVA = "0x42DB80", Offset = "0x42CD80", Length = "0x77")]
	[CalledBy(Type = typeof(IntValue), Member = "CopyProperties", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Instance)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IntValue), Member = "OnValueChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(IntValueProxy), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001CC40")]
	[Calls(Type = typeof(ValueBase), Member = "InvokeChanged", ReturnType = typeof(void))]
	[Token(Token = "0x6001E88")]
	public void set_Value(int value) { }

	[Address(RVA = "0x2FE390", Offset = "0x2FD590", Length = "0x3")]
	[CallerCount(Count = 15)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001E8C")]
	public virtual bool Weaved() { }

}

