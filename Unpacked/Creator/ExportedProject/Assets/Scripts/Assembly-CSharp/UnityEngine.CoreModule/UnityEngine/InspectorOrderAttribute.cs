namespace UnityEngine;

[AttributeUsage(AttributeTargets::Enum (16))]
[Token(Token = "0x200014B")]
public sealed class InspectorOrderAttribute : PropertyAttribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000561")]
	private InspectorSort <m_inspectorSort>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x1C")]
	[Token(Token = "0x4000562")]
	private InspectorSortDirection <m_sortDirection>k__BackingField; //Field offset: 0x1C

	[Token(Token = "0x17000190")]
	internal InspectorSort m_inspectorSort
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000996")]
		internal get { } //Length: 4
	}

	[Token(Token = "0x17000191")]
	internal InspectorSortDirection m_sortDirection
	{
		[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000997")]
		internal get { } //Length: 4
	}

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000996")]
	internal InspectorSort get_m_inspectorSort() { }

	[Address(RVA = "0x3893F0", Offset = "0x3885F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000997")]
	internal InspectorSortDirection get_m_sortDirection() { }

}

