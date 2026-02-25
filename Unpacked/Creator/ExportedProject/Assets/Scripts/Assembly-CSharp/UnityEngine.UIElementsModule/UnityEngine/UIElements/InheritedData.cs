namespace UnityEngine.UIElements;

[Token(Token = "0x20003DF")]
internal struct InheritedData : IStyleDataGroup<InheritedData>, IEquatable<InheritedData>
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000CD4")]
	public Color color; //Field offset: 0x0
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000CD5")]
	public Length fontSize; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000CD6")]
	public Length letterSpacing; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000CD7")]
	public TextShadow textShadow; //Field offset: 0x20
	[FieldOffset(Offset = "0x3C")]
	[Token(Token = "0x4000CD8")]
	public EditorTextRenderingMode unityEditorTextRenderingMode; //Field offset: 0x3C
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x4000CD9")]
	public Font unityFont; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000CDA")]
	public FontDefinition unityFontDefinition; //Field offset: 0x48
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x4000CDB")]
	public FontStyle unityFontStyleAndWeight; //Field offset: 0x58
	[FieldOffset(Offset = "0x5C")]
	[Token(Token = "0x4000CDC")]
	public Length unityParagraphSpacing; //Field offset: 0x5C
	[FieldOffset(Offset = "0x64")]
	[Token(Token = "0x4000CDD")]
	public TextAnchor unityTextAlign; //Field offset: 0x64
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x4000CDE")]
	public TextGeneratorType unityTextGenerator; //Field offset: 0x68
	[FieldOffset(Offset = "0x6C")]
	[Token(Token = "0x4000CDF")]
	public Color unityTextOutlineColor; //Field offset: 0x6C
	[FieldOffset(Offset = "0x7C")]
	[Token(Token = "0x4000CE0")]
	public float unityTextOutlineWidth; //Field offset: 0x7C
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x4000CE1")]
	public Visibility visibility; //Field offset: 0x80
	[FieldOffset(Offset = "0x84")]
	[Token(Token = "0x4000CE2")]
	public WhiteSpace whiteSpace; //Field offset: 0x84
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x4000CE3")]
	public Length wordSpacing; //Field offset: 0x88

	[Address(RVA = "0x1B0C5A0", Offset = "0x1B0B7A0", Length = "0x50")]
	[CallerCount(Count = 9)]
	[DeduplicatedMethod]
	[Token(Token = "0x6001D7A")]
	public override InheritedData Copy() { }

	[Address(RVA = "0x1B0C510", Offset = "0x1B0B710", Length = "0x81")]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6001D7B")]
	public override void CopyFrom(ref InheritedData other) { }

	[Address(RVA = "0x1B0C5F0", Offset = "0x1B0B7F0", Length = "0xCF")]
	[CalledBy(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>", "UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.StyleDataRef`1<T>"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(InheritedData), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData), typeof(InheritedData)}, ReturnType = typeof(bool))]
	[Token(Token = "0x6001D7D")]
	public override bool Equals(InheritedData other) { }

	[Address(RVA = "0x1B0C6C0", Offset = "0x1B0B8C0", Length = "0xFF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_object_unbox")]
	[Calls(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Token(Token = "0x6001D7E")]
	public virtual bool Equals(object obj) { }

	[Address(RVA = "0x1B0C7C0", Offset = "0x1B0B9C0", Length = "0x1B5")]
	[CalledBy(Type = typeof(StyleDataRef`1), Member = "GetHashCode", ReturnType = typeof(int))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Color), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(TextShadow), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(FontDefinition), Member = "GetHashCode", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001D7F")]
	public virtual int GetHashCode() { }

	[Address(RVA = "0x1B0C980", Offset = "0x1B0BB80", Length = "0x5F8")]
	[CalledBy(Type = typeof(InheritedData), Member = "Equals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(InheritedData)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(TextShadow), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextShadow), typeof(TextShadow)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[CallsDeduplicatedMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001D7C")]
	public static bool op_Equality(InheritedData lhs, InheritedData rhs) { }

}

