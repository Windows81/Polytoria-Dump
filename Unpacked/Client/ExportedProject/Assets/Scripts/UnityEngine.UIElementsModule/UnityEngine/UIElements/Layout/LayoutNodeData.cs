namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005D7")]
internal struct LayoutNodeData
{
	[Flags]
	[Token(Token = "0x20005D8")]
	public enum FlexStatus
	{
		IsDirty = 1,
		HasNewLayout = 4,
		DependsOnParentSize = 64,
		UsesMeasure = 128,
		UsesBaseline = 256,
		Fixed = 8,
		MinViolation = 16,
		MaxViolation = 32,
	}

	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001523")]
	public FixedBuffer2<LayoutValue> ResolvedDimensions; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4001524")]
	private float TargetSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x14")]
	[Token(Token = "0x4001525")]
	public int ManagedOwnerIndex; //Field offset: 0x14
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4001526")]
	public int LineIndex; //Field offset: 0x18
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4001527")]
	public LayoutHandle Config; //Field offset: 0x1C
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4001528")]
	public LayoutHandle Parent; //Field offset: 0x24
	[FieldOffset(Offset = "0x2C")]
	[Token(Token = "0x4001529")]
	public LayoutHandle NextChild; //Field offset: 0x2C
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400152A")]
	public LayoutList<LayoutHandle> Children; //Field offset: 0x38
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400152B")]
	private FlexStatus Status; //Field offset: 0x48

	[Token(Token = "0x17000A7D")]
	public bool HasNewLayout
	{
		[Address(RVA = "0x1BAC230", Offset = "0x1BAB430", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600297E")]
		 get { } //Length: 9
		[Address(RVA = "0x1BAC260", Offset = "0x1BAB460", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600297F")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000A7E")]
	public bool IsDirty
	{
		[Address(RVA = "0x1BAC240", Offset = "0x1BAB440", Length = "0x7")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002980")]
		 get { } //Length: 7
		[Address(RVA = "0x1BAC280", Offset = "0x1BAB480", Length = "0x19")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002981")]
		 set { } //Length: 25
	}

	[Token(Token = "0x17000A80")]
	public bool UsesBaseline
	{
		[Address(RVA = "0x1BAC2A0", Offset = "0x1BAB4A0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002984")]
		 set { } //Length: 27
	}

	[Token(Token = "0x17000A7F")]
	public bool UsesMeasure
	{
		[Address(RVA = "0x1BAC250", Offset = "0x1BAB450", Length = "0x9")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x6002982")]
		 get { } //Length: 9
		[Address(RVA = "0x1BAC2C0", Offset = "0x1BAB4C0", Length = "0x1B")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002983")]
		 set { } //Length: 27
	}

	[Address(RVA = "0x1BAC230", Offset = "0x1BAB430", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600297E")]
	public bool get_HasNewLayout() { }

	[Address(RVA = "0x1BAC240", Offset = "0x1BAB440", Length = "0x7")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002980")]
	public bool get_IsDirty() { }

	[Address(RVA = "0x1BAC250", Offset = "0x1BAB450", Length = "0x9")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002982")]
	public bool get_UsesMeasure() { }

	[Address(RVA = "0x1BAC260", Offset = "0x1BAB460", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x600297F")]
	public void set_HasNewLayout(bool value) { }

	[Address(RVA = "0x1BAC280", Offset = "0x1BAB480", Length = "0x19")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002981")]
	public void set_IsDirty(bool value) { }

	[Address(RVA = "0x1BAC2A0", Offset = "0x1BAB4A0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002984")]
	public void set_UsesBaseline(bool value) { }

	[Address(RVA = "0x1BAC2C0", Offset = "0x1BAB4C0", Length = "0x1B")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002983")]
	public void set_UsesMeasure(bool value) { }

}

