namespace UnityEngine.UIElements;

[Token(Token = "0x2000188")]
public abstract class DragAndDropData
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000765")]
	private String[] <paths>k__BackingField; //Field offset: 0x10

	[Token(Token = "0x1700020A")]
	public override String[] paths
	{
		[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6000BA3")]
		 set { } //Length: 13
	}

	[Token(Token = "0x17000209")]
	public abstract object source
	{
		[Token(Token = "0x6000BA2")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA4")]
	protected DragAndDropData() { }

	[Token(Token = "0x6000BA2")]
	public abstract object get_source() { }

	[Token(Token = "0x6000BA1")]
	public abstract object GetGenericData(string key) { }

	[Address(RVA = "0x2DD620", Offset = "0x2DC820", Length = "0xD")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6000BA3")]
	public override void set_paths(String[] value) { }

}

