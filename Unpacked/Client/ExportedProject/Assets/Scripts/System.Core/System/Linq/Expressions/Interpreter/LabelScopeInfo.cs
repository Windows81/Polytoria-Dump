namespace System.Linq.Expressions.Interpreter;

[Token(Token = "0x2000155")]
internal sealed class LabelScopeInfo
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40002A2")]
	private HybridReferenceDictionary<LabelTarget, LabelInfo> _labels; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40002A3")]
	internal readonly LabelScopeKind Kind; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40002A4")]
	internal readonly LabelScopeInfo Parent; //Field offset: 0x20

	[Token(Token = "0x17000193")]
	internal bool CanJumpInto
	{
		[Address(RVA = "0x15B8560", Offset = "0x15B7760", Length = "0x8")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6000728")]
		internal get { } //Length: 8
	}

	[Address(RVA = "0x15B8510", Offset = "0x15B7710", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000727")]
	internal LabelScopeInfo(LabelScopeInfo parent, LabelScopeKind kind) { }

	[Address(RVA = "0x15B8360", Offset = "0x15B7560", Length = "0xBA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600072B")]
	internal void AddLabelInfo(LabelTarget target, LabelInfo info) { }

	[Address(RVA = "0x15B8420", Offset = "0x15B7620", Length = "0x5D")]
	[CalledBy(Type = typeof(LightCompiler), Member = "TryPushLabelBlock", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Expression)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey"}, ReturnType = typeof(bool))]
	[Token(Token = "0x6000729")]
	internal bool ContainsTarget(LabelTarget target) { }

	[Address(RVA = "0x15B8560", Offset = "0x15B7760", Length = "0x8")]
	[CallerCount(Count = 0)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000728")]
	internal bool get_CanJumpInto() { }

	[Address(RVA = "0x15B8480", Offset = "0x15B7680", Length = "0x83")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(HybridReferenceDictionary`2), Member = "TryGetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TKey", "TValue&"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600072A")]
	internal bool TryGetLabelInfo(LabelTarget target, out LabelInfo info) { }

}

