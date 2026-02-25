namespace UnityEngine.UIElements;

[Token(Token = "0x200050E")]
internal class PathRef
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40010BF")]
	private PropertyPath m_Path; //Field offset: 0x10

	[Token(Token = "0x170009AA")]
	public bool IsEmpty
	{
		[Address(RVA = "0x1B669A0", Offset = "0x1B65BA0", Length = "0xB")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_isDataSourcePathEmpty", ReturnType = typeof(bool))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[Token(Token = "0x6002501")]
		 get { } //Length: 11
	}

	[Token(Token = "0x170009A9")]
	public PropertyPath path
	{
		[Address(RVA = "0x1B669B0", Offset = "0x1B65BB0", Length = "0x5")]
		[CalledBy(Type = typeof(VisualElement), Member = "get_dataSourcePath", ReturnType = typeof(PropertyPath))]
		[CalledBy(Type = typeof(VisualElement), Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Token(Token = "0x6002500")]
		 get { } //Length: 5
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002502")]
	public PathRef() { }

	[Address(RVA = "0x1B669A0", Offset = "0x1B65BA0", Length = "0xB")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_isDataSourcePathEmpty", ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PropertyPath), Member = "get_IsEmpty", ReturnType = typeof(bool))]
	[Token(Token = "0x6002501")]
	public bool get_IsEmpty() { }

	[Address(RVA = "0x1B669B0", Offset = "0x1B65BB0", Length = "0x5")]
	[CalledBy(Type = typeof(VisualElement), Member = "get_dataSourcePath", ReturnType = typeof(PropertyPath))]
	[CalledBy(Type = typeof(VisualElement), Member = "set_dataSourcePath", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(PropertyPath)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Token(Token = "0x6002500")]
	public PropertyPath get_path() { }

}

