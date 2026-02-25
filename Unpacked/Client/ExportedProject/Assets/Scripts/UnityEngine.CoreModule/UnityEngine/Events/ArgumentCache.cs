namespace UnityEngine.Events;

[Token(Token = "0x20001BA")]
internal class ArgumentCache : ISerializationCallbackReceiver
{
	[FieldOffset(Offset = "0x10")]
	[FormerlySerializedAs("objectArgument")]
	[SerializeField]
	[Token(Token = "0x4000646")]
	private object m_ObjectArgument; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[FormerlySerializedAs("objectArgumentAssemblyTypeName")]
	[SerializeField]
	[Token(Token = "0x4000647")]
	private string m_ObjectArgumentAssemblyTypeName; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[FormerlySerializedAs("intArgument")]
	[SerializeField]
	[Token(Token = "0x4000648")]
	private int m_IntArgument; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[FormerlySerializedAs("floatArgument")]
	[SerializeField]
	[Token(Token = "0x4000649")]
	private float m_FloatArgument; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[FormerlySerializedAs("stringArgument")]
	[SerializeField]
	[Token(Token = "0x400064A")]
	private string m_StringArgument; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[Token(Token = "0x400064B")]
	private bool m_BoolArgument; //Field offset: 0x30

	[Token(Token = "0x170001FD")]
	public bool boolArgument
	{
		[Address(RVA = "0x1979D90", Offset = "0x1978F90", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C01")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001FB")]
	public float floatArgument
	{
		[Address(RVA = "0x1979DA0", Offset = "0x1978FA0", Length = "0x8")]
		[CallerCount(Count = 10)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFF")]
		 get { } //Length: 8
	}

	[Token(Token = "0x170001FA")]
	public int intArgument
	{
		[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
		[CallerCount(Count = 20)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFE")]
		 get { } //Length: 6
	}

	[Token(Token = "0x170001FC")]
	public string stringArgument
	{
		[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000C00")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001F8")]
	public object unityObjectArgument
	{
		[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
		[CallerCount(Count = 196)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFC")]
		 get { } //Length: 7
	}

	[Token(Token = "0x170001F9")]
	public string unityObjectArgumentAssemblyTypeName
	{
		[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
		[CallerCount(Count = 73)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BFD")]
		 get { } //Length: 7
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C04")]
	public ArgumentCache() { }

	[Address(RVA = "0x1979D90", Offset = "0x1978F90", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C01")]
	public bool get_boolArgument() { }

	[Address(RVA = "0x1979DA0", Offset = "0x1978FA0", Length = "0x8")]
	[CallerCount(Count = 10)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFF")]
	public float get_floatArgument() { }

	[Address(RVA = "0xFE9830", Offset = "0xFE8A30", Length = "0x6")]
	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFE")]
	public int get_intArgument() { }

	[Address(RVA = "0x1979DB0", Offset = "0x1978FB0", Length = "0x7")]
	[CallerCount(Count = 4)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C00")]
	public string get_stringArgument() { }

	[Address(RVA = "0xC4A010", Offset = "0xC49210", Length = "0x7")]
	[CallerCount(Count = 196)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFC")]
	public object get_unityObjectArgument() { }

	[Address(RVA = "0xB081E0", Offset = "0xB073E0", Length = "0x7")]
	[CallerCount(Count = 73)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BFD")]
	public string get_unityObjectArgumentAssemblyTypeName() { }

	[Address(RVA = "0x1979D60", Offset = "0x1978F60", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C03")]
	public override void OnAfterDeserialize() { }

	[Address(RVA = "0x1979D60", Offset = "0x1978F60", Length = "0x29")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000C02")]
	public override void OnBeforeSerialize() { }

}

