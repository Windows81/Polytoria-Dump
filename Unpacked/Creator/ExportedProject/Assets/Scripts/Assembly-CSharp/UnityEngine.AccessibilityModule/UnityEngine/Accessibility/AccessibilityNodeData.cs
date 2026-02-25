namespace UnityEngine.Accessibility;

[NativeHeader("Modules/Accessibility/Bindings/AccessibilityNodeData.bindings.h")]
[NativeHeader("Modules/Accessibility/Native/AccessibilityNodeData.h")]
[NativeType(CodegenOptions::Custom (1), "MonoAccessibilityNodeData")]
[RequiredByNativeCode]
[Token(Token = "0x2000008")]
internal struct AccessibilityNodeData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000020")]
	private int <id>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000021")]
	private bool <isActive>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000022")]
	private string <label>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000023")]
	private string <value>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000024")]
	private string <hint>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000025")]
	private AccessibilityRole <role>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x22")]
	[Token(Token = "0x4000026")]
	private bool <allowsDirectInteraction>k__BackingField; //Field offset: 0x22
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000027")]
	private AccessibilityState <state>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000028")]
	private Rect <frame>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000029")]
	private int <parentId>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400002A")]
	private Int32[] <childIds>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400002B")]
	private readonly bool <isFocused>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x4C")]
	[Token(Token = "0x400002C")]
	private SystemLanguage <language>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400002D")]
	private bool <implementsSelected>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x51")]
	[Token(Token = "0x400002E")]
	private bool <implementsDismissed>k__BackingField; //Field offset: 0x51

	[Token(Token = "0x17000012")]
	public bool allowsDirectInteraction
	{
		[Address(RVA = "0x1268F90", Offset = "0x1268190", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000032")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000016")]
	public Int32[] childIds
	{
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000036")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000014")]
	public Rect frame
	{
		[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
		[CallerCount(Count = 3)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000034")]
		 set { } //Length: 8
	}

	[Token(Token = "0x17000010")]
	public string hint
	{
		[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000030")]
		 set { } //Length: 13
	}

	[Token(Token = "0x1700000C")]
	public int id
	{
		[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
		[CallerCount(Count = 11)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600002C")]
		 set { } //Length: 3
	}

	[Token(Token = "0x17000019")]
	public bool implementsDismissed
	{
		[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000039")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000018")]
	public bool implementsSelected
	{
		[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000038")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000D")]
	public bool isActive
	{
		[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600002D")]
		 set { } //Length: 4
	}

	[Token(Token = "0x1700000E")]
	public string label
	{
		[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600002E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000017")]
	internal SystemLanguage language
	{
		[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000037")]
		internal set { } //Length: 4
	}

	[Token(Token = "0x17000015")]
	public int parentId
	{
		[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000035")]
		 set { } //Length: 4
	}

	[Token(Token = "0x17000011")]
	public AccessibilityRole role
	{
		[Address(RVA = "0x18FCBE0", Offset = "0x18FBDE0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000031")]
		 set { } //Length: 5
	}

	[Token(Token = "0x17000013")]
	public AccessibilityState state
	{
		[Address(RVA = "0x18FCBF0", Offset = "0x18FBDF0", Length = "0x5")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[Token(Token = "0x6000033")]
		 set { } //Length: 5
	}

	[Token(Token = "0x1700000F")]
	public string value
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600002F")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1268F90", Offset = "0x1268190", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000032")]
	public void set_allowsDirectInteraction(bool value) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000036")]
	public void set_childIds(Int32[] value) { }

	[Address(RVA = "0x3B8870", Offset = "0x3B7A70", Length = "0x8")]
	[CallerCount(Count = 3)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000034")]
	public void set_frame(Rect value) { }

	[Address(RVA = "0x2F73E0", Offset = "0x2F65E0", Length = "0xD")]
	[CallerCount(Count = 9)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000030")]
	public void set_hint(string value) { }

	[Address(RVA = "0x344930", Offset = "0x343B30", Length = "0x3")]
	[CallerCount(Count = 11)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002C")]
	public void set_id(int value) { }

	[Address(RVA = "0x3EB980", Offset = "0x3EAB80", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000039")]
	public void set_implementsDismissed(bool value) { }

	[Address(RVA = "0x3EB960", Offset = "0x3EAB60", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000038")]
	public void set_implementsSelected(bool value) { }

	[Address(RVA = "0x18FCBD0", Offset = "0x18FBDD0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002D")]
	public void set_isActive(bool value) { }

	[Address(RVA = "0x344920", Offset = "0x343B20", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002E")]
	public void set_label(string value) { }

	[Address(RVA = "0x5B9B40", Offset = "0x5B8D40", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000037")]
	internal void set_language(SystemLanguage value) { }

	[Address(RVA = "0x3212B0", Offset = "0x3204B0", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000035")]
	public void set_parentId(int value) { }

	[Address(RVA = "0x18FCBE0", Offset = "0x18FBDE0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000031")]
	public void set_role(AccessibilityRole value) { }

	[Address(RVA = "0x18FCBF0", Offset = "0x18FBDF0", Length = "0x5")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[Token(Token = "0x6000033")]
	public void set_state(AccessibilityState value) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600002F")]
	public void set_value(string value) { }

}

